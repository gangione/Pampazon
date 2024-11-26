using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Dtos;

public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public Deposito Deposito { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime FechaADespachar { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
    public OrdenDePreparacionEstado Estado { get; set; }
    public Prioridad Prioridad { get; set; }
}