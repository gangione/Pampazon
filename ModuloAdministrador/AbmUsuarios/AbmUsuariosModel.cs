using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloUsuarios.AbmUsuarios;

public class AbmUsuariosModel
{
    private readonly List<UsuarioEntity> _usuarios;
    public AbmUsuariosModel()
    {
        _usuarios = new()
        {
            new()
            {
                Numero = 1,
                Usuario = "admin",
                Contrasenia = "admin",
                Rol = Roles.Administrador
            },
            new()
            {
                Numero = 2,
                Usuario = "ventas",
                Contrasenia = "ventas",
                Rol = Roles.GerenteVentas
            },
            new()
            {
                Numero = 3,
                Usuario = "operaciones",
                Contrasenia = "operaciones",
                Rol = Roles.GerenteOperaciones
            }
        };
    }

    public List<UsuarioEntity> ObtenerPorFiltro(string filtro)
    {
        return _usuarios.FindAll(usuario =>
            usuario.Numero
                .ToString().Contains(filtro, StringComparison.CurrentCultureIgnoreCase) ||
            usuario.Usuario
                .ToString().Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
            );
    }

    public List<UsuarioEntity> ObtenerTodos()
    {
        return _usuarios;
    }

    public Resultado<UsuarioEntity> Guardar(UsuarioEntity usuario)
    {
        if (_usuarios.Contains(usuario))
            return new Resultado<UsuarioEntity>(false, "Ya existe un usuario con ese Numero.", usuario);

        foreach (var c in _usuarios)
        {
            if (usuario.Usuario == c.Usuario)
                return new Resultado<UsuarioEntity>(
                    false,
                    "Ya existe un usuario con ese nombre.",
                    usuario
                );
        }

        _usuarios.Add(usuario);

        return new Resultado<UsuarioEntity>(true, "El usuario se guardó correctamente.", usuario);
    }

    public Resultado<UsuarioEntity> Actualizar(UsuarioEntity usuario)
    {
        if (!_usuarios.Contains(usuario))
            return new Resultado<UsuarioEntity>(false, "No existe un usuario con ese Numero", usuario);

        int indice = _usuarios.IndexOf(usuario);

        _usuarios[indice] = usuario;

        return new Resultado<UsuarioEntity>(true, "El usuario se actualizó correctamente.", usuario);
    }

    public Resultado<UsuarioEntity> Eliminar(UsuarioEntity usuario)
    {
        if (!_usuarios.Contains(usuario))
            return new Resultado<UsuarioEntity>(false, "El usuario no existe.", usuario);

        _usuarios.Remove(usuario);

        return new Resultado<UsuarioEntity>(true, "El usuario se eliminó correctamente.", usuario);
    }
}