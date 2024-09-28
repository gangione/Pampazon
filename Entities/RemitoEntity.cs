namespace Pampazon.Entities;

public class RemitoEntity
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public TransportistaEntity Transportista { get; set; }
    public DomicilioEntity? DomicilioEntrega { get; set; }
    public string Emisor { get; set; }
    public string Receptor { get; set; }
    public string? Observaciones { get; set; }
}
