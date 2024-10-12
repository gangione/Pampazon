using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;

public class OrdenDeSeleccion
{
    public long Numero { get; set; }
    public Prioridad Prioridad { get; set; }
    public DateTime FechaADespachar { get; set; }
    public OrdenDeSeleccionEstado Estado { get; set; }
    public List<Mercaderia> MercaderiasASeleccionar { get; set; }
}