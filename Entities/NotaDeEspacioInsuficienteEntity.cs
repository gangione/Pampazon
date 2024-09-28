namespace Pampazon.Entities;

public class NotaDeEspacioInsuficienteEntity
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public ComprobanteDeRecepcionEntity ComprobanteDeRecepcion { get; set; }
    public List<MercaderiaEntity> MercaderiasRechazadas { get; set; }
    public bool Total { get; set; }
    public bool Parcial { get; set; }
    public string? Observaciones { get; set; }
}