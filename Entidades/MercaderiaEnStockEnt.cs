namespace Pampazon.Entidades;
public class MercaderiaEnStockEnt
{
    public string SKU { get; set; }
    public int NumeroCliente { get; set; }
    public string TipoDeMercaderia { get; set; }
    public List<UbicacionDeEstiva> Ubicaciones { get; set; } = [];
}
