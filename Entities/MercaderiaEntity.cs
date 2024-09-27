namespace Pampazon.Entities;

public class MercaderiaEntity
{
    public long Id { get; set; }
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public decimal Cantidad { get; set; }
    public string UnidadDeMedida { get; set; }
}
