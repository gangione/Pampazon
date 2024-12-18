﻿using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class RemitoAlmacen
{
    private static List<RemitoEnt> _remitos = new();
    public static IReadOnlyCollection<RemitoEnt> Remitos => _remitos.AsReadOnly();

    public static void Grabar()
    {

        var datos = JsonSerializer.Serialize(_remitos);

        File.WriteAllText(@"Almacenes\DatosDePrueba\Remitos.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\Remitos.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\Remitos.json");

        _remitos = JsonSerializer.Deserialize<List<RemitoEnt>>(datos)!;
    }

    public static RemitoEnt Agregar(RemitoEnt nuevoRemito)
    {
        nuevoRemito.NumeroRemito = Remitos.LastOrDefault() is null ? 1 :
            Remitos.Max(r => r.NumeroRemito) + 1;

        _remitos.Add(nuevoRemito);
        return nuevoRemito;
    }

    public static void AgregarEnLote(List<RemitoEnt> nuevosRemitos)
    {
        foreach (var remito in nuevosRemitos)
        {
            Agregar(remito);
        }
    }
}