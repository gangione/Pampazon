using System.Text.Json;

namespace Pampazon.Almacenes;
public static class OrdenDeSeleccionAlmacen
{
    private static List<OrdenDeSeleccionEnt> ordenesSeleccion = [];

    public static IReadOnlyCollection<OrdenDeSeleccionEnt> OrdenesSeleccion => ordenesSeleccion.AsReadOnly();

    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(ordenesSeleccion);
        File.WriteAllText("OrdenesDeSeleccion.json", datos);
    }

    public static void Leer()
    {
        if (!File.Exists(@"OrdenesDeSeleccion.json"))
        {
            return;
        }

        var datos = File.ReadAllText("OrdenesDeSeleccion.json");

        ordenesSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos)!;
    }

    internal static string Nueva(OrdenDeSeleccionEnt nuevaOrden)
    {
        if (OrdenDeSeleccionAlmacen.OrdenesSeleccion.Count == 0)
        {
            nuevaOrden.NumeroOS = 1;
        }
        else
        {
            nuevaOrden.NumeroOS = OrdenDeSeleccionAlmacen.OrdenesSeleccion.Max(o => o.NumeroOS);
        }


        ordenesSeleccion.Add(nuevaOrden);
        return null;
    }
}