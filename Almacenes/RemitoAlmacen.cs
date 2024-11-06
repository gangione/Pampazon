using System.Text.Json;

namespace Pampazon.Almacenes;
public static class RemitoAlmacen
{
    private static List<RemitoEnt> _remitos = new();
    public static IReadOnlyCollection<RemitoEnt> Remitos => _remitos.AsReadOnly();

    public static void Grabar()
    {

        var datos = JsonSerializer.Serialize(_remitos);

        File.WriteAllText("Remitos.json", datos);
    }

    public static void Leer()
    {
        if (!File.Exists("Remitos.json"))
        {
            return;
        }

        var datos = File.ReadAllText("Remitos.json");

        _remitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos)!;
    }
}