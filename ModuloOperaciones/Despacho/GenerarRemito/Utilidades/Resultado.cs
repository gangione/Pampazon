namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

public class Resultado<T>
{
    public bool Exitoso { get; private set; }
    public string Mensaje { get; private set; }
    public T? Datos { get; private set; }
    public Resultado(bool esExitoso, string mensaje, T? datos)
    {
        Exitoso = esExitoso;
        Mensaje = mensaje;
        Datos = datos;
    }
}
