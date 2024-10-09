using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
using Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeEntrega;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;

namespace Pampazon.MenuInicio
{
    public partial class MenuInicioForm : Form
    {
        public MenuInicioForm()
        {
            InitializeComponent();
        }
        private void MenuInicioForm_Load(object sender, EventArgs e)
        {
            //{ Enum.GetName(Rol.AtencionAlCliente), new GenerarOrdenDePreparacionForm() },
            //{ Enum.GetName(Rol.JefeDePreparacion), new GenerarOrdenDeSeleccionForm() },
            //{ Enum.GetName(Rol.Estibador), new SeleccionarMercaderiasForm() },
            //{ Enum.GetName(Rol.Preparador), new GenerarOrdenDeEntregaForm() },
            //{ Enum.GetName(Rol.Despachante), new GenerarRemitoForm() },_modelo.MostrarMenuDeUsuario(_usuario);
        }

        private void buttonPedirMercaderiasDeCliente_Click(object sender, EventArgs e)
        {
            var generarOrdenDePreparacion = new GenerarOrdenDePreparacionForm();
            generarOrdenDePreparacion.ShowDialog();
        }

        private void buttonOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            var generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.ShowDialog();
        }

        private void buttonSeleccionMercaderias_Click(object sender, EventArgs e)
        {
            var seleccionMercaderias = new SeleccionarMercaderiasForm();
            seleccionMercaderias.ShowDialog();
        }

        private void buttonEmpaquetar_Click(object sender, EventArgs e)
        {
            var ordenDeEntrega = new GenerarOrdenDeEntregaForm();
            ordenDeEntrega.ShowDialog();
        }

        private void buttonDespachar_Click(object sender, EventArgs e)
        {
            var despachar = new GenerarRemitoForm();
            despachar.ShowDialog();
        }
    }
}