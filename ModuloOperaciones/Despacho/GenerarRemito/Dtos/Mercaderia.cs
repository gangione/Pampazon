using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
public class Mercaderia
{
    public string SKU { get; set; }
    public int Cantidad { get; set; }
    public MercaderiaEstado Estado { get; set; }
    public long NroOrdenDePreparacion { get; set; }
}