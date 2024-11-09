namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;

public class Mercaderia
{
    public string SKU { get; set; }
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
}