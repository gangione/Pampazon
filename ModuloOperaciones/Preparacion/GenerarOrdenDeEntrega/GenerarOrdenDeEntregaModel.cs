using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;
public class GenerarOrdenDeEntregaModel
{
    public GenerarOrdenDeEntregaModel()
    {
    }

    public OrdenDeSeleccion? ObtenerSiguienteOrdenAEmpaquetar()
    {
        var os = OrdenDeSeleccionAlmacen.OrdenesSeleccion
            .Where(os => os.Estado == OSEstadoEnum.Cumplida)
            .Select(os =>
            {
                if (OrdenDePreparacionAlmacen.OrdenesPreparacion
                        .Where(op => os.OrdenesDePreparacion.Contains(op.NumeroOP))
                        .Select(op => op.Estado == OPEstadoEnum.Preparada)
                        .First())
                    return null;

                return new OrdenDeSeleccion()
                {
                    Numero = os.NumeroOS,
                    OrdenesASeleccionar = OrdenDePreparacionAlmacen.OrdenesPreparacion
                        .Where(op => os.OrdenesDePreparacion.Contains(op.NumeroOP))
                        .Select(op =>
                        {
                            return new OrdenDePreparacion()
                            {
                                Numero = op.NumeroOP,
                                Estado = Enum.Parse<OPEstado>(op.Estado.ToString()),
                                Prioridad = Enum.Parse<Prioridad>(op.Prioridad.ToString()),
                                FechaADespachar = op.FechaADespachar,
                                MercaderiasAPreparar = op.Detalle
                                    .Select(d =>
                                    {
                                        return new Mercaderia()
                                        {
                                            SKU = d.SKU,
                                            Cantidad = d.Cantidad,
                                            Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                                .Where(m => m.SKU == d.SKU)
                                                .Select(m => m.TipoDeMercaderia)
                                                .First()
                                        };
                                    })
                                    .ToList()
                            };
                        })
                        .ToList(),
                };
            })
            .FirstOrDefault();

        if (os is null)
            return os;

        os.OrdenesASeleccionar = os.OrdenesASeleccionar
            .OrderByDescending(op => op.Prioridad)
            .ToList();

        return os;
    }
    public void ConfirmarEmpaquetado(long numeroOS)
    {
        // 1. Cambiar de estado las OP Empaquetadas.
        var os = OrdenDeSeleccionAlmacen.OrdenesSeleccion
            .Where(os => os.NumeroOS == numeroOS)
            .Select(os =>
            {
                os.Estado = OSEstadoEnum.Cumplida;
                return os;
            })
            .First();

        var ops = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => os.OrdenesDePreparacion.Contains(op.NumeroOP))
            .Select(op =>
            {
                op.Estado = OPEstadoEnum.Preparada;
                return op;
            })
            .ToList();
        // 2. Crear la OE.
        var ordenDeEntrega = new OrdenDeEntregaEnt
        {
            Estado = OEEstadoEnum.Pendiente
        };
        ordenDeEntrega.OrdenesDePreparacion.AddRange(os.OrdenesDePreparacion);

        OrdenDeEntregaAlmacen.Agregar(ordenDeEntrega);
        OrdenDeSeleccionAlmacen.Actualizar(os);
        OrdenDePreparacionAlmacen.ActualizarEnLote(ops);

        OrdenDeEntregaAlmacen.Grabar();
        OrdenDeSeleccionAlmacen.Grabar();
        OrdenDePreparacionAlmacen.Grabar();
    }
}