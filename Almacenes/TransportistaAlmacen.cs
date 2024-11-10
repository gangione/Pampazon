using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class TransportistaAlmacen
{
    private static List<TransportistaEnt> _transportistas = new();
    public static IReadOnlyCollection<TransportistaEnt> Transportistas => _transportistas.AsReadOnly();
    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(_transportistas);

        File.WriteAllText("Transportistas.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists("Transportistas.json"))
        {
            return;
        }

        var datos = File.ReadAllText("Transportistas.json");

        _transportistas = JsonSerializer.Deserialize<List<TransportistaEnt>>(datos)!;
    }
    public static TransportistaEnt Agregar(TransportistaEnt transportista)
    {
        transportista.NumeroTransportista = Transportistas.LastOrDefault() is null ? 1 :
            Transportistas.Max(t => t.NumeroTransportista) + 1;

        _transportistas.Add(transportista);
        return transportista;
    }
    public static void LeerDatosDePrueba()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\Transportistas.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\Transportistas.json");

        _transportistas = JsonSerializer.Deserialize<List<TransportistaEnt>>(datos)!;
    }
}