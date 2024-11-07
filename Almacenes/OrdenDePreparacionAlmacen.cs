using System.Text.Json;

namespace Pampazon.Almacenes;
public static class OrdenDePreparacionAlmacen
{
    private static List<OrdenDePreparacionEnt> ordenesPreparacion = [];

    public static IReadOnlyCollection<OrdenDePreparacionEnt> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(ordenesPreparacion);
        File.WriteAllText("OrdenesDePreparacion.json", datos);
    }

    public static void Leer()
    {
        if (!File.Exists(@"OrdenesDePreparacion.json"))
        {
            return;
        }

        var datos = File.ReadAllText("OrdenesDePreparacion.json");

        ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenDePreparacionEnt>>(datos)!;
    }

    internal static string Nueva(OrdenDePreparacionEnt nuevaOrden)
    {
        if (OrdenDePreparacionAlmacen.OrdenesPreparacion.Count == 0)
        {
            nuevaOrden.NumeroOP = 1;
        }
        else
        {
            nuevaOrden.NumeroOP = OrdenDePreparacionAlmacen.OrdenesPreparacion.Max(o => o.NumeroOP);
        }


        ordenesPreparacion.Add(nuevaOrden);
        return null;
    }
}