using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Utilidades;
using Pampazon.ModuloOperaciones.Recepcion.RecibirMercaderia;
using System.ComponentModel;

namespace Pampazon.ModuloOperaciones.Recepcion.RecepcionMercaderia
{
    public partial class RecepcionarMercaderiaForm : Form
    {
        private RecepcionarMercaderiaModel _recepcionModel;
        private List<Cliente> _clientes;
        private List<Transportista> _transportistas;
        private List<Mercaderia> _mercaderias;
        private Dictionary<string, ErrorProvider> _errores;
        public RecepcionarMercaderiaForm()
        {
            InitializeComponent();
        }

        private void Iniciar()
        {
            CargarListado();
            CargarFormulario();
        }

        #region Formulario
        private void CargarFormulario()
        {
            _clientes = _recepcionModel.ObtenerClientes();
            _transportistas = _recepcionModel.ObtenerTransportistas();

            textBoxCliente.Clear();
            textBoxRemito.Clear();
            textBoxDNITransportista.Clear();
            textBoxNombreTransportista.Clear();
            textBoxDescripcionMercaderia.Clear();
            textBoxUMMercaderia.Clear();
            textBoxCantidadMercaderia.Clear();

            CrearValidadores();
            ConfigurarAutocompleteClientes();
            ConfigurarAutocompleteTransportistas();
            DeshabilitarNotaDeEspacio();
        }

        private void CrearValidadores()
        {
            _errores = new();
            // Cliente
            textBoxCliente.Tag = labelCliente.Text;
            errorProviderCliente.Tag = textBoxCliente;

            textBoxRemito.Tag = labelRemito.Text;
            errorProviderNroRemito.Tag = textBoxRemito;

            _errores.Add("Cliente", errorProviderCliente);
            _errores.Add("ClienteRemito", errorProviderNroRemito);

            // Transportista
            textBoxDNITransportista.Tag = labelDNITransportista.Text;
            errorProviderDNITransportista.Tag = textBoxDNITransportista;

            textBoxNombreTransportista.Tag = labelNombreTransportista.Text;
            errorProviderNombreTransportista.Tag = textBoxNombreTransportista;

            _errores.Add("TransportistaDNI", errorProviderDNITransportista);
            _errores.Add("TransportistaNombre", errorProviderNombreTransportista);

            // Mercaderias
            textBoxDescripcionMercaderia.Tag = labelDescripcionMercaderia.Text;
            errorProviderDescripcionMercaderia.Tag = textBoxDescripcionMercaderia;

            textBoxUMMercaderia.Tag = labelUMMercaderia.Text;
            errorProviderUMMercaderia.Tag = textBoxUMMercaderia;

            textBoxCantidadMercaderia.Tag = labelCantidadMercaderia.Text;
            errorProviderCantidadMercaderia.Tag = textBoxCantidadMercaderia;

            textBoxCantidadRechazada.Tag = labelCantidadRechazada.Text;
            errorProviderCantidadRechazada.Tag = textBoxCantidadRechazada;

            _errores.Add("MercaderiaDescripcion", errorProviderDescripcionMercaderia);
            _errores.Add("MercaderiaUM", errorProviderUMMercaderia);
            _errores.Add("MercaderiaCantidad", errorProviderCantidadMercaderia);
            _errores.Add("MercaderiaCantidadRechazada", errorProviderCantidadRechazada);
        }

        private List<string> ValidarFormularioMercaderias()
        {
            List<ErrorProvider> errores = new()
            {
                _errores.GetValueOrDefault("MercaderiaDescripcion"),
                _errores.GetValueOrDefault("MercaderiaUM"),
                _errores.GetValueOrDefault("MercaderiaCantidad"),
            };

            if (textBoxCantidadRechazada.Enabled)
                errores.Add(_errores
                    .GetValueOrDefault("MercaderiaCantidadRechazada"));

            ValidateChildren();

            List<string> mensajes = Validador.ValidarControles(errores);

            return mensajes;
        }

        private List<string> ValidarFormularioOrdenDeRecepcion()
        {
            List<ErrorProvider> errores = new()
            {
                _errores.GetValueOrDefault("Cliente"),
                _errores.GetValueOrDefault("ClienteRemito"),
                _errores.GetValueOrDefault("TransportistaDNI"),
                _errores.GetValueOrDefault("TransportistaNombre")
            };

            ValidateChildren();

            if (_mercaderias.Count > 0)
            {
                errorProviderDescripcionMercaderia.SetError(textBoxDescripcionMercaderia, "");
                errorProviderCantidadMercaderia.SetError(textBoxCantidadMercaderia, "");
            }

            List<string> mensajes = Validador.ValidarControles(errores);

            return mensajes;
        }

        private void DeshabilitarNotaDeEspacio()
        {
            groupBoxNotaEspacio.Hide();
            radioButtonTotal.Checked = false;
            radioButtonParcial.Checked = false;
            MostrarCantidadRechazada(false);
        }

        private void HabilitarNotaDeEspacio()
        {
            groupBoxNotaEspacio.Show();
            MostrarCantidadRechazada(false);
        }

        private void MostrarCantidadRechazada(bool mostrar)
        {
            if (mostrar)
                listViewMercaderias.Columns.Add(columnHeaderCantidadRechazada);
            else
                listViewMercaderias.Columns.Remove(columnHeaderCantidadRechazada);

            labelCantidadRechazada.Visible = mostrar;
            textBoxCantidadRechazada.Visible = mostrar;
            textBoxCantidadRechazada.Enabled = mostrar;
        }
        #endregion

        #region Listado
        private void CargarListado()
        {
            _mercaderias = new();
            listViewMercaderias.Items.Clear();
            listViewMercaderias.Items.AddRange(ObtenerListViewMercaderias(_mercaderias));
            listViewMercaderias.Columns.Remove(columnHeaderCantidadRechazada);
        }

        private static ListViewItem[] ObtenerListViewMercaderias(List<Mercaderia> mercaderias)
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

        private void AgregarItemMercaderia(Mercaderia mercaderia, string cantidadRechazada)
        {
            ListViewItem item = new(mercaderia.Descripcion);
            item.SubItems.Add(mercaderia.UnidadDeMedida.ToString());
            item.SubItems.Add(mercaderia.Cantidad.ToString());
            item.SubItems.Add(cantidadRechazada);
            listViewMercaderias.Items.Add(item);
            _mercaderias.Add(mercaderia);
        }

        private void EliminarItemsMercaderia()
        {
            var mercaderias = listViewMercaderias.SelectedItems;
            for (int i = 0; i < mercaderias.Count; i++)
            {
                Mercaderia? mercaderia = _mercaderias
                    .Find(m => m.Descripcion == mercaderias[i].Text);

                _mercaderias.Remove(mercaderia);
                listViewMercaderias.Items.RemoveAt(mercaderias[i].Index);
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
        private void RecepcionarMercaderiaForm_Load(object sender, EventArgs e)
        {
            _recepcionModel = new();
            Iniciar();
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            _clientes = _recepcionModel.ObtenerClientesPorFiltro(textBoxCliente.Text);
        }

        private void textBoxNombreTransportista_TextChanged(object sender, EventArgs e)
        {
            _transportistas = _recepcionModel
                .ObtenerTransportistasPorFiltro(textBoxNombreTransportista.Text);
        }

        private void textBoxDescripcionMercaderia_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxDescripcionMercaderia.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderDescripcionMercaderia.SetError(textBoxDescripcionMercaderia, validacion);
            else
                errorProviderDescripcionMercaderia.SetError(textBoxDescripcionMercaderia, "");
        }

        private void textBoxCantidadMercaderia_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoNumerico(textBoxCantidadMercaderia.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderCantidadMercaderia.SetError(textBoxCantidadMercaderia, validacion);
            else
                errorProviderCantidadMercaderia.SetError(textBoxCantidadMercaderia, "");
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            List<string> erroresValidacion = ValidarFormularioMercaderias();
            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            AgregarItemMercaderia(new Mercaderia()
            {
                Descripcion = textBoxDescripcionMercaderia.Text,
                //UnidadDeMedida = textBoxUMMercaderia.Text,
                Cantidad = int.Parse(textBoxCantidadMercaderia.Text),
            }, textBoxCantidadRechazada.Text);

            textBoxDescripcionMercaderia.Clear();
            textBoxUMMercaderia.Clear();
            textBoxCantidadMercaderia.Clear();
            textBoxCantidadRechazada.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarItemsMercaderia();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewMercaderias.SelectedItems[0];
                textBoxDescripcionMercaderia.Text = selected.SubItems[0].Text;
                textBoxUMMercaderia.Text = selected.SubItems[1].Text;
                textBoxCantidadMercaderia.Text = selected.SubItems[2].Text;
                textBoxCantidadRechazada.Text = selected.SubItems[3].Text;

                var mercaderia = _mercaderias
                    .Find(m => m.Descripcion == selected.SubItems[0].Text);

                _mercaderias.Remove(mercaderia);
                listViewMercaderias.SelectedItems[0].Remove();
            }
            else
                Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
        }
        private void radioButtonTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTotal.Checked)
            {
                if (!listViewMercaderias.Columns.Contains(columnHeaderCantidadRechazada))
                    MostrarCantidadRechazada(true);

                for (int i = 0; i < listViewMercaderias.Items.Count; i++)
                {
                    var item = listViewMercaderias.Items[i];

                    if (item.SubItems[2].Text != "0")
                    {
                        item.SubItems[3].Text = item.SubItems[2].Text;
                        item.SubItems[2].Text = "0";
                    }
                }
            }
        }

        private void radioButtonParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParcial.Checked)
            {
                if (!listViewMercaderias.Columns.Contains(columnHeaderCantidadRechazada))
                    MostrarCantidadRechazada(true);

                Alerta.MostrarAdvertencia(
                    "Debe completar la cantidad rechazada de cada Mercadería en la lista."
                );
            }
        }

        private void buttonGenerarNotaInsuficiente_Click(object sender, EventArgs e)
        {
            //_recepcionModel.GenerarNotaEspacioInsuficiente();

        }

        private void buttonGenerarOrdenYComprobantes_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta
                .PedirConfirmacion("Desea guardar la recepción de mercaderías?");

            if (confirmacion == DialogResult.No)
                return;

            List<string> erroresValidacion = new();

            string listaCompletaError = Validador
                .ValidarListadoCompleto(listViewMercaderias.Items.Count);

            if (listaCompletaError != string.Empty)
                erroresValidacion.Add(listaCompletaError);

            erroresValidacion.AddRange(ValidarFormularioOrdenDeRecepcion());

            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            ComprobanteDeRecepcion comprobante = new()
            {
                NumeroRemito = long.Parse(textBoxRemito.Text),
                Cliente = _clientes.First(),
                Transportista = _transportistas.First(),
                MercaderiasRecibidas = _mercaderias,
                Observaciones = textBoxObservaciones.Text
            };

            Resultado<ComprobanteDeRecepcion> resultado = _recepcionModel
                .GenerarComprobanteDeRecepcion(comprobante);

            if (!resultado.Exitoso)
            {
                Alerta.MostrarError(resultado.Mensaje);
                HabilitarNotaDeEspacio();
            }
            else
            {
                Alerta.MostrarInfo(resultado.Mensaje);
            }
        }

        private void buttonRestablecer_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void textBoxCliente_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxCliente.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderCliente.SetError(textBoxCliente, validacion);
            else
                errorProviderCliente.SetError(textBoxCliente, "");
        }

        private void textBoxRemito_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoNumerico(textBoxRemito.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderNroRemito.SetError(textBoxRemito, validacion);
            else
                errorProviderNroRemito.SetError(textBoxRemito, "");
        }

        private void textBoxNombreTransportista_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxNombreTransportista.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderNombreTransportista.SetError(textBoxNombreTransportista, validacion);
            else
                errorProviderNombreTransportista.SetError(textBoxNombreTransportista, "");
        }

        private void textBoxDNITransportista_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoNumerico(textBoxDNITransportista.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderDNITransportista.SetError(textBoxDNITransportista, validacion);
            else
                errorProviderDNITransportista.SetError(textBoxDNITransportista, "");
        }

        private void textBoxCantidadRechazada_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoNumerico(textBoxCantidadRechazada.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderCantidadRechazada.SetError(textBoxCantidadRechazada, validacion);
            else
                errorProviderCantidadRechazada.SetError(textBoxCantidadRechazada, "");
        }
        #endregion
    }
}