
using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Dtos;

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