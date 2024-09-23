using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloInicioSesion;

public class IniciarSesionModel
{
    private readonly List<UsuarioEntity> _usuarios;

    public IniciarSesionModel()
    {
        _usuarios = new()
        {
            new()
            {
                Numero = 1,
                Usuario = "admin",
                Contrasenia = "admin",
                Rol = Rol.Administrador
            },
            new()
            {
                Numero = 2,
                Usuario = "ventas",
                Contrasenia = "ventas",
                Rol = Rol.GerenteVentas
            },
            new()
            {
                Numero = 3,
                Usuario = "operaciones",
                Contrasenia = "operaciones",
                Rol = Rol.GerenteOperaciones
            }
        };
    }

    public Resultado<UsuarioEntity?> ValidarCredenciales(string usuario, string contrasenia)
    {
        UsuarioEntity? user = _usuarios.FirstOrDefault(u => u.Usuario == usuario);
        if (user is null)
            return new Resultado<UsuarioEntity?>(false, "Usuario no encontrado.", user);

        if (user.Contrasenia != contrasenia)
            return new Resultado<UsuarioEntity?>(false, "Contraseña incorrecta.", user);

        return new Resultado<UsuarioEntity?>(true, "Credenciales correctas.", user);
    }
}
