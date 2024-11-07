using System.Text.Json;

namespace Pampazon.Almacenes;
public static class TransportistaAlmacen
{
    private static List<TransportistaEnt> _transportista = new();
    public static IReadOnlyCollection<TransportistaEnt> Transportistas => _transportista.AsReadOnly();

    public static void Grabar()
    {

        var datos = JsonSerializer.Serialize(_transportista);

        File.WriteAllText("Transportistas.json", datos);
    }

    public static void Leer()
    {
        if (!File.Exists("Transportistas.json"))
        {
            return;
        }

        var datos = File.ReadAllText("Transportistas.json");

        _transportista = JsonSerializer.Deserialize<List<TransportistaEnt>>(datos)!;
    }
}
