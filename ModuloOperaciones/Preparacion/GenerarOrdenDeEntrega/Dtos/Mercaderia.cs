using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
public class Mercaderia
{
    public string Descripcion { get; set; }
    public string Cantidad { get; set; }
    public string Ubicacion { get; set; }
    public MercaderiaEstado Estado { get; set; }
}