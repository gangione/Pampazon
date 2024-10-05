using Pampazon.InicioSesion.Dtos;
using Pampazon.InicioSesion.Enums;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

namespace Pampazon.ModuloInicioSesion;

public class IniciarSesionModel
{
    private readonly List<Usuario> _usuarios;

    public IniciarSesionModel()
    {
        _usuarios = new()
        {
            new()
            {
                Numero = 1,
                Nombre = "admin",
                Contrasenia = "admin",
                Rol = Rol.Administrador
            },
            new()
            {
                Numero = 2,
                Nombre = "atencionalcliente",
                Contrasenia = "atiendob0lud0s",
                Rol = Rol.AtencionAlCliente
            },
            new()
            {
                Numero = 3,
                Nombre = "jefedepreparacion",
                Contrasenia = "ordeno",
                Rol = Rol.JefeDePreparacion
            },
            new()
            {
                Numero = 4,
                Nombre = "estibador",
                Contrasenia = "estibo",
                Rol = Rol.Estibador
            },
            new()
            {
                Numero = 5,
                Nombre = "empaquetador",
                Contrasenia = "empaqueto",
                Rol = Rol.Preparador
            },
            new()
            {
                Numero = 6,
                Nombre = "despachante",
                Contrasenia = "despacho",
                Rol = Rol.Despachante
            },
        };
    }

    public Resultado<Usuario?> ValidarCredenciales(string usuario, string contrasenia)
    {
        Usuario? user = _usuarios.FirstOrDefault(u => u.Nombre == usuario);
        if (user is null)
            return new Resultado<Usuario?>(false, "Usuario no encontrado.", user);

        if (user.Contrasenia != contrasenia)
            return new Resultado<Usuario?>(false, "Contraseña incorrecta.", user);

        return new Resultado<Usuario?>(true, "Credenciales correctas.", user);
    }
}
