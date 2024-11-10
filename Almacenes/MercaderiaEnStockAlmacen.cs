using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class MercaderiaEnStockAlmacen
{
    private static List<MercaderiaEnStockEnt> _mercaderias = new();
    public static IReadOnlyCollection<MercaderiaEnStockEnt> Mercaderias => _mercaderias.AsReadOnly();
    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(_mercaderias);

        File.WriteAllText(@"MercaderiasEnStock.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists(@"MercaderiasEnStock.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }
    public static void ActualizarEnLote(List<MercaderiaEnStockEnt> mercaderias)
    {
        foreach (var mercaderia in mercaderias)
        {
            var index = _mercaderias.FindIndex(m => m.SKU == mercaderia.SKU);

            _mercaderias.RemoveAt(index);
            _mercaderias.Insert(index, mercaderia);
        }
        Grabar();
    }
    public static void GrabarDatosDePrueba()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\MercaderiasEnStock.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }
    public static void LeerDatosDePrueba()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\MercaderiasEnStock.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }
    public static void MigrarDatosDePrueba()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\MercaderiasEnStock.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }
}