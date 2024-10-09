using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Utilidades;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;
public partial class GenerarOrdenDeSeleccionForm : Form
{
    private GenerarOrdenDeSeleccionModel _ordenDeSeleccionModel;
    public GenerarOrdenDeSeleccionForm()
    {
        _ordenDeSeleccionModel = new();
        InitializeComponent();
    }

    #region Formulario
    private void CargarFormulario()
    {
        var clientes = _ordenDeSeleccionModel.ObtenerClientes();
        var ordenesDePreparacionPendientes = _ordenDeSeleccionModel
            .ObtenerOrdenesDePreparacionPendientes();

        listViewOrdenesDePreparacion.SelectedItems.Clear();
        listViewMercaderiasAPreparar.Items.Clear();
        listViewOrdenesASeleccionar.Items.Clear();

        comboBoxPrioridad.Items.Clear();
        comboBoxPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));
        comboBoxPrioridad.SelectedIndex = 1;

        textBoxCliente.Clear();

        ConfigurarAutocompleteClientes(clientes);
    }

    private List<string> ValidarFormularioOrdenDeSeleccion()
    {
        List<string> mensajes = new();
        var validarListado = Validador.ValidarListadoCompleto(listViewOrdenesASeleccionar.Items.Count);

        if (validarListado != string.Empty)
            mensajes.Add(validarListado);

        return mensajes;
    }

    #endregion

    #region Autocomplete
    private void ConfigurarAutocompleteClientes(List<Cliente> clientes)
    {
        // Crear una colección para el autocomplete
        AutoCompleteStringCollection nombresClientes = new();

        // Agregar los nombres de los clientes a la colección
        for (int i = 0; i < clientes.Count; i++)
        {
            nombresClientes.Add(clientes[i].Nombre);
        }

        textBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        textBoxCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBoxCliente.AutoCompleteCustomSource = nombresClientes;
        textBoxCliente.TextChanged += textBoxCliente_TextChanged;
    }

    #endregion

    #region Ordenes de Preparacion Pendientes

    private void CargarListadoOrdenesPendientesPorCliente(Cliente cliente)
    {
        listViewOrdenesDePreparacion.Items.Clear();
        var ordenesPendientes = _ordenDeSeleccionModel.ObtenerOrdenesPendientesPorCliente(cliente);

        listViewOrdenesDePreparacion.Items.AddRange(ObtenerListViewOrdenesDePreparacion(ordenesPendientes));
    }

    private static ListViewItem[] ObtenerListViewOrdenesDePreparacion(List<OrdenDePreparacion> ordenes)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ordenes.Count; i++)
        {
            ListViewItem item = new(ordenes[i].Numero.ToString());
            item.SubItems.Add(ordenes[i].Cliente.Nombre);
            item.SubItems.Add(ordenes[i].Cliente.Cuit.ToString());
            item.SubItems.Add(ordenes[i].FechaADespachar.ToString("dd/MM/yyyy"));
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Ordenes de Preparacion a Seleccionar



    #endregion

    #region Mercaderías a Preparar

    private void CargarListadoMercaderiasAPreparar()
    {
        listViewMercaderiasAPreparar.Items.Clear();
        if (listViewOrdenesDePreparacion.SelectedItems.Count > 0)
        {
            var mercaderias = _ordenDeSeleccionModel
                .ObtenerMercaderiasAPrepararPorOrden(listViewOrdenesDePreparacion.SelectedItems[0].Text);

            listViewMercaderiasAPreparar.Items.AddRange(ObtenerListViewMercaderiasAPreparar(mercaderias));
        }
    }

    private static ListViewItem[] ObtenerListViewMercaderiasAPreparar(List<Mercaderia>? mercaderias)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < mercaderias?.Count; i++)
        {
            ListViewItem item = new(mercaderias[i].Descripcion);
            item.SubItems.Add(mercaderias[i].UnidadDeMedida.ToString());
            item.SubItems.Add(mercaderias[i].Cantidad.ToString());
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos
    private void GenerarOrdenDeSeleccionForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }
    private void textBoxCliente_TextChanged(object sender, EventArgs e)
    {
        List<Cliente> clientes = _ordenDeSeleccionModel.ObtenerClientesPorFiltro(textBoxCliente.Text);

        var cliente = clientes.FirstOrDefault();
        // Lógica para completar el listado de mercaderías en Stock.
        if (cliente is not null && clientes.Count == 1)
            CargarListadoOrdenesPendientesPorCliente(cliente);
        else
        {
            listViewOrdenesDePreparacion.Items.Clear();
        }
    }
    private void listViewOrdenesDePreparacion_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        CargarListadoMercaderiasAPreparar();
    }
    private void buttonAgregar_Click(object sender, EventArgs e)
    {
        if (listViewOrdenesDePreparacion.SelectedItems.Count > 0)
        {
            // Obtener el ítem seleccionado
            ListViewItem selectedItem = listViewOrdenesDePreparacion.SelectedItems[0];

            foreach (ListViewItem item in listViewOrdenesASeleccionar.Items)
            {
                if (item.SubItems[0].Text.ToUpper() == selectedItem.SubItems[0].Text.ToUpper())
                {
                    Alerta.MostrarAdvertencia("Esta orden de preparación ya ha sido agregada. \n" +
                        "Eliminela de la selección e ingresela nuevamente.");
                    return;
                }
            }

            ListViewItem newItem = new(selectedItem.Text);

            if (listViewOrdenesASeleccionar.Items.Count > 0)
            {
                if (selectedItem.SubItems[2].Text != listViewOrdenesASeleccionar.Items[0].SubItems[2].Text)
                {
                    Alerta.MostrarAdvertencia("Las ordenes a seleccionar deben ser del mismo cliente.");
                    return;
                }
            }

            newItem.SubItems.Add(selectedItem.SubItems[1].Text);
            newItem.SubItems.Add(selectedItem.SubItems[2].Text);
            newItem.SubItems.Add(selectedItem.SubItems[3].Text);
            newItem.SubItems.Add(comboBoxPrioridad.SelectedItem?.ToString() ?? "Sin prioridad");

            listViewOrdenesASeleccionar.Items.Add(newItem);

            // Limpiar la selección y las mercaderías
            listViewOrdenesDePreparacion.SelectedItems.Clear();
            listViewMercaderiasAPreparar.Items.Clear();
        }
    }
    private void buttonEliminar_Click(object sender, EventArgs e)
    {
        if (listViewOrdenesASeleccionar.SelectedItems.Count > 0)
        {
            var selected = listViewOrdenesASeleccionar.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                var index = selected[i].Index;
                listViewOrdenesASeleccionar.Items.RemoveAt(index);
            }
        }
        else
            Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
    }

    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {

    }
    #endregion
}
