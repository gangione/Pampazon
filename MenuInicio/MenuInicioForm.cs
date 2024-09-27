using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloOperaciones.Descarga.RecepcionMercaderia;
using Pampazon.ModuloUsuarios.AbmUsuarios;

namespace Pampazon.MenuInicio
{
    public partial class MenuInicioForm : Form
    {
        private readonly UsuarioEntity _usuario;
        private Dictionary<string, Form> _opciones;
        public MenuInicioForm(UsuarioEntity usuario)
        {
            _usuario = usuario;
            _opciones = new();
            InitializeComponent();
        }
        private void MenuInicioForm_Load(object sender, EventArgs e)
        {
            _opciones.Add("Usuarios", new AbmUsuariosForm());
            _opciones.Add("Clientes", new AbmClientesForm());
            _opciones.Add("RecepcionarMercaderia", new RecepcionarMercaderiaForm());

            // Modificar al Menú de Ventas / Operaciones según rol.
            if (_usuario.Rol == Roles.GerenteVentas)
            {
                var clientesForm = _opciones["Clientes"];
                clientesForm.ShowDialog();
                Dispose();
                return;
            }

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var usuariosForm = _opciones["Usuarios"];
            usuariosForm.ShowDialog();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            var clientesForm = _opciones["Clientes"];
            clientesForm.ShowDialog();
        }

        private void buttonOperaciones_Click(object sender, EventArgs e)
        {
            var recepcionarMercaderiaForm = _opciones["RecepcionarMercaderia"];
            recepcionarMercaderiaForm.ShowDialog();
        }
    }
}