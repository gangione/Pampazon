﻿using System.Text.Json;

namespace Pampazon.Almacenes;
public static class MercaderiaEnStockAlmacen
{
    private static List<MercaderiaEnStockEnt> _mercaderias = new();
    public static IReadOnlyCollection<MercaderiaEnStockEnt> Mercaderias => _mercaderias.AsReadOnly();

    public static void Grabar()
    {

        var datos = JsonSerializer.Serialize(_mercaderias);


        File.WriteAllText("MercaderiasEnStock.json", datos);
    }

    public static void Leer()
    {
        if (!File.Exists("MercaderiasEnStock.json"))
        {
            return;
        }

        var datos = File.ReadAllText("MercaderiasEnStock.json");

        _mercaderias = JsonSerializer.Deserialize<List<MercaderiaEnStockEnt>>(datos)!;
    }

    
}
