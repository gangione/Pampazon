namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Utilidades;

public static class Alerta
{
    public static DialogResult PedirConfirmacion(string mensaje)
    {
        return MessageBox.Show(
            mensaje,
            "¿Estás seguro?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
    }
    public static void MostrarError(string mensaje)
    {
        MessageBox.Show(
            mensaje,
            "Error!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
    public static void MostrarErrores(List<string> mensajes)
    {
        string mensaje = "Hay errores en los datos ingresados \n\n";
        mensajes.ForEach(error =>
        {
            mensaje += error + "\n";
        });

        MessageBox.Show(
            mensaje,
            "Error!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
    public static void MostrarInfo(string mensaje)
    {
        MessageBox.Show(
            mensaje,
            "Información!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
    public static void MostrarAdvertencia(string mensaje)
    {
        MessageBox.Show(
            mensaje,
            "Advertencia!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
    }
}