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

        listViewOrdenesDePreparacion.SelectedItems.Clear();
        listViewOrdenesASeleccionar.Items.Clear();

        textBoxBuscarPorCliente.Clear();

        comboBoxBuscarPorPrioridad.Items.Clear();
        comboBoxBuscarPorPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));

        ConfigurarAutocompleteClientes(clientes);
        CargarListadoOrdenesPendientes();
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

        textBoxBuscarPorCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        textBoxBuscarPorCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBoxBuscarPorCliente.AutoCompleteCustomSource = nombresClientes;
        textBoxBuscarPorCliente.TextChanged += textBoxBuscarPorCliente_TextChanged;
    }

    #endregion

    #region Ordenes de Preparacion Pendientes
    private void CargarListadoOrdenesPendientes()
    {
        listViewOrdenesDePreparacion.Items.Clear();
        var ordenesPendientes = _ordenDeSeleccionModel.ObtenerOrdenesDePreparacionPendientes();

        listViewOrdenesDePreparacion.Items.AddRange(ObtenerListViewOrdenesDePreparacion(ordenesPendientes));
    }

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
            item.SubItems.Add(ordenes[i].Cliente.Prioridad.ToString());
            item.SubItems.Add(ordenes[i].FechaADespachar.ToString("dd/MM/yyyy"));
            item.SubItems.Add(ordenes[i].Cliente.Nombre);
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

    private void textBoxBuscarPorCliente_TextChanged(object sender, EventArgs e)
    {
        List<Cliente> clientes = _ordenDeSeleccionModel.ObtenerClientesPorFiltro(textBoxBuscarPorCliente.Text);

        var cliente = clientes.FirstOrDefault();
        // Lógica para completar el listado de mercaderías en Stock.
        if (cliente is not null && clientes.Count == 1)
            CargarListadoOrdenesPendientesPorCliente(cliente);
        else
        {
            CargarListadoOrdenesPendientes();
        }
    }

    private void buttonAgregar_Click(object sender, EventArgs e)
    {
        if (listViewOrdenesDePreparacion.SelectedItems.Count > 0)
        {
            // Obtener el ítem seleccionado
            ListViewItem ordenDePreparacionSelected = listViewOrdenesDePreparacion.SelectedItems[0];

            foreach (ListViewItem item in listViewOrdenesASeleccionar.Items)
            {
                if (item.SubItems[0].Text.ToUpper() == ordenDePreparacionSelected.SubItems[0].Text.ToUpper())
                {
                    Alerta.MostrarAdvertencia("Esta orden de preparación ya ha sido agregada. \n" +
                        "Eliminela de la selección e ingresela nuevamente.");
                    return;
                }
            }

            ListViewItem seleccionDetalle = new(ordenDePreparacionSelected.Text);
            seleccionDetalle.SubItems.Add(ordenDePreparacionSelected.SubItems[1].Text);

            var mercaderias = _ordenDeSeleccionModel
                .ObtenerMercaderiasAPrepararPorOrden(ordenDePreparacionSelected.Text);

            for (int i = 0; i < mercaderias?.Count; i++)
            {
                seleccionDetalle.SubItems.Add(mercaderias[i].Descripcion);
                seleccionDetalle.SubItems.Add(mercaderias[i].Cantidad.ToString());
                seleccionDetalle.SubItems.Add(mercaderias[i].Ubicacion);
            }

            listViewOrdenesASeleccionar.Items.Add(seleccionDetalle);

            // Ordenar la lista de seleccion, limpiar la selección y las mercaderías
            listViewOrdenesASeleccionar.ListViewItemSorter = new ListViewItemComparer(1, SortOrder.Ascending);
            listViewOrdenesASeleccionar.Sort();
            listViewOrdenesDePreparacion.SelectedItems.Clear();
        }
        else
        {
            Alerta.MostrarAdvertencia("Debe seleccionar una orden de preparación.");
            return;
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
        DialogResult confirmacion = Alerta.PedirConfirmacion("Desea registrar la orden de selección?");

        if (confirmacion == DialogResult.Yes)
        {
            List<string> errores = ValidarFormularioOrdenDeSeleccion();

            if (errores.Count > 0)
            {
                Alerta.MostrarErrores(errores);
                return;
            }

            var ordenesSeleccionadas = listViewOrdenesASeleccionar.Items;

            OrdenDeSeleccion orden = new() { OrdenesASeleccionar = new() };
            for (int i = 0; i < ordenesSeleccionadas.Count; i++)
            {
                var nroOrden = ordenesSeleccionadas[i].Text;

                OrdenDePreparacion ordenDePreparacion = _ordenDeSeleccionModel
                    .ObtenerOrdenDePreparacionPorNumero(long.Parse(nroOrden));

                orden.OrdenesASeleccionar.Add(ordenDePreparacion);
            }

            var resultado = _ordenDeSeleccionModel.GenerarOrdenDeSeleccion(orden);

            if (resultado.Exitoso)
            {
                Alerta.MostrarInfo(resultado.Mensaje);
                CargarFormulario();
            }
            else
                Alerta.MostrarError(resultado.Mensaje);
        }
    }

    private void GenerarOrdenDeSeleccionForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult confirmacion = Alerta.PedirConfirmacion("Se perderán los datos ingresados.");

        if (confirmacion == DialogResult.No)
            e.Cancel = true;
    }

    #endregion
}