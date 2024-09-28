using Pampazon.Entities.Enums;

namespace Pampazon.Entities;

public class OrdenDeRecepcionEntity
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public long NumeroComprobante { get; set; }
    public List<MercaderiaEntity>? MercaderiasAIngresar { get; set; }
    public OrdenDeRecepcionEstados Estado { get; set; }
}
