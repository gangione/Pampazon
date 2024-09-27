using Pampazon.Entities;
using Pampazon.ModuloCompartido;
using Pampazon.ModuloOperaciones.Recepcion.RecibirMercaderia;
using System.ComponentModel;

namespace Pampazon.ModuloOperaciones.Descarga.RecepcionMercaderia
{
    public partial class RecepcionarMercaderiaForm : Form
    {
        private RecepcionarMercaderiaModel _recepcionModel;
        private List<ClienteEntity> _clientes;
        private List<MercaderiaEntity> _mercaderias;
        protected Dictionary<string, ErrorProvider> _errores;
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

            textBoxCliente.Clear();
            textBoxRemito.Clear();
            textBoxDNITransportista.Clear();
            textBoxNombreTransportista.Clear();
            textBoxDescripcionMercaderia.Clear();
            textBoxUMMercaderia.Clear();
            textBoxCantidadMercaderia.Clear();

            CrearValidadores();
            ConfigurarAutocompleteClientes();
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

            textBoxNombreTransportista.Tag = labelNombreTransportista;
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

            _errores.Add("MercaderiaDescripcion", errorProviderDescripcionMercaderia);
            _errores.Add("MercaderiaUM", errorProviderUMMercaderia);
            _errores.Add("MercaderiaCantidad", errorProviderCantidadMercaderia);
        }

        private List<string> ValidarFormularioMercaderias()
        {
            List<string> mensajes = new();

            List<ErrorProvider> errores = new()
            {
                _errores.GetValueOrDefault("MercaderiaDescripcion"),
                _errores.GetValueOrDefault("MercaderiaUM"),
                _errores.GetValueOrDefault("MercaderiaCantidad")
            };

            ValidateChildren();

            foreach (var error in errores)
            {
                Control control = (Control)error.Tag;
                string err = error.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    mensajes.Add($"{control.Tag}: {err}");
                }
            };

            return mensajes;
        }

        private List<string> ValidarFormularioOrdenDeRecepcion()
        {
            List<string> mensajes = new();

            List<ErrorProvider> errores = new()
            {
                _errores.GetValueOrDefault("Cliente"),
                _errores.GetValueOrDefault("ClienteRemito"),
                _errores.GetValueOrDefault("TransportistaDNI"),
                _errores.GetValueOrDefault("TransportistaNombre")
            };

            ValidateChildren();

            foreach (var error in errores)
            {
                Control control = (Control)error.Tag;
                string err = error.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    mensajes.Add($"{control.Tag}: {err}");
                }
            };

            return mensajes;
        }

        private void DeshabilitarNotaDeEspacio()
        {
            groupBoxNotaEspacio.Hide();
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

            radioButtonTotal.Checked = !mostrar;
            radioButtonParcial.Checked = mostrar;

            labelCantidadRechazada.Visible = mostrar;
            textBoxCantidadRechazada.Visible = mostrar;
            textBoxCantidadRechazada.Enabled = mostrar;

            buttonActualizar.Visible = mostrar;
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

        private static ListViewItem[] ObtenerListViewMercaderias(List<MercaderiaEntity> mercaderias)
        {
            List<ListViewItem> viewItems = new();
            for (int i = 0; i < mercaderias.Count; i++)
            {
                ListViewItem item = new(mercaderias[i].Descripcion);
                item.SubItems.Add(mercaderias[i].UnidadDeMedida);
                item.SubItems.Add(mercaderias[i].Cantidad.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        private void AgregarItemMercaderia(MercaderiaEntity mercaderia)
        {
            ListViewItem item = new(mercaderia.Descripcion);
            item.SubItems.Add(mercaderia.UnidadDeMedida);
            item.SubItems.Add(mercaderia.Cantidad.ToString());
            item.SubItems.Add("");
            listViewMercaderias.Items.Add(item);
        }

        private void EliminarItemsMercaderia()
        {
            var mercaderias = listViewMercaderias.SelectedItems;
            for (int i = 0; i < mercaderias.Count; i++)
            {
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

        #endregion

        #region Eventos
        private void RecepcionarMercaderiaForm_Load(object sender, EventArgs e)
        {
            _recepcionModel = new();
            Iniciar();
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            _clientes = _recepcionModel.ObtenerClientesPorFiltro(textBoxObservaciones.Text);
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
                string mensaje = "Hay errores en los datos ingresados \n\n";
                erroresValidacion.ForEach(error =>
                {
                    mensaje += error + "\n";
                });

                Alerta.MostrarError(mensaje);

                return;
            }

            AgregarItemMercaderia(new MercaderiaEntity()
            {
                //NumeroCliente = long.Parse(textBoxCliente.Text),
                Descripcion = textBoxDescripcionMercaderia.Text,
                UnidadDeMedida = textBoxUMMercaderia.Text,
                Cantidad = long.Parse(textBoxCantidadMercaderia.Text),
            });
            textBoxDescripcionMercaderia.Clear();
            textBoxUMMercaderia.Clear();
            textBoxCantidadMercaderia.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarItemsMercaderia();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (listViewMercaderias.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewMercaderias.SelectedItems[0];
                selected.SubItems[3].Text = textBoxCantidadRechazada.Text;
                textBoxCantidadRechazada.Clear();
            }
            else
                Alerta.MostrarAdvertencia("Debe seleccionar una mercadería.");
        }

        private void radioButtonParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonParcial.Checked)
            {
                MostrarCantidadRechazada(true);
                Alerta.MostrarAdvertencia(
                    "Debe completar la cantidad rechazada de cada Mercadería en la lista."
                );
            }
            else MostrarCantidadRechazada(false);
        }

        private void buttonGenerarNotaInsuficiente_Click(object sender, EventArgs e)
        {
            _recepcionModel.GenerarNotaEspacioInsuficiente();

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

            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            Resultado<bool> resultado = _recepcionModel.ComprobarEspacioCliente();

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
        #endregion
    }
}