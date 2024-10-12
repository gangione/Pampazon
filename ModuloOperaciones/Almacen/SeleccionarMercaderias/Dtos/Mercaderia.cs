using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
public class Mercaderia
{
    public string Descripcion { get; set; }
    public string Cantidad { get; set; }
    public string Ubicacion { get; set; }
    public MercaderiaEstado Estado { get; set; }
}
