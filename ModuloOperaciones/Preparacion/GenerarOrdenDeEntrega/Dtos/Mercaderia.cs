using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
public class Mercaderia
{
    public string SKU { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public MercaderiaEstado Estado { get; set; }
}