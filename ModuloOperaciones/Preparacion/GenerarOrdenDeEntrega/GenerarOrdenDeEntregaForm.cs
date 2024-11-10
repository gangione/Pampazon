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

    private void CargarMercaderiasAEmpaquetar(OrdenDeSeleccion? os)
    {
        listViewMercaderiasAEmpaquetar.Items.Clear();

        if (os is null)
        {
            Alerta.MostrarAdvertencia("No existen ordenes pendientes a empaquetar...");
            return;
        }

        if (os?.OrdenesASeleccionar.Count > 0)
        {
            ListViewItem[] mercaderias = ObtenerListViewMercaderiasAEmpaquetar(os);

            listViewMercaderiasAEmpaquetar.Items
                .AddRange(mercaderias);
        }
    }

    private static ListViewItem[] ObtenerListViewMercaderiasAEmpaquetar(OrdenDeSeleccion os)
    {
        List<ListViewItem> viewItems = new();

        foreach (var op in os.OrdenesASeleccionar)
        {
            foreach (var m in op.MercaderiasAPreparar)
            {
                ListViewItem item = new(op.Numero.ToString());
                item.SubItems.Add(m.SKU);
                item.SubItems.Add(m.Descripcion);
                item.SubItems.Add(m.Cantidad.ToString());
                viewItems.Add(item);
            }
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos

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

        _generarOrdenDeEntregaModel
            .ConfirmarEmpaquetado((long)groupBoxOrdenDeSeleccion.Tag);

        listViewMercaderiasAEmpaquetar.Items.Clear();
        groupBoxOrdenDeSeleccion.Text = "Orden de Selección";
    }
    #endregion
}