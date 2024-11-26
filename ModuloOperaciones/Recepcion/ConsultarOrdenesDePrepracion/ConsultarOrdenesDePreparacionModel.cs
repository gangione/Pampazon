using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion;
public class ConsultarOrdenesDePreparacionModel
{
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

    public List<OrdenDePreparacion> ObtenerOrdenesDePreparacionPorFiltros(Deposito? deposito, long? numeroCliente, Prioridad? prioridad)
    {
        var ordenes = OrdenDePreparacionAlmacen.OrdenesPreparacion;

        if (deposito is not null)
            ordenes = ordenes
                .Where(op => op.Deposito == Enum.Parse<DepositoEnum>(deposito.ToString()))
                .ToList();

        if (numeroCliente is not null && numeroCliente > 0)
            ordenes = ordenes.Where(op => op.NumeroCliente == numeroCliente).ToList();

        if (prioridad is not null)
            ordenes = ordenes
                .Where(op => op.Prioridad == Enum.Parse<PrioridadEnum>(prioridad.ToString()))
                .ToList();

        return ordenes.AsEnumerable().Select(op =>
        {
            return new OrdenDePreparacion()
            {
                Numero = op.NumeroOP,
                Deposito = Enum.Parse<Deposito>(op.Deposito.ToString()),
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
    }

    public List<Mercaderia> ObtenerMercaderiasAPrepararPorOrden(long nroOrden)
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
}