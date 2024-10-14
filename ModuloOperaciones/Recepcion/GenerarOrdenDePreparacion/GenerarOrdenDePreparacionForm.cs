using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;
public partial class GenerarOrdenDePreparacionForm : Form
{
    private GenerarOrdenDePreparacionModel _ordenDePreparacionModel;
    public GenerarOrdenDePreparacionForm()
    {
        _ordenDePreparacionModel = new();
        InitializeComponent();
    }

    #region Formulario
    private void CargarFormulario()
    {
        var clientes = _ordenDePreparacionModel.ObtenerClientes();
        var transportistas = _ordenDePreparacionModel.ObtenerTransportistas();

        labelPrioridad.Hide();
        textBoxFechaADespachar.Clear();
        textBoxCantidadAPreparar.Clear();
        textBoxDNITransportista.Clear();
        textBoxNombreTransportista.Clear();
        listViewMercaderiasEnStock.Items.Clear();
        listViewMercaderiasARetirar.Items.Clear();

        ConfigurarValidadores();

        comboBoxClientes.Items.Clear();
        comboBoxClientes.Items.AddRange([.. clientes]);

        ConfigurarAutocompleteTransportistas(transportistas);
    }

    private void ConfigurarValidadores()
    {
        // Fecha de despacho
        textBoxFechaADespachar.Tag = labelFechaADespachar.Text;
        errorProviderFechaADespachar.Tag = textBoxFechaADespachar;

        // Transportista
        textBoxDNITransportista.Tag = labelDNITransportista.Text;
        errorProviderTransportistaDNI.Tag = textBoxDNITransportista;

        textBoxNombreTransportista.Tag = labelNombreTransportista.Text;
        errorProviderTransportistaNombre.Tag = textBoxNombreTransportista;

        // Mercaderias
        textBoxCantidadAPreparar.Tag = labelCantidadAPreparar.Text;
        errorProviderCantidadAPreparar.Tag = textBoxCantidadAPreparar;
    }

    private List<string> ValidarFormularioMercaderias()
    {
        string cantidad = Validador.ValidarCampoNumerico(textBoxCantidadAPreparar.Text);

        if (!string.IsNullOrEmpty(cantidad))
            errorProviderCantidadAPreparar.SetError(textBoxCantidadAPreparar, cantidad);
        else
            errorProviderCantidadAPreparar.SetError(textBoxCantidadAPreparar, string.Empty);

        List<ErrorProvider> errores = new()
        {
            errorProviderCantidadAPreparar
        };

        ValidateChildren();

        List<string> mensajes =
        [
            .. Validador.ValidarControles(errores),
        ];

        return mensajes;
    }

    private List<string> ValidarFormularioOrdenDePreparacion()
    {
        string fecha = Validador.ValidarFecha(textBoxFechaADespachar.Text);

        if (!string.IsNullOrEmpty(fecha))
            errorProviderFechaADespachar.SetError(textBoxFechaADespachar, fecha);
        else
            errorProviderFechaADespachar.SetError(textBoxFechaADespachar, string.Empty);

        string transportistaNombre = Validador.ValidarCampoVacio(textBoxNombreTransportista.Text);

        if (!string.IsNullOrEmpty(transportistaNombre))
            errorProviderTransportistaNombre.SetError(textBoxNombreTransportista, transportistaNombre);
        else
            errorProviderTransportistaNombre.SetError(textBoxNombreTransportista, string.Empty);

        string transportistaDNI = Validador.ValidarDNI(textBoxDNITransportista.Text);

        if (!string.IsNullOrEmpty(transportistaDNI))
            errorProviderTransportistaDNI.SetError(textBoxDNITransportista, transportistaDNI);
        else
            errorProviderTransportistaDNI.SetError(textBoxDNITransportista, string.Empty);

        List<ErrorProvider> errores = new()
        {
            errorProviderFechaADespachar,
            errorProviderTransportistaNombre,
            errorProviderTransportistaDNI
        };

        ValidateChildren();

        List<string> mensajes =
        [
            .. Validador.ValidarControles(errores),
        ];

        var validarListado = Validador.ValidarListadoCompleto(listViewMercaderiasARetirar.Items.Count);

        if (validarListado != string.Empty)
            mensajes.Add(validarListado);

        return mensajes;
    }

    #endregion

    #region Listado Mercaderias en Stock
    private static ListViewItem[] ObtenerListViewMercaderiasEnStock(List<Mercaderia> mercaderias)
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

    #region Listado Mercaderías A Retirar
    private void AgregarItemMercaderiaARetirar(Mercaderia mercaderia)
    {
        ListViewItem item = new(mercaderia.SKU);
        item.SubItems.Add(mercaderia.Descripcion);
        item.SubItems.Add(mercaderia.Cantidad.ToString());
        listViewMercaderiasARetirar.Items.Add(item);

        textBoxCantidadAPreparar.Text = string.Empty;
    }

    #endregion

    #region Autocomplete
    private void ConfigurarAutocompleteTransportistas(List<Transportista> transportistas)
    {
        // Crear una colección para el autocomplete
        AutoCompleteStringCollection nombresTransportistas = new();

        // Agregar los nombres a la colección
        for (int i = 0; i < transportistas.Count; i++)
        {
            nombresTransportistas.Add(transportistas[i].NombreYApellido);
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
        CargarFormulario();
    }

    private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cliente? cliente = comboBoxClientes.SelectedItem as Cliente;

        if (cliente is not null)
        {
            var mercaderias = _ordenDePreparacionModel.ObtenerMercaderiasEnStockPorCliente(cliente);
            listViewMercaderiasEnStock.Items.Clear();
            listViewMercaderiasARetirar.Items.Clear();

            listViewMercaderiasEnStock.Items
                .AddRange(ObtenerListViewMercaderiasEnStock(mercaderias));


            labelPrioridad.Text = $"Prioridad del Cliente: {cliente.Prioridad}";
            labelPrioridad.Show();
        }
    }

    private void buttonAgregar_Click(object sender, EventArgs e)
    {
        if (listViewMercaderiasEnStock.SelectedItems.Count > 0)
        {
            List<string> erroresValidacion = ValidarFormularioMercaderias();
            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            ListViewItem selected = listViewMercaderiasEnStock.SelectedItems[0];

            foreach (ListViewItem item in listViewMercaderiasARetirar.Items)
            {
                if (item.SubItems[0].Text.ToUpper() == selected.SubItems[0].Text.ToUpper())
                {
                    Alerta.MostrarAdvertencia("Esta mercadería ya ha sido agregada. \n" +
                        "Eliminela de la orden e ingresela nuevamente.");
                    return;
                }
            }
            Cliente? cliente = comboBoxClientes.SelectedItem as Cliente;

            Mercaderia mercaderia = new()
            {
                SKU = selected.Text,
                NumeroCliente = cliente.Numero,
                Descripcion = selected.SubItems[1].Text,
                Cantidad = int.Parse(textBoxCantidadAPreparar.Text)
            };

            int stockFuturo = int.Parse(selected.SubItems[2].Text) -
                int.Parse(textBoxCantidadAPreparar.Text);

            if (stockFuturo < 0)
            {
                Alerta.MostrarAdvertencia("La mercadería a preparar no puede superar la cantidad en stock.");
                return;
            }

            AgregarItemMercaderiaARetirar(
                mercaderia
            );
        }
        else
            Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
    }

    private void textBoxNombreTransportista_TextChanged(object sender, EventArgs e)
    {
        var transportistas = _ordenDePreparacionModel
            .ObtenerTransportistasPorFiltro(textBoxNombreTransportista.Text);

        var transportista = transportistas.FirstOrDefault();

        if (transportista is not null && transportistas.Count == 1)
            textBoxDNITransportista.Text = transportista.DNI.ToString();
        else
            textBoxDNITransportista.Text = string.Empty;
    }

    private void buttonEliminar_Click(object sender, EventArgs e)
    {
        if (listViewMercaderiasARetirar.SelectedItems.Count > 0)
        {
            var selected = listViewMercaderiasARetirar.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                var index = selected[i].Index;
                listViewMercaderiasARetirar.Items.RemoveAt(index);
            }
        }
        else
            Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
    }

    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {
        DialogResult confirmacion = Alerta.PedirConfirmacion("Desea registrar la orden de preparación?");

        if (confirmacion == DialogResult.Yes)
        {
            List<string> errores = ValidarFormularioOrdenDePreparacion();

            if (errores.Count > 0)
            {
                Alerta.MostrarErrores(errores);
                return;
            }

            Cliente? cliente = comboBoxClientes.SelectedItem as Cliente;
            List<Mercaderia> mercaderias = new();
            foreach (ListViewItem item in listViewMercaderiasARetirar.Items)
            {
                Mercaderia mercaderia = new()
                {
                    SKU = item.Text,
                    NumeroCliente = cliente.Numero,
                    Descripcion = item.SubItems[1].Text,
                    Cantidad = int.Parse(item.SubItems[2].Text),
                };
                mercaderias.Add(mercaderia);
            }

            var resultado = _ordenDePreparacionModel
                .GenerarOrdenDePreparacion(new OrdenDePreparacion()
                {
                    FechaDeDespacho = DateTime.Parse(textBoxFechaADespachar.Text),
                    MercaderiasAPreparar = mercaderias
                });

            if (resultado.Exitoso)
            {
                Alerta.MostrarInfo(resultado.Mensaje);
                CargarFormulario();
            }
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