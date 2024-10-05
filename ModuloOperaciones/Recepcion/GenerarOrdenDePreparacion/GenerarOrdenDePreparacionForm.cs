using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloOperaciones.Descarga.IngresarOrdenDePreparacion;
public partial class GenerarOrdenDePreparacionForm : Form
{
    public GenerarOrdenDePreparacionForm()
    {
        InitializeComponent();
    }

    private void groupBoxOrdenDePreparacion_Enter(object sender, EventArgs e)
    {

    }

    private void buttonEditar_Click(object sender, EventArgs e)
    {

    }

    private void GenerarOrdenDePreparacionForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Alerta.PedirConfirmacion("Se perderán los datos ingresados.");
    }
}
