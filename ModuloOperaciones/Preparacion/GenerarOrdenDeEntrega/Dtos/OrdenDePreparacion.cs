using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
    public OrdenDePreparacionEstado Estado { get; set; }
}