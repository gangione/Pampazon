using Pampazon.InicioSesion.Dtos;
using Pampazon.InicioSesion.Utilidades;
using Pampazon.MenuInicio;

namespace Pampazon.InicioSesion
{
    public partial class IniciarSesionForm : Form
    {
        private IniciarSesionModel _iniciarSesionModel;
        public IniciarSesionForm()
        {
            InitializeComponent();
        }
        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {
            _iniciarSesionModel = new();
            CrearValidaciones();
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
        }

        protected List<string> ValidarFormulario()
        {
            string usuario = Validador.ValidarCampoVacio(textBoxUsuario.Text);

            if (!string.IsNullOrEmpty(usuario))
                errorProviderUsuario.SetError(textBoxUsuario, usuario);
            else
                errorProviderUsuario.SetError(textBoxUsuario, "");

            string password = Validador.ValidarCampoVacio(textBoxContrasenia.Text);

            if (!string.IsNullOrEmpty(password))
                errorProviderContrasenia.SetError(textBoxContrasenia, password);
            else
                errorProviderContrasenia.SetError(textBoxContrasenia, "");

            List<ErrorProvider> errores = new()
            {
                errorProviderUsuario,
                errorProviderContrasenia
            };

            ValidateChildren();

            List<string> mensajes =
            [
                .. Validador.ValidarControles(errores),
            ];

            return mensajes;
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

            Resultado<Usuario?> resultado = _iniciarSesionModel.ValidarCredenciales(
                username, pw
            );

            if (!resultado.Exitoso)
            {
                Alerta.MostrarError(resultado.Mensaje);
                return;
            }

            MenuInicioForm menuForm = new();
            menuForm.ShowDialog();
        }

        #endregion
    }
}