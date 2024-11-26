using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias;
public class ConsultarStockDeMercaderiasModel
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
                };
            })
            .ToList();
    }

    public List<Mercaderia> ObtenerMercaderiasEnStockPorFiltros(Deposito? deposito, string? nombreCliente, string? sku)
    {
        var mercaderias = MercaderiaEnStockAlmacen.Mercaderias;

        if (deposito is not null)
            mercaderias = mercaderias
                .Where(op => op.Deposito == Enum.Parse<DepositoEnum>(deposito.ToString()))
                .ToList();

        Cliente? cliente = ClienteAlmacen.Clientes
                    .Where(c => c.RazonSocial.ToUpper() == nombreCliente?.ToUpper())
                    .Select(c =>
                    {
                        return new Cliente()
                        {
                            Numero = c.NumeroCliente,
                            Nombre = c.RazonSocial
                        };
                    })
                    .FirstOrDefault();

        if (cliente is not null)
            mercaderias = mercaderias
                .Where(op => op.NumeroCliente == cliente.Numero)
                .ToList();

        if (sku is not null)
            mercaderias = mercaderias
                .Where(m => m.SKU.ToUpper().Contains(sku.ToUpper()))
                .ToList();

        return mercaderias
            .Select(m =>
            {
                return new Mercaderia()
                {
                    SKU = m.SKU,
                    Deposito = Enum.Parse<Deposito>(m.Deposito.ToString()),
                    CantidadTotal = MercaderiaEnStockAlmacen.Mercaderias
                        .Where(stock => stock.SKU == m.SKU && m.Deposito == stock.Deposito)
                        .Sum(stock => stock.Ubicaciones.Sum(u => u.Cantidad)),
                    Descripcion = m.TipoDeMercaderia,
                    Cliente = ClienteAlmacen.Clientes
                        .Where(c => c.NumeroCliente == m.NumeroCliente)
                        .First()
                        .RazonSocial,
                };
            })
            .ToList();
    }

    public List<Ubicacion> ObtenerUbicacionesPorDepositoYSKU(Deposito deposito, string sku)
    {
        var mercaderias = MercaderiaEnStockAlmacen.Mercaderias
                .Where(op => op.Deposito == Enum.Parse<DepositoEnum>(deposito.ToString()) &&
                    op.SKU.ToUpper() == sku.ToUpper()
                )
                .ToList();

        var ubicaciones = new List<Ubicacion>();

        foreach (var m in mercaderias)
        {
            m.Ubicaciones.ForEach(u =>
            {
                ubicaciones.Add(new Ubicacion()
                {
                    Sector = u.Sector.ToString(),
                    Posicion = u.Posicion.ToString(),
                    Fila = u.Fila.ToString(),
                    Cantidad = u.Cantidad.ToString()
                });
            });
        }

        return ubicaciones;
    }
}