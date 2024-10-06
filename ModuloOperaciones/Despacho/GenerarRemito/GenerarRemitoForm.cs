namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public partial class GenerarRemitoForm : Form
{
    public GenerarRemitoForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Desea confirmar la baja de stock?");

        // Mostrar un MessageBox de confirmación
        DialogResult resultado = MessageBox.Show("¿Desea confirmar el despacho y la genereación del remito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // Evaluar la respuesta del usuario
        if (resultado == DialogResult.Yes)
        {
            // Aquí pones el código para confirmar la selección (por ejemplo, guardar los datos, procesar la orden, etc.)
            MessageBox.Show("Despacho y remito confirmado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Cancelar la operación
            MessageBox.Show("Despacho y remito cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
