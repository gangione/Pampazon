using Pampazon.InicioSesion.Enums;

namespace Pampazon.InicioSesion.Dtos;

public class Usuario
{
    public long Numero { get; set; }
    public string Nombre { get; set; }
    public string Contrasenia { get; set; }
    public Rol Rol { get; set; }

    public override bool Equals(object obj)
    {
        Usuario usuario = obj as Usuario;
        return usuario.Numero == Numero;
    }
}