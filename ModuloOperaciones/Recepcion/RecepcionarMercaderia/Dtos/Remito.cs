namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;

public class Remito
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public Transportista Transportista { get; set; }
    public string Emisor { get; set; }
    public string Receptor { get; set; }
    public string? Observaciones { get; set; }
}
