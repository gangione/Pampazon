using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Utilidades;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
public class SeleccionarMercaderiasModel
{
    public SeleccionarMercaderiasModel()
    {
    }

    public List<OrdenDeSeleccion> ObtenerOrdenesDeSeleccionPendiente()
    {
        return OrdenDeSeleccionAlmacen.OrdenesSeleccion
            .Where(os => os.Estado == OSEstadoEnum.Pendiente)
            .Select(os =>
            {
                return new OrdenDeSeleccion()
                {
                    Numero = os.NumeroOS,
                    OrdenesDePreparacion = os.OrdenesDePreparacion
                };
            })
            .ToList();
    }

    public List<Mercaderia> ObtenerMercaderiasPorNumeroDeSeleccion(long numeroOS)
    {
        var ordenDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesSeleccion
            .First(os => os.NumeroOS == numeroOS);

        // 1. Se ordenan las OP de la Selección por Prioridad de la OP,
        // Prioridad del Cliente y Fecha a Despachar.
        var ordenesDePreparacion = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => ordenDeSeleccion.OrdenesDePreparacion.Contains(op.NumeroOP))
            .OrderByDescending(op => op.Prioridad)
            .ThenByDescending(op => ClienteAlmacen.Clientes
                .First(c => c.NumeroCliente == op.NumeroCliente).Prioridad)
            .ThenBy(op => op.FechaADespachar)
            .Select(op => op)
            .ToList();

        List<Mercaderia> mercaderias = new();
        foreach (var op in ordenesDePreparacion)
        {
            // 2. Recorro el detalle de la OP de la OS
            foreach (var detalle in op.Detalle)
            {
                // 2.1. Busco las ubicaciones de las mercaderías en el stock
                var ubicaciones = MercaderiaEnStockAlmacen.Mercaderias
                    .First(m => m.SKU == detalle.SKU)
                    .Ubicaciones;

                // 2.2. Ordeno y agrupo las ubicaciones por Sector
                var ubicacionesPorSector = ubicaciones
                    .GroupBy(m => m.Sector)
                    .SelectMany(grupo => grupo)
                    .ToList();

                // 2.3. Recorro las ubicaciones para recolectar la cantidad solicitada
                var cantidadSolicitada = detalle.Cantidad;
                var cantidadTotalSeleccionada = 0;
                foreach (var ubicacion in ubicacionesPorSector)
                {
                    var cantidadFaltante = cantidadSolicitada - cantidadTotalSeleccionada;
                    // 2.3.1. Validar si aún falta hacer picking.
                    if (cantidadFaltante > 0)
                    {
                        // Cantidad disponible en esta ubicación
                        var cantidadDisponible = ubicacion.Cantidad;
                        var mercaderiaAPickear = new Mercaderia()
                        {
                            Ubicacion = new Ubicacion()
                            {
                                Cantidad = 0,
                                Sector = ubicacion.Sector,
                                Posicion = ubicacion.Posicion,
                                Fila = ubicacion.Fila,
                            },
                            SKU = detalle.SKU,
                            Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                    .Where(m => m.SKU == detalle.SKU)
                                    .Select(m => m.TipoDeMercaderia)
                                    .First(),
                        };

                        // 2.3.1.1 Si la cantidad seleccionada + disponible es menor  o igual que la faltante,
                        // se agrega toda la cantidad de la ubicación.
                        if (cantidadDisponible <= cantidadFaltante)
                        {
                            cantidadTotalSeleccionada += cantidadDisponible;
                            mercaderiaAPickear.Ubicacion.Cantidad = cantidadDisponible;
                        }
                        // 2.3.1.2 Si la cantidad disponible excede lo que falta para alcanzar la cantidad solicitada,
                        // solo se agrega la cantidad necesaria para completar la orden.
                        else
                        {
                            cantidadTotalSeleccionada += cantidadFaltante;
                            mercaderiaAPickear.Ubicacion.Cantidad = cantidadFaltante;
                        }
                        mercaderias.Add(mercaderiaAPickear);
                    }
                    else break;
                }
            }
        }

        return mercaderias
            .GroupBy(m => m.Ubicacion.ToString())
            .SelectMany(grupo => grupo)
            .ToList();
    }

    public Resultado<bool> ConfirmarSeleccion(long nroOrdenSeleccion)
    {
        // 1. Obtengo las mercaderías seleccionadas.
        var mercaderias = ObtenerMercaderiasPorNumeroDeSeleccion(nroOrdenSeleccion);

        // 2. Actualizo las mercaderías en stock y cambio de estado las órdenes
        var stockActualizado = new List<MercaderiaEnStockEnt>();
        foreach (var mercaderia in mercaderias)
        {
            var mercaderiaEnStock = MercaderiaEnStockAlmacen.Mercaderias
                .Where(m => m.SKU == mercaderia.SKU)
                .First();

            var ubicacionEnStock = mercaderiaEnStock.Ubicaciones
                .First(u => u.Sector == mercaderia.Ubicacion.Sector &&
                         u.Posicion == mercaderia.Ubicacion.Posicion &&
                         u.Fila == mercaderia.Ubicacion.Fila);

            ubicacionEnStock.Cantidad -= mercaderia.Ubicacion.Cantidad;
            if (ubicacionEnStock.Cantidad <= 0)
            {
                mercaderiaEnStock.Ubicaciones.Remove(ubicacionEnStock);
            }

            stockActualizado.Add(mercaderiaEnStock);
        }

        // 3. Cambiar el estado de la OS y las OP.
        var ordenDeSeleccion = OrdenDeSeleccionAlmacen.OrdenesSeleccion
            .Where(os => os.NumeroOS == nroOrdenSeleccion)
            .Select(os =>
            {
                os.Estado = OSEstadoEnum.Cumplida;
                return os;
            })
            .First();

        var ordenesDePrepracion = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => ordenDeSeleccion.OrdenesDePreparacion.Contains(op.NumeroOP))
            .Select(op =>
            {
                op.Estado = OPEstadoEnum.EnPreparacion;
                return op;
            })
            .ToList();

        OrdenDeSeleccionAlmacen.Actualizar(ordenDeSeleccion);
        MercaderiaEnStockAlmacen.ActualizarEnLote(stockActualizado);
        OrdenDePreparacionAlmacen.ActualizarEnLote(ordenesDePrepracion);

        return new Resultado<bool>(
            true,
            "Seleccion Confirmada.\n\n" +
            "Se ha realizado la baja del Stock seleccionado.",
            true
        );
    }
}