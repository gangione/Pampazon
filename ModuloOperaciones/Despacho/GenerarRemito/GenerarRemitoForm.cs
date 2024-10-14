using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public partial class GenerarRemitoForm : Form
{
    private GenerarRemitoModel _generarRemitoModel;
    public GenerarRemitoForm()
    {
        _generarRemitoModel = new();
        InitializeComponent();
    }

    #region Eventos
    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {
        DialogResult resultado = Alerta.PedirConfirmacion("¿Desea confirmar el despacho y la genereación del remito?");

        if (resultado == DialogResult.Yes)
        {
            Alerta.MostrarInfo("Despacho y remito confirmado.");

            //List<string> errores = ValidarFormularioRemito();

            //if (errores.Count > 0)
            //{
            //    Alerta.MostrarErrores(errores);
            //    return;
            //}

            //var resultado = _generarRemitoModel.DespacharOrdenesDePreparacion();

            //if (resultado.Exitoso)
            //{
            //    Alerta.MostrarInfo(resultado.Mensaje);
            //    CargarFormulario();
            //}
            //else
            //    Alerta.MostrarError(resultado.Mensaje);
        }
    }

    #endregion
}