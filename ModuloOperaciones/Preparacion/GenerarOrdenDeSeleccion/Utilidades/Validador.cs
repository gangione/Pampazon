namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Utilidades;

public static class Validador
{
    public static string ValidarCampoVacio(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        return string.Empty;
    }

    public static string ValidarCuit(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        // Verificar que solo contenga números
        if (!long.TryParse(texto, out _))
            return "El CUIT solo debe contener números.";

        // Verificar que tenga exactamente 11 dígitos
        if (texto.Length != 11)
            return "El CUIT debe tener 11 dígitos.";

        // Si pasa las validaciones, se devuelve Empty
        return string.Empty;
    }

    public static string ValidarCampoNumerico(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        // Verificar que solo contenga números
        if (!long.TryParse(texto, out _))
            return "El campo solo debe contener números.";

        return string.Empty;
    }

    public static string ValidarFormatoImporte(string texto)
    {
        return string.Empty;
    }

    public static string ValidarListadoCompleto(int cantidadItems)
    {
        if (cantidadItems == 0)
            return "El listado no puede estar vacío.";

        return string.Empty;
    }

    public static List<string> ValidarControles(List<ErrorProvider> controlesDeError)
    {
        List<string> mensajes = new();
        foreach (var error in controlesDeError)
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
}