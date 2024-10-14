using System.Globalization;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

public static class Validador
{
    public static string ValidarCampoVacio(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        return string.Empty;
    }

    public static string ValidarFecha(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        if (!DateTime.TryParseExact(
            texto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaValida
        ))
            return "La fecha debe ser el formato Dia/Mes/Año.";

        return string.Empty;
    }

    public static string ValidarCampoNumerico(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        if (!long.TryParse(texto, out long numero))
            return "El campo solo debe contener números.";

        if (numero <= 0)
            return "La valor ingresado debe ser mayor a 0.";

        return string.Empty;
    }

    public static string ValidarListadoCompleto(int cantidadItems)
    {
        if (cantidadItems == 0)
            return "El listado de mercaderías a retirar no puede estar vacío.";

        return string.Empty;
    }

    public static string ValidarDNI(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return "El campo no puede estar vacío.";

        if (!long.TryParse(texto, out long numero))
            return "El campo solo debe contener números.";

        if (numero <= 0)
            return "La valor ingresado debe ser mayor a 0.";

        const int caracteres = 8;
        if (numero.ToString().Length != caracteres)
            return $"El largo debe ser de {caracteres} caracteres.";

        return string.Empty;
    }

    public static List<string> ValidarControles(List<ErrorProvider> controlesDeError)
    {
        List<string> mensajes = new();
        for (int i = 0; i < controlesDeError.Count; i++)
        {
            if (controlesDeError[i] is not null)
            {
                Control? control = (Control?)controlesDeError[i].Tag;
                string err = controlesDeError[i].GetError(control);

                if (!string.IsNullOrEmpty(err))
                {
                    mensajes.Add($"{control.Tag}: {err}");
                }
            }
        }

        return mensajes;
    }
}