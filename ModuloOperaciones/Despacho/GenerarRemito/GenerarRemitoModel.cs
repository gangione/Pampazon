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
            .Where(t => t.DNI == dniTransportista)
            .Select(t => t)
            .FirstOrDefault();

        if (transportista is null)
            return new Resultado<bool>(
                false,
                $"No se enontró el Transportista con DNI {dniTransportista}.",
                false
            );

        List<OrdenDeEntrega> listoParaRetirar = ObtenerDetalleARetirarPorTransportista(dniTransportista);

        if (listoParaRetirar.Count == 0)
            return new Resultado<bool>(
                false,
                "El Transportista seleccionado no posee ordenes a despachar.",
                false
            );

        // Actualizar el estado de las órdenes.
        var opsEntregadas = new List<int>();
        var entregasCumplidas = new List<OrdenDeEntregaEnt>();
        foreach (var entrega in listoParaRetirar)
        {
            var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.NumeroOP == entrega.NroOrdenDePreparacion &&
                    op.Estado == OPEstadoEnum.Preparada
                )
                .Select(op =>
                {
                    op.Estado = OPEstadoEnum.Despachada;
                    return op;
                })
                .First();

            var oe = OrdenDeEntregaAlmacen.OrdenesDeEntrega
                .Where(oe => oe.OrdenesDePreparacion.Contains(op.NumeroOP) &&
                    oe.Estado == OEEstadoEnum.Pendiente
                )
                .Select(oe =>
                {
                    oe.Estado = OEEstadoEnum.Cumplida;
                    return oe;
                })
                .First();

            if (!entregasCumplidas.Exists(e => e.NumeroOE == oe.NumeroOE))
                entregasCumplidas.Add(oe);

            opsEntregadas.Add(op.NumeroOP);
            OrdenDePreparacionAlmacen.Actualizar(op);
        }

        // Crear el remito y guardar toda la transacción.
        RemitoEnt remito = new()
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
            "Ordenes de preparación despacahadas.\n\n" +
            "Se ha generado el remito correctamente.\n",
            true
        );
    }
}