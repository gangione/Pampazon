using Pampazon.Entities.Enums;

namespace Pampazon.Entities;

public class UsuarioEntity
{
    public long Numero { get; set; }
    public string Usuario { get; set; }
    public string Contrasenia { get; set; }
    public Rol Rol { get; set; }

    public override bool Equals(object obj)
    {
        UsuarioEntity usuario = obj as UsuarioEntity;
        return usuario.Numero == Numero;
    }
}