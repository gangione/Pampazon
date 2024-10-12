namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;

public class OrdenDeSeleccion
{
    public long Numero { get; set; }

    public List<OrdenDePreparacion> OrdenesASeleccionar { get; set; }
}