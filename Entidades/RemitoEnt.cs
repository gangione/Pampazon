namespace Pampazon.Entidades;
public class RemitoEnt
{
    public int NumeroRemito { get; set; }
    public int NumeroTransportista { get; set; }
    public int NumeroCliente { get; set; }
    public List<int> OrdenesDePreparacion { get; } = new();
}
