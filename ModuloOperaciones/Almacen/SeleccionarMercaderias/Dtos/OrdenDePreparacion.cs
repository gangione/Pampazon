using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;

public class OrdenDePreparacion
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime FechaDeDespacho { get; set; }
    public OrdenDePreparacionEstado Estado { get; set; }
    public List<Mercaderia>? MercaderiasAPreparar { get; set; }
}