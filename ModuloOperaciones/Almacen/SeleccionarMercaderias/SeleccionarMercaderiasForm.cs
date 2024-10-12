using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Utilidades;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
public partial class SeleccionarMercaderiasForm : Form
{
    private SeleccionarMercaderiasModel _seleccionarMercaderiasModel;
    public SeleccionarMercaderiasForm()
    {
        _seleccionarMercaderiasModel = new();
        InitializeComponent();
    }

    #region Formulario
    private void CargarFormulario()
    {
        comboBoxBuscarPorPrioridad.SelectedIndex = -1;
        comboBoxBuscarPorPrioridad.Items.Clear();
        comboBoxBuscarPorPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));

        CargarListadoOrdenesPendientes();
        listViewMercaderiasASeleccionar.Items.Clear();
    }

    #endregion

    #region Filtros

    #endregion

    #region Ordenes de Seleccion Pendientes
    private void CargarListadoOrdenesPendientes()
    {
        listViewOrdenesDeSeleccionPendientes.Items.Clear();
        var ordenesPendientes = _seleccionarMercaderiasModel
            .ObtenerOrdenesDeSeleccionPendiente();

        listViewOrdenesDeSeleccionPendientes.Items.AddRange(ObtenerListViewOrdenesDePreparacion(ordenesPendientes));
    }

    private static ListViewItem[] ObtenerListViewOrdenesDePreparacion(List<OrdenDeSeleccion> ordenes)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ordenes.Count; i++)
        {
            ListViewItem item = new(ordenes[i].Numero.ToString());
            item.SubItems.Add(ordenes[i].Prioridad.ToString());
            item.SubItems.Add(ordenes[i].FechaADespachar.ToString("dd/MM/yyyy"));
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Detalle de Orden - Mercaderias Seleccionadas

    private void CargarDetalleDeOrdenDeSeleccion()
    {
        if (listViewOrdenesDeSeleccionPendientes.SelectedItems.Count > 0)
        {
            ListViewItem osSeleccionada = listViewOrdenesDeSeleccionPendientes.SelectedItems[0];

            listViewMercaderiasASeleccionar.Items.Clear();
            var ordenDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenDeSeleccionPorNumero(long.Parse(osSeleccionada.Text));

            listViewMercaderiasASeleccionar.Items
                .AddRange(ObtenerListViewDetalleDeOrdenDeSeleccion(ordenDeSeleccion));
        }
        else
        {
            listViewMercaderiasASeleccionar.Items.Clear();
        }

    }

    private static ListViewItem[] ObtenerListViewDetalleDeOrdenDeSeleccion(OrdenDeSeleccion ordenDeSeleccion)
    {
        List<ListViewItem> viewItems = new();
        var mercaderias = ordenDeSeleccion.MercaderiasASeleccionar;
        for (int i = 0; i < mercaderias.Count; i++)
        {

            ListViewItem item = new(ordenDeSeleccion.Numero.ToString());
            item.SubItems.Add(mercaderias[i].Descripcion);
            item.SubItems.Add(mercaderias[i].Cantidad);
            item.SubItems.Add(mercaderias[i].Ubicacion);
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos
    private void SeleccionarMercaderiasForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }

    private void listViewOrdenesDeSeleccionPendientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarDetalleDeOrdenDeSeleccion();
    }

    private void buttonConfirmarSeleccion_Click(object sender, EventArgs e)
    {
        // Mostrar un MessageBox de confirmación

        if (listViewOrdenesDeSeleccionPendientes.SelectedItems.Count == 0)
            Alerta.MostrarAdvertencia("Debe seleccionar una orden de selección pendiente para confirmar.");
        else
        {
            ListViewItem osSeleccionada = listViewOrdenesDeSeleccionPendientes.SelectedItems[0];
            var ordenDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenDeSeleccionPorNumero(long.Parse(osSeleccionada.Text));

            var mercaderias = ordenDeSeleccion.MercaderiasASeleccionar;
            string mensajeConfirmacion = "¿Confirma la selección de las siguientes mercaderías?\n\n";
            for (int i = 0; i < mercaderias.Count; i++)
            {
                mensajeConfirmacion += $"{mercaderias[i].Cantidad} de {mercaderias[i].Descripcion}\n";
            }

            DialogResult resultado = Alerta
                .PedirConfirmacion(mensajeConfirmacion);

            if (resultado == DialogResult.Yes)
            {
                Alerta.MostrarInfo("Seleccion Confirmada.\n\n"
                    + "Se ha realizado la baja del Stock seleccionado.");
                CargarFormulario();
            }

        }
    }

    #endregion
}
