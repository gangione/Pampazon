using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;

public class OrdenDePreparacion
{
    public Deposito Deposito { get; set; }
    public DateTime FechaDeDespacho { get; set; }
    public Cliente Cliente { get; set; }
    public Transportista Transportista { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
    public Prioridad Prioridad { get; set; }
}