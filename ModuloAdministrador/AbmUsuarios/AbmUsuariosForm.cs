﻿using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloCompartido;
using System.ComponentModel;

namespace Pampazon.ModuloUsuarios.AbmUsuarios
{
    public partial class AbmUsuariosForm : Form
    {
        private AbmUsuariosModel _abmUsuarioModel;
        private List<UsuarioEntity> _usuarios;
        protected List<ErrorProvider> _errores;
        protected List<string> _mensajes;
        public AbmUsuariosForm()
        {
            InitializeComponent();
        }

        private void AbmUsuariosForm_Load(object sender, EventArgs e)
        {
            _abmUsuarioModel = new();
            _mensajes = new();
            comboBoxRol.Items.AddRange(Enum.GetNames(typeof(Rol)));

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
            buttonActualizar.Enabled = false;
            buttonGuardar.Enabled = true;

            textBoxNumero.Enabled = true;
            textBoxNombre.Enabled = true;

            textBoxNumero.Clear();
            textBoxNombre.Clear();
            textBoxContrasenia.Clear();
            comboBoxRol.SelectedIndex = 0;
        }

        private void CrearValidaciones()
        {
            // Numero
            textBoxNumero.Tag = labelNumero.Text;
            errorProviderNumero.Tag = textBoxNumero;


            // Nombre
            textBoxNombre.Tag = labelNombre.Text;
            errorProviderNombre.Tag = textBoxNombre;

            // Contrasenia
            textBoxContrasenia.Tag = labelContrasenia.Text;
            errorProviderContrasenia.Tag = textBoxContrasenia;

            // Rol
            comboBoxRol.Text = labelRol.Text;
            errorProviderRol.Tag = comboBoxRol;

            _errores = [
                errorProviderNumero,
                errorProviderNombre,
                errorProviderContrasenia,
                errorProviderRol
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
            _usuarios = _abmUsuarioModel.ObtenerTodos();
            listViewCliente.Items.Clear();
            listViewCliente.Items.AddRange(ObtenerListViewUsuarios(_usuarios));
        }
        private static ListViewItem[] ObtenerListViewUsuarios(List<UsuarioEntity> usuarios)
        {
            List<ListViewItem> viewItems = new();
            foreach (var usuario in usuarios)
            {
                ListViewItem item = new(usuario.Numero.ToString());
                item.SubItems.Add(usuario.Usuario);
                item.SubItems.Add(usuario.Contrasenia);
                item.SubItems.Add(usuario.Rol.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        #endregion

        #region Eventos
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea guardar el usuario?");

            if (confirmacion == DialogResult.No)
                return;

            List<string> erroresValidacion = ValidarFormulario();
            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            Resultado<UsuarioEntity> resultado = _abmUsuarioModel.Guardar(
                new UsuarioEntity()
                {
                    Numero = long.Parse(textBoxNumero.Text),
                    Usuario = textBoxNombre.Text,
                    Contrasenia = textBoxContrasenia.Text,
                    Rol = (Rol)Enum.Parse(typeof(Rol), comboBoxRol.SelectedItem.ToString())
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
            DialogResult confirmacion = Alerta.PedirConfirmacion("Desea eliminar el usuario?");

            if (confirmacion == DialogResult.No)
                return;

            if (listViewCliente.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem selectedCliente = listViewCliente.SelectedItems[0];

                Resultado<UsuarioEntity> resultado = _abmUsuarioModel.Eliminar(
                    new UsuarioEntity()
                    {
                        Numero = long.Parse(selectedCliente.SubItems[0].Text),
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
                Alerta.MostrarAdvertencia("Debe seleccionar un usuario.");
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
                textBoxNombre.Text = selectedCliente.SubItems[1].Text;
                textBoxNombre.Enabled = false;
                textBoxContrasenia.Text = selectedCliente.SubItems[2].Text;

                // Obtener el valor del Rol desde el ListView
                string rolTexto = selectedCliente.SubItems[3].Text;

                // Convertir el texto en el valor correspondiente del enum
                Rol rolSeleccionado = (Rol)Enum.Parse(typeof(Rol), rolTexto);

                // Asignar el valor del enum al ComboBox
                comboBoxRol.SelectedItem = rolSeleccionado.ToString();
            }
            else
                Alerta.MostrarAdvertencia("Debe seleccionar un usuario.");
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

            Resultado<UsuarioEntity> resultado = _abmUsuarioModel.Actualizar(
                new UsuarioEntity()
                {
                    Numero = long.Parse(textBoxNumero.Text),
                    Usuario = textBoxNombre.Text,
                    Contrasenia = textBoxContrasenia.Text,
                    Rol = (Rol)Enum.Parse(typeof(Rol), comboBoxRol.SelectedItem.ToString())
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

        #endregion
    }
}
