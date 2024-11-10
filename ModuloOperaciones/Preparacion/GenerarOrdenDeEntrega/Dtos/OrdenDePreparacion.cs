using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public OPEstado Estado { get; set; }
    public Prioridad Prioridad { get; set; }
    public DateTime FechaADespachar { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
}