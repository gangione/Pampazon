using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class OrdenDeSeleccionAlmacen
{
    private static List<OrdenDeSeleccionEnt> ordenesSeleccion = [];

    public static IReadOnlyCollection<OrdenDeSeleccionEnt> OrdenesSeleccion => ordenesSeleccion.AsReadOnly();

    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(ordenesSeleccion);
        File.WriteAllText(@"OrdenesDeSeleccion.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists(@"OrdenesDeSeleccion.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"OrdenesDeSeleccion.json");

        ordenesSeleccion = JsonSerializer.Deserialize<List<OrdenDeSeleccionEnt>>(datos)!;
    }
    public static OrdenDeSeleccionEnt Agregar(OrdenDeSeleccionEnt nuevaOrden)
    {
        nuevaOrden.NumeroOS = OrdenesSeleccion.LastOrDefault() is null ? 1 :
            OrdenesSeleccion.Max(op => op.NumeroOS) + 1;

        ordenesSeleccion.Add(nuevaOrden);
        Grabar();

        return nuevaOrden;
    }
    public static void Actualizar(OrdenDeSeleccionEnt orden)
    {
    }
}