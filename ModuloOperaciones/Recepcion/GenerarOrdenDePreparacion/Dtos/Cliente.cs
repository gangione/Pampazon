using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;

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