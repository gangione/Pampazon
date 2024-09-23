using Pampazon.Entities;
using Pampazon.MenuInicio;
using Pampazon.ModuloCompartido;
using Pampazon.ModuloInicioSesion;

namespace Pampazon
{
    public partial class IniciarSesionForm : Form
    {
        private IniciarSesionModel _iniciarSesionModel;
        private List<ErrorProvider> _errores;
        private List<string> _mensajes;
        public IniciarSesionForm()
        {
            InitializeComponent();
        }
        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {
            _iniciarSesionModel = new();
            _mensajes = new();
            CrearValidaciones();
            _mensajes.Clear();
        }

        #region Formulario - Datos Usuario

        private void CrearValidaciones()
        {
            // Usuario
            textBoxUsuario.Tag = labelUsuario.Text;
            errorProviderUsuario.Tag = textBoxUsuario;

            // Contrasenia
            textBoxContrasenia.Tag = labelContrasenia.Text;
            errorProviderContrasenia.Tag = textBoxContrasenia;

            _errores = [
                errorProviderUsuario,
                errorProviderContrasenia
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

        #region Eventos
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            List<string> erroresValidacion = ValidarFormulario();
            if (erroresValidacion.Count > 0)
            {
                Alerta.MostrarErrores(erroresValidacion);
                return;
            }

            // Validar con el modelo el usuario y contraseña
            string username = textBoxUsuario.Text;
            string pw = textBoxContrasenia.Text;

            Resultado<UsuarioEntity?> resultado = _iniciarSesionModel.ValidarCredenciales(
                username, pw
            );

            if (!resultado.Exitoso)
            {
                Alerta.MostrarError(resultado.Mensaje);
                return;
            }

            MenuInicioForm menuForm = new(resultado.Datos);
            menuForm.ShowDialog();
        }

        private void textBoxUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxUsuario.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderUsuario.SetError(textBoxUsuario, validacion);
            else
                errorProviderUsuario.SetError(textBoxUsuario, "");
        }

        private void textBoxContrasenia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string validacion = Validador.ValidarCampoVacio(textBoxContrasenia.Text);

            if (!string.IsNullOrEmpty(validacion))
                errorProviderContrasenia.SetError(textBoxContrasenia, validacion);
            else
                errorProviderContrasenia.SetError(textBoxContrasenia, "");
        }

        #endregion
    }
}