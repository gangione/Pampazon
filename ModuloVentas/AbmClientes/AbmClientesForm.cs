using Pampazon.Entities;
using Pampazon.ModuloCompartido;
using Pampazon.ModuloVentas.Clientes;
using System.ComponentModel;

namespace Pampazon
{
    public partial class AbmClientesForm : Form
    {
        private AbmClientesModel _abmClienteModel;
        private List<ClienteEntity> _clientes;
        protected List<ErrorProvider> _errores;
        protected List<string> _mensajes;

        public AbmClientesForm()
        {
            InitializeComponent();
        }

        private void AbmClienteForm_Load(object sender, EventArgs e)
        {
            _abmClienteModel = new();
            _mensajes = new();
            CrearValidaciones();
            Iniciar();
        }

        private void Iniciar()
        {
            ActualizarListado();
            LimpiarFormulario();
            _mensajes.Clear();
        }

        #region Formulario - Datos Cliente
        private void LimpiarFormulario()
        {
            buttonGuardar.Enabled = true;
            buttonActualizar.Enabled = false;

            textBoxNumero.Enabled = true;

            textBoxNumero.Clear();
            textBoxCuit.Clear();
            textBoxNombre.Clear();
            textBoxCalleNumero.Clear();
            textBoxCiudad.Clear();
            textBoxProvincia.Clear();
            textBoxCodPostal.Clear();
        }

        private void CrearValidaciones()
        {
            // Numero
            textBoxNumero.Tag = labelNumero.Text;
            errorProviderNumero.Tag = textBoxNumero;

            // CUIT
            textBoxCuit.Tag = labelCuit.Text;
            errorProviderCuit.Tag = textBoxCuit;

            // Nombre
            textBoxNombre.Tag = labelNombre.Text;
            errorProviderNombre.Tag = textBoxNombre;

            _errores = [
                errorProviderNumero,
                errorProviderCuit,
                errorProviderNombre,
                //errorProviderCalleNumero,
                //errorProviderCiudad,
                //errorProviderProvincia,
                //errorProviderCodPostal
            ];
        }

        protected List<string> ValidarFormulario()
        {
            _mensajes.Clear();
            ValidateChildren();

            foreach (var error in _errores)
            {
                Control control = (Control)error.Tag;
                string err = error.GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    _mensajes.Add($"{control.Tag}: {err}");
                }
            };
            return _mensajes;
        }
        #endregion

        #region Listado

        private void ActualizarListado()
        {
            _clientes = _abmClienteModel.ObtenerTodos();
            listViewCliente.Items.Clear();
            listViewCliente.Items.AddRange(ObtenerListViewClientes(_clientes));
        }
        private static ListViewItem[] ObtenerListViewClientes(List<ClienteEntity> clientes)
        {
            List<ListViewItem> viewItems = new();
            foreach (var cliente in clientes)
            {
                ListViewItem item = new(cliente.Numero.ToString());
                item.SubItems.Add(cliente.Cuit);
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Domicilio?.CalleNumero);
                item.SubItems.Add(cliente.Domicilio?.Departamento);
                item.SubItems.Add(cliente.Domicilio?.Ciudad);
                item.SubItems.Add(cliente.Domicilio?.Provincia);
                item.SubItems.Add(cliente.Domicilio?.CodigoPostal);
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        #endregion

        #region Eventos
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea guardar el cliente?");

            if (confirmacion == DialogResult.No)
                return;

            List<string> erroresValidacion = ValidarFormulario();
            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            Resultado<ClienteEntity> resultado = _abmClienteModel.Guardar(
                new ClienteEntity()
                {
                    Numero = long.Parse(textBoxNumero.Text),
                    Cuit = textBoxCuit.Text,
                    Nombre = textBoxNombre.Text,
                    Domicilio = new DomicilioEntity()
                    {
                        CalleNumero = textBoxCalleNumero.Text,
                        Departamento = textBoxDepto.Text,
                        Ciudad = textBoxCiudad.Text,
                        Provincia = textBoxProvincia.Text,
                        CodigoPostal = textBoxCodPostal.Text,
                    }
                }
            );

            if (!resultado.Exitoso)
                Alerta.MostrarError(resultado.Mensaje);
            else
            {
                Alerta.MostrarInfo(resultado.Mensaje);
                Iniciar();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea limpiar el formulario?");

            if (confirmacion == DialogResult.No)
                return;

            LimpiarFormulario();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea eliminar el cliente?");

            if (confirmacion == DialogResult.No)
                return;

            if (listViewCliente.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem selectedCliente = listViewCliente.SelectedItems[0];

                // Obtener el CUIT o el identificador del cliente desde la primera columna
                Resultado<ClienteEntity> resultado = _abmClienteModel.Eliminar(
                    new ClienteEntity()
                    {
                        Numero = long.Parse(selectedCliente.SubItems[0].Text),
                        Cuit = selectedCliente.SubItems[1].Text
                    }
                );

                if (!resultado.Exitoso)
                    Alerta.MostrarError(resultado.Mensaje);
                else
                {
                    Alerta.MostrarInfo(resultado.Mensaje);
                    Iniciar();
                }
            }
            else
                Alerta.MostrarAdvertencia("Debe seleccionar un cliente.");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listViewCliente.SelectedItems.Count > 0)
            {
                buttonGuardar.Enabled = false;
                buttonActualizar.Enabled = true;

                // Obtener el elemento seleccionado
                ListViewItem selectedCliente = listViewCliente.SelectedItems[0];

                textBoxNumero.Text = selectedCliente.SubItems[0].Text;
                textBoxNumero.Enabled = false;
                textBoxCuit.Text = selectedCliente.SubItems[1].Text;
                textBoxNombre.Text = selectedCliente.SubItems[2].Text;
                textBoxCalleNumero.Text = selectedCliente.SubItems[3].Text;
                textBoxDepto.Text = selectedCliente.SubItems[4].Text;
                textBoxCiudad.Text = selectedCliente.SubItems[5].Text;
                textBoxProvincia.Text = selectedCliente.SubItems[6].Text;
                textBoxCodPostal.Text = selectedCliente.SubItems[7].Text;
            }
            else
                Alerta.MostrarAdvertencia("Debe seleccionar un cliente.");
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea actualizar el cliente?");

            if (confirmacion == DialogResult.No)
                return;

            List<string> erroresValidacion = ValidarFormulario();
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

            Resultado<ClienteEntity> resultado = _abmClienteModel.Actualizar(
                new ClienteEntity()
                {
                    Numero = long.Parse(textBoxNumero.Text),
                    Cuit = textBoxCuit.Text,
                    Nombre = textBoxNombre.Text,
                    Domicilio = new DomicilioEntity()
                    {
                        CalleNumero = textBoxCalleNumero.Text,
                        Departamento = textBoxDepto.Text,
                        Ciudad = textBoxCiudad.Text,
                        Provincia = textBoxProvincia.Text,
                        CodigoPostal = textBoxCodPostal.Text,
                    }
                }
            );

            if (!resultado.Exitoso)
                Alerta.MostrarError(resultado.Mensaje);
            else
            {
                Alerta.MostrarInfo(resultado.Mensaje);
                Iniciar();
            }
        }
        private void textBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoNumerico(textBoxNumero.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderNumero.SetError(textBoxNumero, validacion);
            else
                errorProviderNumero.SetError(textBoxNumero, "");
        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxNombre.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderNombre.SetError(textBoxNombre, validacion);
            else
                errorProviderNombre.SetError(textBoxNombre, "");
        }

        private void textBoxCuit_Validating(object sender, CancelEventArgs e)
        {
            string validacion = Validador.ValidarCuit(textBoxCuit.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderCuit.SetError(textBoxCuit, validacion);
            else
                errorProviderCuit.SetError(textBoxCuit, "");
        }

        #endregion
    }
}