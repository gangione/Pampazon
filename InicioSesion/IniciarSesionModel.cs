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
                Usuario = "atencionalcliente",
                Contrasenia = "atiendob0lud0s",
                Rol = Rol.AtencionAlCliente
            },
            new()
            {
                Numero = 3,
                Usuario = "jefedepreparacion",
                Contrasenia = "ordeno",
                Rol = Rol.JefeDePreparacion
            },
            new()
            {
                Numero = 4,
                Usuario = "estibador",
                Contrasenia = "estibo",
                Rol = Rol.Estibador
            },
            new()
            {
                Numero = 5,
                Usuario = "empaquetador",
                Contrasenia = "empaqueto",
                Rol = Rol.Preparador
            },
            new()
            {
                Numero = 6,
                Usuario = "despachante",
                Contrasenia = "despacho",
                Rol = Rol.Despachante
            },
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
