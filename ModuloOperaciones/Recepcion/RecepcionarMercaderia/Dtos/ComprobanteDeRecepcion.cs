namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;
public class ComprobanteDeRecepcion
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public long NumeroRemito { get; set; }
    public Cliente? Cliente { get; set; }
    public Transportista? Transportista { get; set; }
    public List<Mercaderia>? MercaderiasRecibidas { get; set; }
    public string? Observaciones { get; set; }
}