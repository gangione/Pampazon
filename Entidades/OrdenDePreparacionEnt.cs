namespace Pampazon.Entidades;
public class OrdenDePreparacionEnt
{
    public DepositoEnum Deposito { get; set; }
    public int NumeroOP { get; set; }
    public int NumeroCliente { get; set; }
    public int NumeroTransportista { get; set; }
    public List<OrdenDePreparacionDetalle> Detalle { get; set; } = [];
    public DateTime FechaADespachar { get; set; }
    public PrioridadEnum Prioridad { get; set; }
    public OPEstadoEnum Estado { get; set; }
}
