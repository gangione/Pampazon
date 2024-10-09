namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;

public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime FechaADespachar { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
}