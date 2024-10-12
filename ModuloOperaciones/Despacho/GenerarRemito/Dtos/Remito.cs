namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
public class Remito
{
    public long Numero { get; set; }
    public DateTime Fecha { get; set; }
    public Transportista Transportista { get; set; }
    public List<Mercaderia> Mercaderias { get; set; }
}