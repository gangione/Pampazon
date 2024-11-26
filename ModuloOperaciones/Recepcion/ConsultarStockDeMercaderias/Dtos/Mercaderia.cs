using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Dtos;

public class Mercaderia
{
    public string SKU { get; set; }
    public Deposito Deposito { get; set; }
    public int CantidadTotal { get; set; }
    public string Descripcion { get; set; }
    public string Cliente { get; set; }
}