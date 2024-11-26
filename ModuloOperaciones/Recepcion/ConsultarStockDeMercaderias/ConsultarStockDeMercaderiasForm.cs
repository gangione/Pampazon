using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias.Enums;

namespace Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias;
public partial class ConsultarStockDeMercaderiasForm : Form
{
    private ConsultarStockDeMercaderiasModel _modelo;
    public ConsultarStockDeMercaderiasForm()
    {
        _modelo = new();
        InitializeComponent();
    }

    public void CargarFormulario()
    {
        comboBoxDeposito.Items.Clear();
        comboBoxDeposito.Items.AddRange(Enum.GetNames(typeof(Deposito)));
        comboBoxDeposito.SelectedItem = null;

        var clientes = _modelo.ObtenerClientes();
        comboBoxBuscarPorCliente.Items.Clear();
        comboBoxBuscarPorCliente.Items.AddRange([.. clientes]);
        comboBoxBuscarPorCliente.SelectedItem = null;

        var mercaderias = _modelo.ObtenerMercaderiasEnStockPorFiltros(null, null, null);
        listViewMercaderiasEnStock.Items.Clear();
        listViewMercaderiasEnStock.Items
            .AddRange(ObtenerListViewMercaderias(mercaderias));
    }
    #region Listados
    private ListViewItem[] ObtenerListViewMercaderias(List<Mercaderia> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < mercaderias.Count; i++)
        {
            ListViewItem item = new(mercaderias[i].SKU);
            item.SubItems.Add(mercaderias[i].Deposito.ToString());
            item.SubItems.Add(mercaderias[i].CantidadTotal.ToString());
            item.SubItems.Add(mercaderias[i].Descripcion);
            item.SubItems.Add(mercaderias[i].Cliente);
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    private static ListViewItem[] ObtenerListViewDetalleUbicaciones(List<Ubicacion> ubicaciones)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ubicaciones.Count; i++)
        {
            ListViewItem item = new(ubicaciones[i].ToString());
            item.SubItems.Add(ubicaciones[i].Cantidad);
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion
    #region Eventos
    private void ConsultarStockDeMercaderiasForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }
    private void buttonBuscar_Click(object sender, EventArgs e)
    {
        Cliente? cliente = comboBoxBuscarPorCliente.SelectedItem as Cliente;
        Deposito? deposito = comboBoxDeposito.Text == string.Empty ? null : Enum.Parse<Deposito>(comboBoxDeposito.Text);
        string? sku = textBoxBuscarSKU.Text == string.Empty ? null : textBoxBuscarSKU.Text.Trim();

        var mercaderias = _modelo.ObtenerMercaderiasEnStockPorFiltros(
            deposito,
            cliente is null ? null : cliente.Nombre,
            sku
        );

        listViewDetalle.Items.Clear();
        listViewMercaderiasEnStock.Items.Clear();
        listViewMercaderiasEnStock.Items
            .AddRange(ObtenerListViewMercaderias(mercaderias));
    }
    private void buttonLimpiarFiltros_Click(object sender, EventArgs e)
    {
        listViewDetalle.Items.Clear();

        comboBoxBuscarPorCliente.SelectedItem = null;
        comboBoxBuscarPorCliente.Text = string.Empty;

        comboBoxDeposito.SelectedItem = null;
        comboBoxDeposito.Text = string.Empty;

        textBoxBuscarSKU.Text = null;

        buttonBuscar_Click(sender, e);
    }
    private void listViewMercaderiasEnStock_SelectedIndexChanged(object sender, EventArgs e)
    {
        listViewDetalle.Items.Clear();
        if (listViewMercaderiasEnStock.SelectedItems.Count > 0)
        {
            // Obtener el ítem seleccionado
            ListViewItem SKUSelected = listViewMercaderiasEnStock.SelectedItems[0];

            var ubicaciones = _modelo
                .ObtenerUbicacionesPorDepositoYSKU(Enum.Parse<Deposito>(SKUSelected.SubItems[1].Text),
                    SKUSelected.SubItems[0].Text
                );

            for (int i = 0; i < ubicaciones?.Count; i++)
            {
                ListViewItem detalle = new(ubicaciones[i].ToString());
                detalle.SubItems.Add(ubicaciones[i].Cantidad);
                listViewDetalle.Items.Add(detalle);
            }
        }
    }
    #endregion
}