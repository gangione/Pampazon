namespace Pampazon.Entidades;
public class OrdenDeSeleccionEnt
{
    public int NumeroOS { get; set; }
    public DepositoEnum Deposito { get; set; }
    public OSEstadoEnum Estado { get; set; }
    public List<int> OrdenesDePreparacion { get; set; } = [];
}