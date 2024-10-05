using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloOperaciones.Descarga.IngresarOrdenDePreparacion;
public class GenerarOrdenDePreparacionModel
{
    private List<ClienteEntity> _clientes;
    private List<TransportistaEntity> _transportistas;
    private List<OrdenDeRecepcionEntity> _ordenesDeRecepcion;
    private List<MercaderiaEntity> _mercaderias;

    public GenerarOrdenDePreparacionModel()
    {
        _clientes = new()
            {
                new ()
                {
                    Numero = 1,
                    Cuit = "30518919349",
                    Nombre = "Mercadito S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678910",
                    Nombre = "Membrana S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678911",
                    Nombre = "Empresa S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
                }
            };
        _transportistas = new()
            {
                new()
                {
                    DNI = "12123123",
                    NombreYApellido = "Ricardo"
                },
                new()
                {
                    DNI = "12345678",
                    NombreYApellido = "Daiana"
                },
                new()
                {
                    DNI = "11111111",
                    NombreYApellido = "Ariadna"
                },
                new()
                {
                    DNI = "22222222",
                    NombreYApellido = "Juan Pablo"
                },
                new()
                {
                    DNI = "33333333",
                    NombreYApellido = "Juan Ignacio"
                },
            };
        _mercaderias = new()
        {
            new ()
            {
                NumeroCliente = 1,
                Descripcion = "Cemento",
                Cantidad = 2,
                UnidadDeMedida = UnidadDeMedida.Bolsas
            },
            new ()
            {
                NumeroCliente = 1,
                Descripcion = "Arena",
                Cantidad = 5,
                UnidadDeMedida = UnidadDeMedida.Bolsas
            },
            new ()
            {
                NumeroCliente = 1,
                Descripcion = "Ladrillos",
                Cantidad = 500,
                UnidadDeMedida = UnidadDeMedida.Unidades
            },
            new ()
            {
                NumeroCliente = 2,
                Descripcion = "Palets",
                Cantidad = 100,
                UnidadDeMedida = UnidadDeMedida.Unidades
            }
        };
    }
    public List<ClienteEntity> ObtenerClientes()
    {
        return _clientes;
    }
    public List<ClienteEntity> ObtenerClientesPorFiltro(string filtro)
    {
        return _clientes.Where(cliente => cliente.Nombre
            .ToString()
            .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
        ).ToList();
    }
    public List<TransportistaEntity> ObtenerTransportistas()
    {
        return _transportistas;
    }
    public List<TransportistaEntity> ObtenerTransportistasPorFiltro(string filtro)
    {
        return _transportistas.Where(transportista => transportista.NombreYApellido
            .ToString()
            .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
        ).ToList();
    }
    public List<MercaderiaEntity> ObtenerMercaderiasPorCliente(ClienteEntity cliente)
    {
        return _mercaderias
            .Where(mercaderia => mercaderia.NumeroCliente == cliente.Numero
        ).ToList();
    }

    public Resultado<bool> GenerarOrdenDePreparacion()
    {
        // Validar las reglas de negocio.
        return new Resultado<bool>(
            true,
            "La orden se generó correctamente.",
            true
        );
    }
}