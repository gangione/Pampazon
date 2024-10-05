namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;
public class NotaDeEspacioInsuficiente
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public ComprobanteDeRecepcion ComprobanteDeRecepcion { get; set; }
    public List<Mercaderia> MercaderiasRechazadas { get; set; }
    public bool Total { get; set; }
    public bool Parcial { get; set; }
    public string? Observaciones { get; set; }
}