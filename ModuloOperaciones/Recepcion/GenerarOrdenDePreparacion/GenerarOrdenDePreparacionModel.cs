using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;
public class GenerarOrdenDePreparacionModel
{
    private List<Cliente> _clientes;
    private List<Transportista> _transportistas;
    private List<OrdenDePreparacion> _ordenesDePreparacion;
    private List<Mercaderia> _mercaderias;

    public GenerarOrdenDePreparacionModel()
    {
        _clientes = new()
            {
                new ()
                {
                    Numero = 1,
                    Cuit = "30518919349",
                    Nombre = "Mercadito S.A",
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678910",
                    Nombre = "Membrana S.A",
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678911",
                    Nombre = "Empresa S.A",
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
                Cantidad = 50,
                UnidadDeMedida = UnidadDeMedida.Bolsas,
                Estado = MercaderiaEstado.EnAlmacen,
            },
            new ()
            {
                NumeroCliente = 1,
                Descripcion = "Arena",
                Cantidad = 150,
                UnidadDeMedida = UnidadDeMedida.Bolsas,
                Estado = MercaderiaEstado.EnAlmacen
            },
            new ()
            {
                NumeroCliente = 1,
                Descripcion = "Ladrillos",
                Cantidad = 500,
                UnidadDeMedida = UnidadDeMedida.Unidades,
                Estado = MercaderiaEstado.EnAlmacen
            },
            new ()
            {
                NumeroCliente = 2,
                Descripcion = "Palets",
                Cantidad = 100,
                UnidadDeMedida = UnidadDeMedida.Unidades,
                Estado = MercaderiaEstado.EnAlmacen
            }
        };
    }
    public List<Cliente> ObtenerClientes()
    {
        return _clientes;
    }
    public List<Cliente> ObtenerClientesPorFiltro(string filtro)
    {
        return _clientes.Where(cliente => cliente.Nombre
            .ToString()
            .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
        ).ToList();
    }
    public List<Transportista> ObtenerTransportistas()
    {
        return _transportistas;
    }
    public List<Transportista> ObtenerTransportistasPorFiltro(string filtro)
    {
        return _transportistas.Where(transportista => transportista.NombreYApellido
            .ToString()
            .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
        ).ToList();
    }
    public List<Mercaderia> ObtenerMercaderiasPorCliente(Cliente cliente)
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