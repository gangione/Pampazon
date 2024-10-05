using Pampazon.Entities.Enums;

namespace Pampazon.Entities;

public class MercaderiaEntity
{
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public UnidadDeMedida UnidadDeMedida { get; set; }
}