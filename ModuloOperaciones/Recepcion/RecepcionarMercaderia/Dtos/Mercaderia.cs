using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;

public class Mercaderia
{
    public long NumeroCliente { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public UnidadDeMedida UnidadDeMedida { get; set; }
}