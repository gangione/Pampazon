namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;

public class OrdenDeEntrega
{
    public long NroOrdenDePreparacion { get; set; }
    public string Cliente { get; set; }
    public string SKU { get; set; }
    public int Cantidad { get; set; }
}