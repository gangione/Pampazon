using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;

public class OrdenDeEntrega
{
    public long NroOrdenDePreparacion { get; set; }
    public string Cliente { get; set; }
    public string SKU { get; set; }
    public int Cantidad { get; set; }
    public long DNITransportista { get; set; }
    public OrdenDeEntregaEstado Estado { get; set; }
}