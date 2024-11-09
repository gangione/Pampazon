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
    public static void GrabarDatosDePrueba()
    {
        //MercaderiaEnStockEnt[] mercaderias = [
        //    new()
        //    {
        //        SKU =  "AA-10",
        //        NumeroCliente = 1,
        //        TipoDeMercaderia = "Cemento",
        //        Ubicaciones = [
        //            new ()
        //            {
        //                Cantidad =  50,
        //                Sector =  1,
        //                Posicion =  1,
        //                Fila =  1
        //            }
        //        ]
        //    },
        //    new()
        //    {
        //        SKU =  "AB-20",
        //        NumeroCliente = 1,
        //        TipoDeMercaderia = "Arena",
        //        Ubicaciones = [
        //            new ()
        //            {
        //                Cantidad =  50,
        //                Sector =  1,
        //                Posicion =  1,
        //                Fila =  2
        //            }
        //        ]
        //    },
        //    new()
        //    {
        //        SKU = "AC-30",
        //        NumeroCliente = 1,
        //        TipoDeMercaderia = "Ladrillos",
        //        Ubicaciones =  [
        //            new ()
        //            {
        //                Cantidad =  50,
        //                Sector =  1,
        //                Posicion =  1,
        //                Fila =  1
        //            }
        //        ]
        //    },
        //    new()
        //    {
        //        SKU = "BA-10",
        //        NumeroCliente = 2,
        //        TipoDeMercaderia = "Zapatillas",
        //        Ubicaciones =  [
        //        new ()
        //            {
        //                Cantidad =  50,
        //                Sector =  1,
        //                Posicion =  1,
        //                Fila =  1
        //            }
        //        ]
        //    },
        //    new()
        //    {
        //        SKU = "BA-20",
        //        NumeroCliente = 2,
        //        TipoDeMercaderia = "Remeras",
        //        Ubicaciones =  [
        //            new ()
        //            {
        //                Cantidad =  50,
        //                Sector =  1,
        //                Posicion =  1,
        //                Fila =  1
        //            }
        //        ]
        //    }
        //];
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
}