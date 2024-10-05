using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloMenuInicio;
using Pampazon.ModuloUsuarios.AbmUsuarios;

namespace Pampazon.MenuInicio
{
    public partial class MenuInicioForm : Form
    {
        private readonly UsuarioEntity _usuario;
        private readonly MenuInicioModel _modelo;
        private Dictionary<string, Form> _opciones;
        public MenuInicioForm(UsuarioEntity usuario)
        {
            _usuario = usuario;
            _modelo = new MenuInicioModel();
            _opciones = _modelo.ObtenerOpciones();
            InitializeComponent();
        }
        private void MenuInicioForm_Load(object sender, EventArgs e)
        {
            _opciones.Add("Usuarios", new AbmUsuariosForm());
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