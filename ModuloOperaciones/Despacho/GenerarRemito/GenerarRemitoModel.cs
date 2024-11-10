using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
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
    public List<OrdenDeEntrega> ObtenerDetalleARetirarPorTransportista(string dniTransportista)
    {
        var entregasPendientes = OrdenDeEntregaAlmacen.OrdenesDeEntrega
            .Where(entrega => entrega.Estado == OEEstadoEnum.Pendiente)
            .ToList();

        var transportista = TransportistaAlmacen.Transportistas
            .Where(tr => tr.DNI == dniTransportista)
            .First();

        var detalleDeEntrega = new List<OrdenDeEntrega>();
        foreach (var oe in entregasPendientes)
        {
            var ops = OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Where(op => oe.OrdenesDePreparacion.Contains(op.NumeroOP) &&
                    op.Estado == OPEstadoEnum.Preparada
                )
                .ToList();

            ops.ForEach(op =>
            {
                if (transportista.NumeroTransportista == op.NumeroTransportista)
                {
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
            });
        }
        return detalleDeEntrega;
    }
    public Resultado<bool> DespacharOrdenesDePreparacion(string dniTransportista)
    {
        var transportista = TransportistaAlmacen.Transportistas
            .FirstOrDefault(t => t.DNI == dniTransportista);

        if (transportista is null)
            return new Resultado<bool>(
                false,
                $"No se encontró el transportista con DNI {dniTransportista}.",
                false
            );

        List<OrdenDeEntrega> listoParaRetirar = ObtenerDetalleARetirarPorTransportista(dniTransportista);

        if (!listoParaRetirar.Any())
            return new Resultado<bool>(
                false,
                "El transportista seleccionado no posee órdenes a despachar.",
                false
            );

        var opsEntregadas = new List<int>();
        var entregasCumplidas = new HashSet<int>();

        foreach (var entrega in listoParaRetirar)
        {
            var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
                .FirstOrDefault(op => op.NumeroOP == entrega.NroOrdenDePreparacion && op.Estado == OPEstadoEnum.Preparada);

            if (op != null)
            {
                op.Estado = OPEstadoEnum.Despachada;
                OrdenDePreparacionAlmacen.Actualizar(op);
                opsEntregadas.Add(op.NumeroOP);

                var oe = OrdenDeEntregaAlmacen.OrdenesDeEntrega
                    .FirstOrDefault(oe => oe.OrdenesDePreparacion.Contains(op.NumeroOP) && oe.Estado == OEEstadoEnum.Pendiente);

                if (oe != null && oe.OrdenesDePreparacion.All(numOP =>
                        OrdenDePreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(op => op.NumeroOP == numOP)?.Estado == OPEstadoEnum.Despachada))
                {
                    oe.Estado = OEEstadoEnum.Cumplida;
                    entregasCumplidas.Add(oe.NumeroOE);
                    OrdenDeEntregaAlmacen.Actualizar(oe);
                }
            }
        }

        // Crear el remito y guardar toda la transacción.
        var remito = new RemitoEnt
        {
            NumeroTransportista = transportista.NumeroTransportista
        };

        remito.OrdenesDePreparacion.AddRange(opsEntregadas);
        RemitoAlmacen.Agregar(remito);

        OrdenDeEntregaAlmacen.Grabar();
        OrdenDePreparacionAlmacen.Grabar();
        RemitoAlmacen.Grabar();

        return new Resultado<bool>(
            true,
            "Órdenes de preparación despachadas correctamente.\n" +
            "Se ha generado el remito con éxito.\n",
            true
        );
    }
}