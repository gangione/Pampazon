using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;

public class Cliente
{
    public long Numero { get; set; }
    public string Nombre { get; set; }
    public Prioridad Prioridad { get; set; }
    public override string ToString()
    {
        return Nombre;
    }
}