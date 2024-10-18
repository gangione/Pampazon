using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Utilidades;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
public partial class SeleccionarMercaderiasForm : Form
{
    private SeleccionarMercaderiasModel _seleccionarMercaderiasModel;
    public SeleccionarMercaderiasForm()
    {
        _seleccionarMercaderiasModel = new();
        InitializeComponent();
    }

    #region Formulario
    private void CargarFormulario()
    {
        comboBoxBuscarPorPrioridad.SelectedIndex = -1;
        comboBoxBuscarPorPrioridad.Items.Clear();
        comboBoxBuscarPorPrioridad.Items.Add(string.Empty);
        comboBoxBuscarPorPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));

        CargarListadoOrdenesPendientes();
        listViewMercaderiasASeleccionar.Items.Clear();
    }

    #endregion

    #region Ordenes de Seleccion Pendientes
    private void CargarListadoOrdenesPendientes()
    {
        listViewOrdenesDeSeleccionPendientes.Items.Clear();
        var ordenesPendientes = _seleccionarMercaderiasModel
            .ObtenerOrdenesDeSeleccionPendiente();

        listViewOrdenesDeSeleccionPendientes.Items.AddRange(ObtenerListViewOrdenesDeSeleccion(ordenesPendientes));
    }

    private static ListViewItem[] ObtenerListViewOrdenesDeSeleccion(List<OrdenDeSeleccion> ordenes)
    {
        List<ListViewItem> viewItems = new();
        for (int i = 0; i < ordenes.Count; i++)
        {
            ListViewItem item = new(ordenes[i].Numero.ToString());
            item.SubItems.Add(ordenes[i].Prioridad.ToString());
            item.SubItems.Add(ordenes[i].FechaADespachar.ToString("dd/MM/yyyy"));
            viewItems.Add(item);
        }
        return viewItems.ToArray();
    }

    #endregion

    #region Detalle de Orden - Mercaderias Seleccionadas

    private void CargarDetalleDeOrdenDeSeleccion()
    {
        if (listViewOrdenesDeSeleccionPendientes.SelectedItems.Count > 0)
        {
            ListViewItem osSeleccionada = listViewOrdenesDeSeleccionPendientes.SelectedItems[0];

            listViewMercaderiasASeleccionar.Items.Clear();
            var ordenesDePreparacion = _seleccionarMercaderiasModel
                .ObtenerMercaderiasPorNumeroDeSeleccion(long.Parse(osSeleccionada.Text));

            listViewMercaderiasASeleccionar.Items
                .AddRange(ObtenerListViewDetalleDeOrdenDeSeleccion(ordenesDePreparacion));
        }
        else
        {
            listViewMercaderiasASeleccionar.Items.Clear();
        }

    }

    private static ListViewItem[] ObtenerListViewDetalleDeOrdenDeSeleccion(List<Mercaderia> mercaderias)
    {
        List<ListViewItem> viewItems = new();
        mercaderias.ForEach(m =>
        {
            ListViewItem item = new(m.Ubicacion.ToString());
            item.SubItems.Add(m.Cantidad.ToString());
            item.SubItems.Add(m.SKU);
            item.SubItems.Add(m.Descripcion);
            item.SubItems.Add(m.NroOrdenDePreparacion.ToString());
            viewItems.Add(item);
        });

        return viewItems.ToArray();
    }

    #endregion

    #region Eventos
    private void SeleccionarMercaderiasForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
    }

    private void buttonBuscar_Click(object sender, EventArgs e)
    {
        Prioridad? prioridad = null;
        if (comboBoxBuscarPorPrioridad.Text != string.Empty)
        {
            var prioridadSeleccionada = comboBoxBuscarPorPrioridad.Text;

            if (prioridadSeleccionada is not null)
                prioridad = (Prioridad)Enum.Parse(typeof(Prioridad), prioridadSeleccionada);
        }

        if (prioridad is null)
        {
            var ordenesDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenesDeSeleccionPendiente();

            listViewOrdenesDeSeleccionPendientes.Items.Clear();

            listViewOrdenesDeSeleccionPendientes.Items
                .AddRange(ObtenerListViewOrdenesDeSeleccion(ordenesDeSeleccion));
        }
        else
        {
            var ordenesDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenesDeSeleccionPendientePorPrioridad(prioridad);

            listViewOrdenesDeSeleccionPendientes.Items.Clear();

            listViewOrdenesDeSeleccionPendientes.Items
                .AddRange(ObtenerListViewOrdenesDeSeleccion(ordenesDeSeleccion));
        }
    }
    private void listViewOrdenesDeSeleccionPendientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarDetalleDeOrdenDeSeleccion();
    }

    private void buttonConfirmarSeleccion_Click(object sender, EventArgs e)
    {
        if (listViewOrdenesDeSeleccionPendientes.SelectedItems.Count == 0)
            Alerta.MostrarAdvertencia("Debe seleccionar una orden de selección pendiente para confirmar.");
        else
        {
            ListViewItem osSeleccionada = listViewOrdenesDeSeleccionPendientes.SelectedItems[0];
            List<Mercaderia> mercaderias = _seleccionarMercaderiasModel
                .ObtenerMercaderiasPorNumeroDeSeleccion(long.Parse(osSeleccionada.Text));

            string mensajeConfirmacion = "¿Confirma la selección de las siguientes mercaderías?\n\n"
                + "Ubicacion\tCantidad\n";
            for (int i = 0; i < mercaderias.Count; i++)
            {
                mensajeConfirmacion += $"{mercaderias[i].Ubicacion}\t\t{mercaderias[i].Cantidad}\n";
            }

            DialogResult confirma = Alerta
                .PedirConfirmacion(mensajeConfirmacion);

            if (confirma == DialogResult.Yes)
            {
                var resultado = _seleccionarMercaderiasModel
                    .ConfirmarSeleccion(long.Parse(osSeleccionada.Text));

                if (resultado.Exitoso)
                {
                    Alerta.MostrarInfo(resultado.Mensaje);
                    CargarFormulario();
                }
                else
                    Alerta.MostrarError(resultado.Mensaje);
            }

        }
    }

    #endregion
}
