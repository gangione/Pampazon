using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Utilidades;

namespace Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeEntrega;
public partial class GenerarOrdenDeEntregaForm : Form
{
    private GenerarOrdenDeEntregaModel _generarOrdenDeEntregaModel;
    public GenerarOrdenDeEntregaForm()
    {
        _generarOrdenDeEntregaModel = new();
        InitializeComponent();
    }

    #region Formulario
    private void CargarSiguienteOrdenAPreparar()
    {
        if (listViewMercaderiasAEmpaquetar.Items.Count > 0)
        {
            Alerta.MostrarAdvertencia("Debe terminar de empaquetar la Orden actual.");
            return;
        }

        var siguienteOrden = _generarOrdenDeEntregaModel
            .ObtenerSiguienteOrdenAEmpaquetar();

        if (siguienteOrden is not null)
            groupBoxOrdenDeSeleccion.Text = $"Orden de Selección N° {siguienteOrden?.Numero}";
        else
            groupBoxOrdenDeSeleccion.Text = "Orden de Selección";

        CargarMercaderiasAEmpaquetar(siguienteOrden);
    }

    #endregion

    #region Mercaderias a Empaquetar

    private void CargarMercaderiasAEmpaquetar(OrdenDeSeleccion? ordenDeSeleccion)
    {
        listViewMercaderiasAEmpaquetar.Items.Clear();

        if (ordenDeSeleccion is null)
            return;

        if (ordenDeSeleccion?.OrdenesASeleccionar.Count > 0)
        {
            ListViewItem[] mercaderias = ObtenerListViewMercaderiasAEmpaquetar(ordenDeSeleccion);

            listViewMercaderiasAEmpaquetar.Items
                .AddRange(mercaderias);
        }
    }

    private static ListViewItem[] ObtenerListViewMercaderiasAEmpaquetar(OrdenDeSeleccion ordenDeSeleccion)
    {
        List<ListViewItem> viewItems = new();
        var ordenesDePreparacion = ordenDeSeleccion.OrdenesASeleccionar;
        for (int i = 0; i < ordenesDePreparacion.Count; i++)
        {
            var mercaderias = ordenesDePreparacion[i].MercaderiasAPreparar;
            for (int j = 0; j < mercaderias?.Count; j++)
            {
                ListViewItem item = new(ordenesDePreparacion[i].Numero.ToString());
                item.SubItems.Add(mercaderias[j].Descripcion);
                item.SubItems.Add(mercaderias[j].Cantidad);
                viewItems.Add(item);
            }
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos

    private void GenerarOrdenDeEntregaForm_Load(object sender, EventArgs e)
    {
        CargarSiguienteOrdenAPreparar();
    }

    private void buttonBuscarSiguienteOrden_Click(object sender, EventArgs e)
    {
        CargarSiguienteOrdenAPreparar();
    }

    private void buttonEmpaquetar_Click(object sender, EventArgs e)
    {
        if (listViewMercaderiasAEmpaquetar.SelectedItems.Count == 0)
        {
            Alerta.MostrarAdvertencia("Debe seleccionar una mercadería para empaquetar.");
            return;
        }
        else
        {
            ListViewItem mercaderiaItemSelected = listViewMercaderiasAEmpaquetar.SelectedItems[0];

            string numeroOP = mercaderiaItemSelected.Text;
            string tipoMercaderia = mercaderiaItemSelected.SubItems[1].Text;
            string cantidadMercaderia = mercaderiaItemSelected.SubItems[2].Text;

            ListViewItem mercaderiaItem = new(numeroOP);
            mercaderiaItem.SubItems.Add(tipoMercaderia);
            mercaderiaItem.SubItems.Add(cantidadMercaderia);

            listViewMercaderiasPreparadas.Items.Add(mercaderiaItem);

        }
    }

    #endregion
}