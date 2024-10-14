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
        comboBoxBuscarPorPrioridad.Items.AddRange(Enum.GetNames(typeof(Prioridad)));

        CargarListadoOrdenesPendientes();
        listViewMercaderiasASeleccionar.Items.Clear();
    }

    #endregion

    #region Filtros

    #endregion

    #region Ordenes de Seleccion Pendientes
    private void CargarListadoOrdenesPendientes()
    {
        listViewOrdenesDeSeleccionPendientes.Items.Clear();
        var ordenesPendientes = _seleccionarMercaderiasModel
            .ObtenerOrdenesDeSeleccionPendiente();

        listViewOrdenesDeSeleccionPendientes.Items.AddRange(ObtenerListViewOrdenesDePreparacion(ordenesPendientes));
    }

    private static ListViewItem[] ObtenerListViewOrdenesDePreparacion(List<OrdenDeSeleccion> ordenes)
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
            var ordenDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenDeSeleccionPorNumero(long.Parse(osSeleccionada.Text));

            listViewMercaderiasASeleccionar.Items
                .AddRange(ObtenerListViewDetalleDeOrdenDeSeleccion(ordenDeSeleccion));
        }
        else
        {
            listViewMercaderiasASeleccionar.Items.Clear();
        }

    }

    private static ListViewItem[] ObtenerListViewDetalleDeOrdenDeSeleccion(OrdenDeSeleccion ordenDeSeleccion)
    {
        List<ListViewItem> viewItems = new();
        ordenDeSeleccion.OrdenesDePreparacion.ForEach(op =>
        {
            op.MercaderiasAPreparar?.ForEach(m =>
            {
                ListViewItem item = new(m.Ubicacion.ToString());
                item.SubItems.Add(m.SKU);
                item.SubItems.Add(m.Descripcion);
                item.SubItems.Add(m.Cantidad.ToString());
                item.SubItems.Add(op.Numero.ToString());
                viewItems.Add(item);
            });
        });
        return viewItems.ToArray();
    }

    #endregion

    #region Eventos
    private void SeleccionarMercaderiasForm_Load(object sender, EventArgs e)
    {
        CargarFormulario();
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
            var ordenDeSeleccion = _seleccionarMercaderiasModel
                .ObtenerOrdenDeSeleccionPorNumero(long.Parse(osSeleccionada.Text));


            List<Mercaderia> mercaderias = new();
            ordenDeSeleccion.OrdenesDePreparacion.ForEach(op =>
            {
                mercaderias.AddRange(op.MercaderiasAPreparar);
            });

            string mensajeConfirmacion = "¿Confirma la selección de las siguientes mercaderías?\n\n";
            for (int i = 0; i < mercaderias.Count; i++)
            {
                mensajeConfirmacion += $"{mercaderias[i].Cantidad} de {mercaderias[i].Descripcion}\n";
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
