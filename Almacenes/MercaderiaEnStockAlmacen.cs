using System.Text.Json;

namespace Pampazon.Almacenes;
public static class MercaderiaEnStockAlmacen
{
    private static List<MercaderiaEnStockEnt> _mercaderias = new();
    public static IReadOnlyCollection<MercaderiaEnStockEnt> Mercaderias => _mercaderias.AsReadOnly();

    public static void Guardar()
    {
        //pasar la lista de personas a un formato llamado JSON.
        //básicamente es transformar la lista en un string muy muy grande
        //con los datos de todas las personas.
        var datos = JsonSerializer.Serialize(_mercaderias);

        //Grabarlo en disco:
        File.WriteAllText("MercaderiasEnStock.json", datos);
    }

    public static void Obtener()
    {
        if (!File.Exists("MercaderiasEnStock.json")) //si el archivo no existe no tengo nada que hacer.
        {
            return;
        }

        var datos = File.ReadAllText("MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }

    
}
