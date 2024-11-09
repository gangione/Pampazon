namespace Pampazon.Entidades;
public class OrdenDeSeleccionEnt
{
    public int NumeroOS { get; set; }
    public List<int> OrdenesDePreparacion { get; } = [];
    public OEstadoEnum Estado { get; set; }
    public List<int> Detalle { get; } = [];
}