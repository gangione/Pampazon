using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Utilidades;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;
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
        {
            groupBoxOrdenDeSeleccion.Text = $"Orden de Selección N° {siguienteOrden?.Numero}";
            groupBoxOrdenDeSeleccion.Tag = siguienteOrden?.Numero;
        }
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
        {
            Alerta.MostrarAdvertencia("No existen ordenes pendientes a empaquetar...");
            return;
        }

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
                item.SubItems.Add(mercaderias[j].SKU);
                item.SubItems.Add(mercaderias[j].Descripcion);
                item.SubItems.Add(mercaderias[j].Cantidad.ToString());
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

    private void buttonConfirmarPreparacion_Click(object sender, EventArgs e)
    {
        if (listViewMercaderiasAEmpaquetar.Items.Count == 0)
        {
            Alerta.MostrarAdvertencia("No hay orden para empaquetar...");
            return;
        }

        DialogResult confirma = Alerta.PedirConfirmacion("Desea confirmar el empaquetado de la orden?");

        if (confirma == DialogResult.Yes)
        {
            _generarOrdenDeEntregaModel
                .ConfirmarEmpaquetado((long)groupBoxOrdenDeSeleccion.Tag);

            Alerta.MostrarInfo("Se confirmó el empaquetado correctamente.");
            listViewMercaderiasAEmpaquetar.Items.Clear();
            CargarSiguienteOrdenAPreparar();
        }
    }
    #endregion
}