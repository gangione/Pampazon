namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Dtos;
public class Ubicacion
{
    public string Sector { get; set; }
    public string Posicion { get; set; }
    public string Fila { get; set; }
    public string Cantidad { get; set; }
    public override string ToString()
    {
        return $"{Sector} - {Posicion} - {Fila}";
    }
}