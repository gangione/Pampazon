namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
public class Transportista
{
    public string DNI { get; set; }
    public string NombreYApellido { get; set; }

    public override string ToString()
    {
        return $"{DNI} - {NombreYApellido}";
    }
}