using Pampazon.Entidades;
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
    public static void Agregar(OrdenDePreparacionEnt nuevaOrden)
    {
        ordenesPreparacion.Add(nuevaOrden);
        Grabar();
    }
}