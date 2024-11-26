using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public partial class GenerarRemitoForm : Form
{
    private GenerarRemitoModel _generarRemitoModel;
    public GenerarRemitoForm()
    {
        _generarRemitoModel = new();
        InitializeComponent();
    }

    #region Formulario

    private void CargarFormulario()
    {
        var transportistas = _generarRemitoModel.ObtenerTransportistas();

        comboBoxTransportistas.Items.Clear();
        comboBoxTransportistas.Items.AddRange([.. transportistas]);

        listViewOrdenesDePreparacionPreparadas.Items.Clear();

        comboBoxDeposito.Items.Clear();
        comboBoxDeposito.Items.AddRange(Enum.GetNames(typeof(Deposito)));
        comboBoxDeposito.SelectedIndex = 0;
    }

    #endregion
    #region Listado Mercaderias en Stock
    private static ListViewItem[] ObtenerListViewOrdenesDePreparacionADespachar(List<OrdenDeEntrega> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < mercaderias.Count; i++)
        {
            ListViewItem item = new(mercaderias[i].NroOrdenDePreparacion.ToString());
            item.SubItems.Add(mercaderias[i].Cliente);
            item.SubItems.Add(mercaderias[i].SKU);
            item.SubItems.Add(mercaderias[i].Cantidad.ToString());
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }
    #endregion
    #region Eventos
    private void GenerarRemitoForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }
    private void comboBoxTransportistas_SelectedIndexChanged(object sender, EventArgs e)
    {
        Transportista? transportista = comboBoxTransportistas.SelectedItem as Transportista;

        if (transportista is not null)
        {
            var ordenesDeEntrega = _generarRemitoModel
                .ObtenerDetalleARetirarPorTransportistaYDeposito(transportista.DNI, Enum.Parse<Deposito>(comboBoxDeposito.Text));

            listViewOrdenesDePreparacionPreparadas.Items.Clear();
            listViewOrdenesDePreparacionPreparadas.Items
                .AddRange(ObtenerListViewOrdenesDePreparacionADespachar(ordenesDeEntrega));
        }
    }

    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {
        DialogResult confirma = Alerta.PedirConfirmacion("¿Desea confirmar el despacho y la genereación del remito?");

        if (confirma == DialogResult.Yes)
        {
            // Validar que se haya seleccionado un transportista
            Transportista? transportista = comboBoxTransportistas.SelectedItem as Transportista;
            if (transportista is null)
            {
                Alerta.MostrarError("Debe seleccionar un Transportista de la lista.");
                return;
            }

            var resultado = _generarRemitoModel
                .DespacharOrdenesDePreparacion(transportista.DNI, Enum.Parse<Deposito>(comboBoxDeposito.Text));

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