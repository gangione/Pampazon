namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
public class Transportista
{
    public long DNI { get; set; }
    public string NombreYApellido { get; set; }

    public override string ToString()
    {
        return $"{DNI} - {NombreYApellido}";
    }
}