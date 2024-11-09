namespace Pampazon.Entidades;
public class ClienteEnt
{
    public int NumeroCliente { get; set; }
    public string RazonSocial { get; set; }
    public string CUIT { get; set; }
    public PrioridadEnum Prioridad { get; set; }
}