namespace Pampazon.Entities;
public class ComprobanteDeRecepcionEntity
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public long NumeroRemito { get; set; }
    public ClienteEntity? Cliente { get; set; }
    public TransportistaEntity? Transportista { get; set; }
    public List<MercaderiaEntity>? MercaderiasRecibidas { get; set; }
    public string? Observaciones { get; set; }
}
