using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public OrdenDePreparacionEstado Estado { get; set; }
}