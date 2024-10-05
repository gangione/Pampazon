using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;

public class OrdenDeSeleccion
{
    public long Numero { get; set; }

    public Prioridad Prioridad { get; set; }
}