using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;
public partial class GenerarOrdenDePreparacionForm : Form
{
    private GenerarOrdenDePreparacionModel _ordenDePreparacionModel;
    private List<Cliente> _clientes;
    private List<Transportista> _transportistas;
    private List<Mercaderia> _mercaderiasEnStock;
    private Dictionary<string, ErrorProvider> _errores;
    public GenerarOrdenDePreparacionForm()
    {
        _ordenDePreparacionModel = new();
        InitializeComponent();
    }

    private void Iniciar()
    {
        CargarFormulario();
    }

    #region Formulario
    private void CargarFormulario()
    {
        _clientes = _ordenDePreparacionModel.ObtenerClientes();
        _transportistas = _ordenDePreparacionModel.ObtenerTransportistas();
        _mercaderiasEnStock = new();

        ConfigurarAutocompleteClientes();
        ConfigurarAutocompleteTransportistas();
    }

    private List<string> ValidarFormularioOrdenDePreparacion()
    {
        List<ErrorProvider> errores = new()
            {
                _errores.GetValueOrDefault("Cliente"),
                _errores.GetValueOrDefault("TransportistaDNI"),
                _errores.GetValueOrDefault("TransportistaNombre")
            };

        ValidateChildren();

        //if (_mercaderias.Count > 0)
        //{
        //    errorProviderDescripcionMercaderia.SetError(textBoxDescripcionMercaderia, "");
        //    errorProviderCantidadMercaderia.SetError(textBoxCantidadMercaderia, "");
        //}

        List<string> mensajes = Validador.ValidarControles(errores);

        return mensajes;
    }

    #endregion

    #region Listado Mercaderias en Stock
    private void CargarListadoMercaderiasEnStockPorCliente(Cliente cliente)
    {
        listViewMercaderiasEnStock.Items.Clear();
        _mercaderiasEnStock = _ordenDePreparacionModel.ObtenerMercaderiasPorCliente(cliente);

        listViewMercaderiasEnStock.Items.AddRange(ObtenerListViewMercaderiasEnStock(_mercaderiasEnStock));
    }

    private static ListViewItem[] ObtenerListViewMercaderiasEnStock(List<Mercaderia> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < mercaderias.Count; i++)
        {
            ListViewItem item = new(mercaderias[i].Descripcion);
            item.SubItems.Add(mercaderias[i].UnidadDeMedida.ToString());
            item.SubItems.Add(mercaderias[i].Cantidad.ToString());
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }
    #endregion
    #region Listado Mercaderías A Retirar
    private void AgregarItemMercaderiaARetirar(Mercaderia mercaderia, string stockFuturo)
    {
        ListViewItem item = new(mercaderia.Descripcion);
        item.SubItems.Add(mercaderia.UnidadDeMedida.ToString());
        item.SubItems.Add(mercaderia.Cantidad.ToString());
        item.SubItems.Add(stockFuturo);
        listViewMercaderiasARetirar.Items.Add(item);
        _mercaderiasEnStock.Add(mercaderia);

        textBoxCantidadARetirar.Text = string.Empty;
    }

    private void EliminarItemsMercaderiaARetirar()
    {
        var mercaderias = listViewMercaderiasEnStock.SelectedItems;
        for (int i = 0; i < mercaderias.Count; i++)
        {
            Mercaderia? mercaderia = _mercaderiasEnStock
                .Find(m => m.Descripcion == mercaderias[i].Text);

            _mercaderiasEnStock.Remove(mercaderia);
            listViewMercaderiasEnStock.Items.RemoveAt(mercaderias[i].Index);
        }
    }

    #endregion

    #region Autocomplete
    private void ConfigurarAutocompleteClientes()
    {
        // Crear una colección para el autocomplete
        AutoCompleteStringCollection nombresClientes = new();

        // Agregar los nombres de los clientes a la colección
        foreach (var cliente in _clientes)
        {
            nombresClientes.Add(cliente.Nombre);
        }

        textBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        textBoxCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBoxCliente.AutoCompleteCustomSource = nombresClientes;
        textBoxCliente.TextChanged += textBoxCliente_TextChanged;
    }

    private void ConfigurarAutocompleteTransportistas()
    {
        // Crear una colección para el autocomplete
        AutoCompleteStringCollection nombresTransportistas = new();

        // Agregar los nombres a la colección
        foreach (var transportista in _transportistas)
        {
            nombresTransportistas.Add(transportista.NombreYApellido);
        }

        textBoxNombreTransportista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        textBoxNombreTransportista.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBoxNombreTransportista.AutoCompleteCustomSource = nombresTransportistas;
        textBoxNombreTransportista.TextChanged += textBoxNombreTransportista_TextChanged;
    }

    #endregion

    #region Eventos
    private void GenerarOrdenDePreparacionForm_Load(object sender, EventArgs e)
    {
        Iniciar();
    }

    private void textBoxCliente_TextChanged(object sender, EventArgs e)
    {
        _clientes = _ordenDePreparacionModel.ObtenerClientesPorFiltro(textBoxCliente.Text);

        var cliente = _clientes.FirstOrDefault();
        // Lógica para completar el listado de mercaderías en Stock.
        if (cliente is not null && _clientes.Count == 1)
            CargarListadoMercaderiasEnStockPorCliente(cliente);
        else
        {
            _mercaderiasEnStock.Clear();
            listViewMercaderiasEnStock.Items.Clear();
        }
    }

    private void buttonAgregar_Click(object sender, EventArgs e)
    {
        //List<string> erroresValidacion = ValidarFormularioMercaderias();
        //if (erroresValidacion.Count > 0)
        //{
        //    Alerta.MostrarErrores(erroresValidacion);
        //    return;
        //}
        if (listViewMercaderiasEnStock.SelectedItems.Count > 0)
        {
            ListViewItem selected = listViewMercaderiasEnStock.SelectedItems[0];
            Mercaderia mercaderia = new()
            {
                //NumeroCliente = 
                Descripcion = selected.SubItems[0].Text,
                //UnidadDeMedida = "UM"//selected.SubItems[1].Text,
                Cantidad = int.Parse(textBoxCantidadARetirar.Text)
            };

            int stockFuturo = int.Parse(selected.SubItems[2].Text) -
                int.Parse(textBoxCantidadARetirar.Text);

            AgregarItemMercaderiaARetirar(
                mercaderia,
                stockFuturo.ToString()
            );
        }
        else
            Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
    }

    private void textBoxNombreTransportista_TextChanged(object sender, EventArgs e)
    {
        _transportistas = _ordenDePreparacionModel
            .ObtenerTransportistasPorFiltro(textBoxNombreTransportista.Text);

        var transportista = _transportistas.FirstOrDefault();

        if (transportista is not null && _transportistas.Count == 1)
            textBoxDNITransportista.Text = transportista.DNI.ToString();
        else
            textBoxDNITransportista.Text = string.Empty;
    }

    private void buttonEditar_Click(object sender, EventArgs e)
    {
    }

    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {
        DialogResult confirmacion = Alerta.PedirConfirmacion("Desea registrar la orden de preparación?");

        if (confirmacion == DialogResult.Yes)
        {
            var resultado = _ordenDePreparacionModel.GenerarOrdenDePreparacion();

            if (resultado.Exitoso)
                Alerta.MostrarInfo(resultado.Mensaje);
            else
                Alerta.MostrarError(resultado.Mensaje);
        }
    }

    private void GenerarOrdenDePreparacionForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult confirmacion = Alerta.PedirConfirmacion("Se perderán los datos ingresados.");

        if (confirmacion == DialogResult.No)
            e.Cancel = true;
    }
    #endregion
}