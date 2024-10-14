namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
public class Ubicacion
{
    public int Sector { get; set; }
    public int Posicion { get; set; }
    public int Fila { get; set; }

    public Ubicacion(int sector, int posicion, int fila)
    {
        Sector = sector;
        Posicion = posicion;
        Fila = fila;
    }
    public override string ToString()
    {
        return $"{Sector}-{Posicion}-{Fila}";
    }
}
