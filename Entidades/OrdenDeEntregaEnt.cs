namespace Pampazon.Entidades;
public class OrdenDeEntregaEnt
{
    public int NumeroOE { get; set; }
    public List<int> OrdenesDePreparacion { get; } = [];
    public OEEstadoEnum Estado { get; set; }
}
