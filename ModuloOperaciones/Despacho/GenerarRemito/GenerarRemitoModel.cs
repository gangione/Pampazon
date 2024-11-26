using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public class GenerarRemitoModel
{
    public GenerarRemitoModel()
    {
    }
    public List<Transportista> ObtenerTransportistas()
    {
        return TransportistaAlmacen.Transportistas
            .Select(t =>
            {
                return new Transportista()
                {
                    DNI = t.DNI,
                    NombreYApellido = t.NombreApellido
                };
            })
            .ToList();
    }
    public List<OrdenDeEntrega> ObtenerDetalleARetirarPorTransportistaYDeposito(string dniTransportista, Deposito deposito)
    {
        var entregasPendientes = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => op.Estado == OPEstadoEnum.Preparada &&
                op.Deposito == Enum.Parse<DepositoEnum>(deposito.ToString())
            )
            .ToList();

        var transportista = TransportistaAlmacen.Transportistas
            .Where(tr => tr.DNI == dniTransportista)
            .First();

        var detalleDeEntrega = new List<OrdenDeEntrega>();
        foreach (var op in entregasPendientes)
        {
            if (op.NumeroTransportista == transportista.NumeroTransportista)
                op.Detalle.ForEach(detalle =>
                {
                    detalleDeEntrega.Add(new()
                    {
                        NroOrdenDePreparacion = op.NumeroOP,
                        Cliente = ClienteAlmacen.Clientes
                            .Where(c => c.NumeroCliente == op.NumeroCliente)
                        .Select(c => c.RazonSocial)
                        .First(),

                        Cantidad = detalle.Cantidad,
                        SKU = detalle.SKU
                    });
                });
        }
        return detalleDeEntrega;
    }
    public Resultado<bool> DespacharOrdenesDePreparacion(string dniTransportista, Deposito deposito)
    {
        var transportista = TransportistaAlmacen.Transportistas
            .FirstOrDefault(t => t.DNI == dniTransportista);

        if (transportista is null)
            return new Resultado<bool>(
                false,
                $"No se encontró el transportista con DNI {dniTransportista}.",
                false
            );

        // Obtener las órdenes de entrega pendientes para el transportista
        var listoParaRetirar = ObtenerDetalleARetirarPorTransportistaYDeposito(dniTransportista, deposito);

        if (!listoParaRetirar.Any())
            return new Resultado<bool>(
                false,
                "El transportista seleccionado no posee órdenes a despachar.",
                false
            );

        var opsEntregadas = new List<OrdenDePreparacionEnt>();
        var entregasCumplidas = new List<OrdenDeEntregaEnt>();

        // Agrupar las órdenes de preparación por cliente
        var ordenesAgrupadasPorCliente = listoParaRetirar
            .GroupBy(entrega => entrega.Cliente)
            .ToList();

        var remitos = new List<RemitoEnt>();

        foreach (var grupoCliente in ordenesAgrupadasPorCliente)
        {
            // Crear un nuevo remito para el cliente
            var remito = new RemitoEnt()
            {
                NumeroTransportista = transportista.NumeroTransportista,
                NumeroCliente = ClienteAlmacen.Clientes
                    .Where(c => c.RazonSocial.ToUpper() == grupoCliente.Key.ToUpper())
                    .Select(c => c.NumeroCliente)
                    .First()
            };

            foreach (var entrega in grupoCliente.DistinctBy(oe => oe.NroOrdenDePreparacion))
            {
                var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
                    .Where(op => op.NumeroOP == entrega.NroOrdenDePreparacion &&
                                 op.Estado == OPEstadoEnum.Preparada)
                    .Select(op =>
                    {
                        op.Estado = OPEstadoEnum.Despachada;
                        return op;
                    })
                    .FirstOrDefault();

                if (op is not null)
                {
                    opsEntregadas.Add(op);
                    remito.OrdenesDePreparacion.Add(op.NumeroOP);
                }

                var oe = OrdenDeEntregaAlmacen.OrdenesDeEntrega
                    .Where(oe => oe.NumeroOP == op.NumeroOP && oe.Estado == OEEstadoEnum.Pendiente)
                    .Select(oe =>
                    {
                        oe.Estado = OEEstadoEnum.Cumplida;
                        return oe;
                    })
                    .FirstOrDefault();

                if (oe is not null && !entregasCumplidas.Exists(entrega => entrega.NumeroOE == oe.NumeroOE))
                    entregasCumplidas.Add(oe);
            }

            remitos.Add(remito);
        }

        // Guardar los remitos y actualizar el estado de las órdenes
        RemitoAlmacen.AgregarEnLote(remitos);
        OrdenDePreparacionAlmacen.ActualizarEnLote(opsEntregadas);
        OrdenDeEntregaAlmacen.ActualizarEnLote(entregasCumplidas);

        // Grabo la transacción.
        RemitoAlmacen.Grabar();
        OrdenDePreparacionAlmacen.Grabar();
        OrdenDeEntregaAlmacen.Grabar();

        return new Resultado<bool>(
            true,
            "Órdenes de preparación despachadas correctamente.\n" +
            "Se han generado los remitos con éxito.\n",
            true
        );
    }
}