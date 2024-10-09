using Pampazon.InicioSesion.Dtos;
using Pampazon.InicioSesion.Enums;
using Pampazon.ModuloOperaciones.Recepcion.RecepcionMercaderia;

namespace Pampazon.ModuloMenuInicio;

public class MenuInicioModel
{
    private Dictionary<string?, Form> _opciones;

    public MenuInicioModel()
    {
        _opciones = new()
        {
            //{ Enum.GetName(Rol.Administrador), new AbmUsuariosForm() },

        };

        // Ejemplo de Recepción de Mercadería (Poceso IN).
        /* 
         * A medida que va escalando el sistema en funcionalidades debería pensarse en 
         * pasar a una solución con Menús por Área/Sector
         */
        _opciones.Add("RecepcionarMercaderia", new RecepcionarMercaderiaForm());
    }
    public void MostrarMenuDeUsuario(Usuario usuario)
    {
        switch (usuario.Rol)
        {
            case Rol.Administrador:
                break;
            case Rol.AtencionAlCliente:
                _opciones[Enum.GetName(Rol.AtencionAlCliente)].ShowDialog();
                break;
            case Rol.JefeDePreparacion:
                _opciones[Enum.GetName(Rol.JefeDePreparacion)].ShowDialog();
                break;
            case Rol.Preparador:
                _opciones[Enum.GetName(Rol.Preparador)].ShowDialog();
                break;
            case Rol.Estibador:
                _opciones[Enum.GetName(Rol.Estibador)].ShowDialog();
                break;
            case Rol.Despachante:
                _opciones[Enum.GetName(Rol.Despachante)].ShowDialog();
                break;
            default:
                break;
        }
    }
    public Dictionary<string?, Form> ObtenerOpciones()
    {
        return _opciones;
    }
}