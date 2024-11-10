using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class OrdenDeEntregaAlmacen
{
    private static List<OrdenDeEntregaEnt> _ordenesDeEntrega = new();
    public static IReadOnlyCollection<OrdenDeEntregaEnt> OrdenesDeEntrega => _ordenesDeEntrega.AsReadOnly();

    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(_ordenesDeEntrega);

        File.WriteAllText("OrdenesDeEntrega.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists("OrdenesDeEntrega.json"))
        {
            return;
        }

        var datos = File.ReadAllText("OrdenesDeEntrega.json");

        _ordenesDeEntrega = JsonSerializer.Deserialize<List<OrdenDeEntregaEnt>>(datos)!;
    }
    public static OrdenDeEntregaEnt Agregar(OrdenDeEntregaEnt nuevaOrden)
    {
        nuevaOrden.NumeroOE = OrdenesDeEntrega.LastOrDefault() is null ? 1 :
            OrdenesDeEntrega.Max(op => op.NumeroOE) + 1;

        _ordenesDeEntrega.Add(nuevaOrden);
        return nuevaOrden;
    }

    public static void Actualizar(OrdenDeEntregaEnt orden)
    {
        var index = _ordenesDeEntrega.FindIndex(os => os.NumeroOE == orden.NumeroOE);

        _ordenesDeEntrega.RemoveAt(index);
        _ordenesDeEntrega.Insert(index, orden);
    }
}