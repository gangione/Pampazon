using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
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
        CargarListadoOrdenesPendientes();
        listViewMercaderiasASeleccionar.Items.Clear();
    }

    #endregion

    #region Ordenes de Seleccion Pendientes
    private void CargarListadoOrdenesPendientes()
    {
        listViewOrdenesDeSeleccionPendientes.Items.Clear();
        var ordenesPendientes = _seleccionarMercaderiasModel
            .ObtenerOrdenesDeSeleccionPendiente();

        listViewOrdenesDeSeleccionPendientes.Items.AddRange(ObtenerListViewOrdenesDeSeleccion(ordenesPendientes));
    }

    private static ListViewItem[] ObtenerListViewOrdenesDeSeleccion(List<OrdenDeSeleccion> ordenes)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ordenes.Count; i++)
        {
            ListViewItem item = new(ordenes[i].Numero.ToString());
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
            var ordenesDePreparacion = _seleccionarMercaderiasModel
                .ObtenerMercaderiasPorNumeroDeSeleccion(long.Parse(osSeleccionada.Text));

            listViewMercaderiasASeleccionar.Items
                .AddRange(ObtenerListViewDetalleDeOrdenDeSeleccion(ordenesDePreparacion));
        }
        else
        {
            listViewMercaderiasASeleccionar.Items.Clear();
        }
    }

    private static ListViewItem[] ObtenerListViewDetalleDeOrdenDeSeleccion(List<Mercaderia> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        mercaderias.ForEach(m =>
        {
            ListViewItem item = new(m.Ubicacion.ToString());
            item.SubItems.Add(m.Ubicacion.Cantidad.ToString());
            item.SubItems.Add(m.SKU);
            item.SubItems.Add(m.Descripcion);
            viewItems.Add(item);
        });

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
        if (listViewOrdenesDeSeleccionPendientes.SelectedItems.Count == 0)
            Alerta.MostrarAdvertencia("Debe seleccionar una orden de selección pendiente para confirmar.");
        else
        {
            ListViewItem osSeleccionada = listViewOrdenesDeSeleccionPendientes.SelectedItems[0];

            var resultado = _seleccionarMercaderiasModel
                .ConfirmarSeleccion(long.Parse(osSeleccionada.Text));

            if (resultado.Exitoso)
            {
                Alerta.MostrarInfo(resultado.Mensaje);
                CargarFormulario();
            }
            else
                Alerta.MostrarError(resultado.Mensaje);
        }
    }

    #endregion
}