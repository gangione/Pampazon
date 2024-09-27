namespace Pampazon.Entities;

public class RemitoEntidad
{
    public string Numero { get; set; }
    public DateTime FechaEmision { get; set; }
    public TransportistaEntity Transportista { get; set; }
    public DomicilioEntity DomicilioEntrega { get; set; }
    public string? Observaciones { get; set; }
}
