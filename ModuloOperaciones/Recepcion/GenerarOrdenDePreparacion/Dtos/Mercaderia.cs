using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;

public class Mercaderia
{
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public UnidadDeMedida UnidadDeMedida { get; set; }
}