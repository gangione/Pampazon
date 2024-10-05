using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;

public class OrdenDeSeleccion
{
    public long Numero { get; set; }

    public Prioridad Prioridad { get; set; }
}