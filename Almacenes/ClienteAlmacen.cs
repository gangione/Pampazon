﻿using Pampazon.Entidades;
using System.Text.Json;

namespace Pampazon.Almacenes;
public static class ClienteAlmacen
{
    private static List<ClienteEnt> _clientes = new()
    {
    };
    public static IReadOnlyCollection<ClienteEnt> Clientes => _clientes.AsReadOnly();
    public static void Grabar()
    {
        var datos = JsonSerializer.Serialize(_clientes);

        File.WriteAllText(@"Almacenes\DatosDePrueba\Clientes.json", datos);
    }
    public static void Leer()
    {
        if (!File.Exists(@"Almacenes\DatosDePrueba\Clientes.json"))
        {
            return;
        }

        var datos = File.ReadAllText(@"Almacenes\DatosDePrueba\Clientes.json");

        _clientes = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;
    }

}