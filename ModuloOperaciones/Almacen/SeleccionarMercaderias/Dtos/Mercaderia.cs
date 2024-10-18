using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
public class Mercaderia
{
    public string SKU { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public Ubicacion Ubicacion { get; set; }
    public MercaderiaEstado Estado { get; set; }
    public int NroOrdenDePreparacion { get; set; }
}
