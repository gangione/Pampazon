using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;

public class Mercaderia
{
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public UnidadDeMedida UnidadDeMedida { get; set; }
    public string Ubicacion { get; set; }
}