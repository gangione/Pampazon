using System.Text.Json;

namespace Pampazon.Almacenes;
public static class OrdenDeEntregaAlmacen
{
    private static List<OrdenDeEntregaEnt> _ordenesDeEntrega = new();
    public static IReadOnlyCollection<OrdenDeEntregaEnt> ordenesDeEntrega => _ordenesDeEntrega.AsReadOnly();

    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(_ordenesDeEntrega);

        //Grabarlo en disco:
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


}
