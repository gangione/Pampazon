using System.Text.Json;

namespace Pampazon.Almacenes;
public static class ClienteAlmacen
{
    private static List<ClienteEnt> _cliente = new();
    public static IReadOnlyCollection<ClienteEnt> Cliente => _cliente.AsReadOnly();

    public static void Guardar()
    {
        //pasar la lista de personas a un formato llamado JSON.
        //básicamente es transformar la lista en un string muy muy grande
        //con los datos de todas las personas.
        var datos = JsonSerializer.Serialize(_cliente);

        //Grabarlo en disco:
        File.WriteAllText("Clientes.json", datos);
    }

    public static void Obtener()
    {
        if (!File.Exists("Clientes.json")) //si el archivo no existe no tengo nada que hacer.
        {
            return;
        }

        var datos = File.ReadAllText("Clientes.json");

        _cliente = JsonSerializer.Deserialize<List<ClienteEnt>>(datos)!;
    }


}

