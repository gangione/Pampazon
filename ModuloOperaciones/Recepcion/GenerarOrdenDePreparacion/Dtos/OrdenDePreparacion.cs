using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;

public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime FechaDeDespacho { get; set; }
    public Cliente Cliente { get; set; }
    public Transportista Transportista { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
    public OrdenDePreparacionEstado Estado { get; set; }
}