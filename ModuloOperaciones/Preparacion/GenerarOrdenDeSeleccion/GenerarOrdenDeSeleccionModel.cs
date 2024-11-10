using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Utilidades;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;
public class GenerarOrdenDeSeleccionModel
{
    public GenerarOrdenDeSeleccionModel()
    {
    }
    public List<Cliente> ObtenerClientes()
    {
        return ClienteAlmacen.Clientes
            .Select(cliente =>
            {
                return new Cliente()
                {
                    Numero = cliente.NumeroCliente,
                    Nombre = cliente.RazonSocial,
                    Prioridad = Enum.Parse<Prioridad>(cliente.Prioridad.ToString()),
                };
            })
            .ToList();
    }
    public List<OrdenDePreparacion> ObtenerOrdenesDePreparacionPendientes()
    {
        var ordenesPendientes = new List<OrdenDePreparacion>();
        foreach (var op in OrdenDePreparacionAlmacen.OrdenesPreparacion)
        {
            if (Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString()) == OrdenDePreparacionEstado.Pendiente)
            {
                ordenesPendientes.Add(new OrdenDePreparacion()
                {
                    Numero = op.NumeroOP,
                    Cliente = ClienteAlmacen.Clientes
                        .Select(c =>
                        {
                            return new Cliente()
                            {
                                Numero = c.NumeroCliente,
                                Nombre = c.RazonSocial,
                                Prioridad = Enum.Parse<Prioridad>(c.Prioridad.ToString())
                            };
                        })
                        .Where(c => c.Numero == op.NumeroCliente)
                        .First(),
                    FechaADespachar = op.FechaADespachar,
                    MercaderiasAPreparar = op.Detalle
                        .Select(detalle =>
                        {
                            return new Mercaderia()
                            {
                                SKU = detalle.SKU,
                                Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                    .Where(m => m.SKU == detalle.SKU)
                                    .Select(m => { return m.TipoDeMercaderia; })
                                    .First(),
                                Cantidad = detalle.Cantidad,
                            };
                        })
                        .ToList(),
                    Estado = Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString()),
                    Prioridad = Enum.Parse<Prioridad>(op.Prioridad.ToString())
                });
            };
        }
        return ordenesPendientes;
    }
    public List<OrdenDePreparacion> ObtenerOrdenesPendientesPorFiltros(long numeroCliente, Prioridad? prioridad)
    {
        if (numeroCliente > 0 && prioridad is null)
            return OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.NumeroCliente == numeroCliente &&
                    op.Estado == OPEstadoEnum.Pendiente)
                .Select(op =>
                {
                    return new OrdenDePreparacion()
                    {
                        Numero = op.NumeroOP,
                        Cliente = ClienteAlmacen.Clientes
                            .Select(c =>
                            {
                                return new Cliente()
                                {
                                    Numero = c.NumeroCliente,
                                    Nombre = c.RazonSocial,
                                    Prioridad = Enum.Parse<Prioridad>(c.Prioridad.ToString())
                                };
                            })
                            .Where(c => c.Numero == op.NumeroCliente)
                            .First(),
                        FechaADespachar = op.FechaADespachar,
                        MercaderiasAPreparar = op.Detalle
                            .Select(detalle =>
                            {
                                return new Mercaderia()
                                {
                                    SKU = detalle.SKU,
                                    Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                        .Where(m => m.SKU == detalle.SKU)
                                        .Select(m => { return m.TipoDeMercaderia; })
                                        .First(),
                                    Cantidad = detalle.Cantidad,
                                };
                            })
                            .ToList(),
                        Estado = Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString()),
                        Prioridad = Enum.Parse<Prioridad>(op.Prioridad.ToString())
                    };
                })
                .ToList();
        else if (numeroCliente == 0 && prioridad is not null)
            return OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Select(op =>
                {
                    return new OrdenDePreparacion()
                    {
                        Numero = op.NumeroOP,
                        Cliente = ClienteAlmacen.Clientes
                            .Select(c =>
                            {
                                return new Cliente()
                                {
                                    Numero = c.NumeroCliente,
                                    Nombre = c.RazonSocial,
                                    Prioridad = Enum.Parse<Prioridad>(c.Prioridad.ToString())
                                };
                            })
                            .Where(c => c.Numero == op.NumeroCliente)
                            .First(),
                        FechaADespachar = op.FechaADespachar,
                        MercaderiasAPreparar = op.Detalle
                            .Select(detalle =>
                            {
                                return new Mercaderia()
                                {
                                    SKU = detalle.SKU,
                                    Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                        .Where(m => m.SKU == detalle.SKU)
                                        .Select(m => { return m.TipoDeMercaderia; })
                                        .First(),
                                    Cantidad = detalle.Cantidad,
                                };
                            })
                            .ToList(),
                        Estado = Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString()),
                        Prioridad = Enum.Parse<Prioridad>(op.Prioridad.ToString())
                    };
                })
                .Where(op => (op.Cliente.Prioridad == prioridad || op.Prioridad == prioridad) &&
                    op.Estado == OrdenDePreparacionEstado.Pendiente)
                .ToList();
        else return OrdenDePreparacionAlmacen.OrdenesPreparacion
                .Select(op =>
                {
                    return new OrdenDePreparacion()
                    {
                        Numero = op.NumeroOP,
                        Cliente = ClienteAlmacen.Clientes
                            .Select(c =>
                            {
                                return new Cliente()
                                {
                                    Numero = c.NumeroCliente,
                                    Nombre = c.RazonSocial,
                                    Prioridad = Enum.Parse<Prioridad>(c.Prioridad.ToString())
                                };
                            })
                            .Where(c => c.Numero == op.NumeroCliente)
                            .First(),
                        FechaADespachar = op.FechaADespachar,
                        MercaderiasAPreparar = op.Detalle
                            .Select(detalle =>
                            {
                                return new Mercaderia()
                                {
                                    SKU = detalle.SKU,
                                    Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                        .Where(m => m.SKU == detalle.SKU)
                                        .Select(m => { return m.TipoDeMercaderia; })
                                        .First(),
                                    Cantidad = detalle.Cantidad,
                                };
                            })
                            .ToList(),
                        Estado = Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString())
                    };
                })
                .Where(op =>
                    op.Numero == numeroCliente &&
                    (op.Cliente.Prioridad == prioridad || op.Prioridad == prioridad) &&
                    op.Estado == OrdenDePreparacionEstado.Pendiente
                )
                .ToList();
    }
    public OrdenDePreparacion ObtenerOrdenDePreparacionPorNumero(long nroOrden)
    {
        return OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => op.NumeroOP == nroOrden)
            .Select(op =>
            {
                return new OrdenDePreparacion()
                {
                    Numero = op.NumeroOP,
                    Cliente = ClienteAlmacen.Clientes
                        .Select(c =>
                        {
                            return new Cliente()
                            {
                                Numero = c.NumeroCliente,
                                Nombre = c.RazonSocial,
                                Prioridad = Enum.Parse<Prioridad>(c.Prioridad.ToString())
                            };
                        })
                        .Where(c => c.Numero == op.NumeroCliente)
                        .First(),
                    FechaADespachar = op.FechaADespachar,
                    MercaderiasAPreparar = op.Detalle
                        .Select(detalle =>
                        {
                            return new Mercaderia()
                            {
                                SKU = detalle.SKU,
                                Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                                    .Where(m => m.SKU == detalle.SKU)
                                    .Select(m => { return m.TipoDeMercaderia; })
                                    .First(),
                                Cantidad = detalle.Cantidad,
                            };
                        })
                        .ToList(),
                    Estado = Enum.Parse<OrdenDePreparacionEstado>(op.Estado.ToString()),
                    Prioridad = Enum.Parse<Prioridad>(op.Prioridad.ToString())
                };
            })
            .First();
    }
    public List<Mercaderia>? ObtenerMercaderiasAPrepararPorOrden(long nroOrden)
    {
        var mercaderiasAPreparar = new List<Mercaderia>();

        var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
            .Where(op => op.NumeroOP == nroOrden)
            .Select(op => op)
            .First();

        op.Detalle.ForEach(d =>
        {
            mercaderiasAPreparar.Add(new Mercaderia()
            {
                SKU = d.SKU,
                Descripcion = MercaderiaEnStockAlmacen.Mercaderias
                    .Where(m => m.SKU == d.SKU)
                    .Select(m => { return m.TipoDeMercaderia; })
                    .First(),
                Cantidad = d.Cantidad
            });
        });

        return mercaderiasAPreparar;
    }
    public Resultado<OrdenDeSeleccionEnt> GenerarOrdenDeSeleccion(OrdenDeSeleccion orden)
    {
        var ordenDeSeleccion = new OrdenDeSeleccionEnt();
        // Validar las reglas de negocio.
        // 1. Recorrer las Ordenes de Preparación para cambiar el estado a "EnSeleccion"
        var ordenesDePreparacion = new List<OrdenDePreparacionEnt>();
        foreach (var ordenASeleccionar in orden.OrdenesASeleccionar.DistinctBy(op => op.Numero))
        {
            var op = OrdenDePreparacionAlmacen.OrdenesPreparacion
                .First(op => op.NumeroOP == ordenASeleccionar.Numero);

            op.Estado = OPEstadoEnum.EnSeleccion;
            ordenesDePreparacion.Add(op);
        }

        // 2. Crear y Agregar la nueva Orden de Selección.
        ordenDeSeleccion.Estado = OSEstadoEnum.Pendiente;
        ordenDeSeleccion.OrdenesDePreparacion
            .AddRange(ordenesDePreparacion.Select(op => { return op.NumeroOP; }));

        OrdenDePreparacionAlmacen.ActualizarEnLote(ordenesDePreparacion);
        ordenDeSeleccion = OrdenDeSeleccionAlmacen.Agregar(ordenDeSeleccion);

        return new Resultado<OrdenDeSeleccionEnt>(
            true,
            $"La OS Número {ordenDeSeleccion.NumeroOS} se generó correctamente.",
            ordenDeSeleccion
        );
    }
}