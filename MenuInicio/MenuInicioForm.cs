using Pampazon.InicioSesion.Dtos;
using Pampazon.InicioSesion.Enums;
using Pampazon.ModuloMenuInicio;

namespace Pampazon.MenuInicio
{
    public partial class MenuInicioForm : Form
    {
        private readonly Usuario _usuario;
        private readonly MenuInicioModel _modelo;
        private Dictionary<string, Form> _opciones;
        public MenuInicioForm(Usuario usuario)
        {
            _usuario = usuario;
            _modelo = new MenuInicioModel();
            _opciones = _modelo.ObtenerOpciones();
            InitializeComponent();
        }
        private void MenuInicioForm_Load(object sender, EventArgs e)
        {
            _modelo.MostrarMenuDeUsuario(_usuario);

            //Deberías cerrar el formulario de menú si el Usuario no es Admin
            if (_usuario.Rol != Rol.Administrador)
                Dispose();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var usuariosForm = _opciones["Usuarios"];
            usuariosForm.ShowDialog();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            var clientesForm = _opciones[Enum.GetName(Rol.AtencionAlCliente)];
            clientesForm.ShowDialog();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            var recepcionarMercaderiaForm = _opciones["RecepcionarMercaderia"];
            recepcionarMercaderiaForm.ShowDialog();
        }
    }
}