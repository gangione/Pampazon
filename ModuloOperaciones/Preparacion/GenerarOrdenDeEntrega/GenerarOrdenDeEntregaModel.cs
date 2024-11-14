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

    public OrdenDePreparacion? ObtenerSiguienteOrdenAEmpaquetar()
    {
        var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == OPEstadoEnum.EnPreparacion)
                .OrderByDescending(op => op.Prioridad)
                .Select(op => op)
                .FirstOrDefault();

        if (op is null)
            return null;

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
    }
    public void ConfirmarEmpaquetado(long numeroOP)
    {
        // 1. Cambiar de estado la OP Empaquetadas.
        var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(os => os.NumeroOP == numeroOP)
            .Select(op =>
            {
                op.Estado = OPEstadoEnum.Preparada;
                return op;
            })
            .First();

        // 2. Crear la OE.
        var ordenDeEntrega = new OrdenDeEntregaEnt
        {
            Estado = OEEstadoEnum.Pendiente,
            NumeroOP = op.NumeroOP
        };

        OrdenDeEntregaAlmacen.Agregar(ordenDeEntrega);
        OrdenDePreparacionAlmacen.Actualizar(op);

        OrdenDeEntregaAlmacen.Grabar();
        OrdenDePreparacionAlmacen.Grabar();
    }
}