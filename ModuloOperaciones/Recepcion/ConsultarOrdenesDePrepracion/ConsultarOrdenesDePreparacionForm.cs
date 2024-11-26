using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion;
public partial class ConsultarOrdenesDePreparacionForm : Form
{
    private ConsultarOrdenesDePreparacionModel _modelo;
    public ConsultarOrdenesDePreparacionForm()
    {
        _modelo = new();
        InitializeComponent();
    }

    public void CargarFormulario()
    {
        comboBoxBuscarPorPrioridad.Items.Clear();
        comboBoxBuscarPorPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));
        comboBoxBuscarPorPrioridad.SelectedItem = null;

        comboBoxDeposito.Items.Clear();
        comboBoxDeposito.Items.AddRange(Enum.GetNames(typeof(Deposito)));
        comboBoxDeposito.SelectedItem = null;

        var clientes = _modelo.ObtenerClientes();
        comboBoxBuscarPorCliente.Items.Clear();
        comboBoxBuscarPorCliente.Items.AddRange([.. clientes]);
        comboBoxBuscarPorCliente.SelectedItem = null;

        var ordenes = _modelo.ObtenerOrdenesDePreparacionPorFiltros(null, null, null);
        listViewOrdenesDePreparacion.Items.Clear();
        listViewOrdenesDePreparacion.Items
            .AddRange(ObtenerListViewOrdenes(ordenes));
    }

    #region Listados
    private ListViewItem[] ObtenerListViewOrdenes(List<OrdenDePreparacion> ordenes)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ordenes.Count; i++)
        {
            ListViewItem item = new(ordenes[i].Numero.ToString());
            item.SubItems.Add(ordenes[i].Deposito.ToString());
            item.SubItems.Add(ordenes[i].Estado.ToString());
            item.SubItems.Add(ordenes[i].FechaADespachar.ToString("dd/MM/yyyy"));
            item.SubItems.Add(ordenes[i].Prioridad.ToString());
            item.SubItems.Add(ordenes[i].Cliente.ToString());
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    private static ListViewItem[] ObtenerListViewDetalle(List<Mercaderia> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < mercaderias.Count; i++)
        {
            ListViewItem item = new(mercaderias[i].SKU);
            item.SubItems.Add(mercaderias[i].Descripcion);
            item.SubItems.Add(mercaderias[i].Cantidad.ToString());
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos
    private void ConsultarOrdenesDePreparacionForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }

    private void buttonBuscar_Click(object sender, EventArgs e)
    {
        Cliente? cliente = comboBoxBuscarPorCliente.SelectedItem as Cliente;
        Deposito? deposito = comboBoxDeposito.Text == string.Empty ? null : Enum.Parse<Deposito>(comboBoxDeposito.Text);
        Prioridad? prioridad = comboBoxBuscarPorPrioridad.Text == string.Empty ? null : Enum.Parse<Prioridad>(comboBoxBuscarPorPrioridad.Text);

        var ordenes = _modelo.ObtenerOrdenesDePreparacionPorFiltros(
            deposito,
            cliente is null ? 0 : (int)cliente.Numero,
            prioridad
        );

        listViewOrdenesDePreparacion.Items.Clear();
        listViewOrdenesDePreparacion.Items
            .AddRange(ObtenerListViewOrdenes(ordenes));
        //listViewDetalle.Items
        //    .AddRange(ObtenerListViewDetalle(mercaderias));
    }
    private void buttonLimpiarFiltros_Click(object sender, EventArgs e)
    {
        comboBoxBuscarPorCliente.SelectedItem = null;
        comboBoxBuscarPorCliente.Text = string.Empty;

        comboBoxDeposito.SelectedItem = null;
        comboBoxDeposito.Text = string.Empty;

        comboBoxBuscarPorPrioridad.SelectedItem = null;
        comboBoxBuscarPorPrioridad.Text = string.Empty;

        buttonBuscar_Click(sender, e);
    }
    private void listViewOrdenesDePreparacion_SelectedIndexChanged(object sender, EventArgs e)
    {
        listViewDetalle.Items.Clear();
        if (listViewOrdenesDePreparacion.SelectedItems.Count > 0)
        {
            // Obtener el ítem seleccionado
            ListViewItem ordenDePreparacionSelected = listViewOrdenesDePreparacion.SelectedItems[0];

            var mercaderias = _modelo
                .ObtenerMercaderiasAPrepararPorOrden(long.Parse(ordenDePreparacionSelected.Text));

            for (int i = 0; i < mercaderias?.Count; i++)
            {
                ListViewItem seleccionDetalle = new(mercaderias[i].SKU);
                seleccionDetalle.SubItems.Add(mercaderias[i].Descripcion);
                seleccionDetalle.SubItems.Add(mercaderias[i].Cantidad.ToString());
                listViewDetalle.Items.Add(seleccionDetalle);
            }
        }
    }
    #endregion
}