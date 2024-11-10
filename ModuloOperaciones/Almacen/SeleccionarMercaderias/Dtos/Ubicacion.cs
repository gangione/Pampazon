namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
public class Ubicacion
{
    public int Cantidad { get; set; }
    public int Sector { get; set; }
    public int Posicion { get; set; }
    public int Fila { get; set; }
    public override string ToString()
    {
        return $"{Sector}-{Posicion}-{Fila}";
    }
}
