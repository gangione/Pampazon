using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
public class OrdenDeSeleccion
{
    public long Numero { get; set; }
    public Prioridad Prioridad { get; set; }
    public DateTime FechaADespachar { get; set; }
    public OrdenDeSeleccionEstado Estado { get; set; }
    public List<OrdenDePreparacion> OrdenesASeleccionar { get; set; }
}
