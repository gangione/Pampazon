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
    public static void Agregar(TransportistaEnt transportista)
    {
        _transportistas.Add(transportista);
        Grabar();
    }
    public static void GrabarDatosDePrueba()
    {
        //var transportistas = new List<TransportistaEnt>()
        //{
        //    new ()
        //    {
        //        NumeroTransportista = 1,
        //        NombreApellido = "Ricardo",
        //        DNI = "12123123"
        //    },
        //    new ()
        //    {
        //        NumeroTransportista = 2,
        //        NombreApellido = "Juan Pablo",
        //        DNI = "22222222"
        //    },
        //    new ()
        //    {
        //        NumeroTransportista = 3,
        //        NombreApellido = "Juan Ignacio",
        //        DNI = "33333333"
        //    }
        //};
        if (!File.Exists(@"Almacenes\DatosDePrueba\Transportistas.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\Transportistas.json");

        _transportistas = JsonSerializer.Deserialize<List<TransportistaEnt>>(datos)!;
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