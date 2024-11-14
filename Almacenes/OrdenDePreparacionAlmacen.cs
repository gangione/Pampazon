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
        File.WriteAllText(@"Almacenes\DatosDePrueba\OrdenesDePreparacion.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\OrdenesDePreparacion.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\OrdenesDePreparacion.json");

        ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenDePreparacionEnt>>(datos)!;
    }
    public static OrdenDePreparacionEnt Agregar(OrdenDePreparacionEnt nuevaOrden)
    {
        nuevaOrden.NumeroOP = OrdenesPreparacion.LastOrDefault() is null ? 1 :
            OrdenesPreparacion.Max(op => op.NumeroOP) + 1;

        ordenesPreparacion.Add(nuevaOrden);
        return nuevaOrden;
    }
    public static void Actualizar(OrdenDePreparacionEnt orden)
    {
        var index = ordenesPreparacion.FindIndex(op => op.NumeroOP == orden.NumeroOP);

        ordenesPreparacion.RemoveAt(index);
        ordenesPreparacion.Insert(index, orden);
    }
    public static void ActualizarEnLote(List<OrdenDePreparacionEnt> ordenes)
    {
        foreach (var orden in ordenes)
        {
            var index = ordenesPreparacion.FindIndex(op => op.NumeroOP == orden.NumeroOP);

            ordenesPreparacion.RemoveAt(index);
            ordenesPreparacion.Insert(index, orden);
        }
    }
}