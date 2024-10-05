using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;

public class OrdenDeRecepcion
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public long NumeroComprobante { get; set; }
    public List<Mercaderia>? MercaderiasAIngresar { get; set; }
    public OrdenDeRecepcionEstado Estado { get; set; }
}
