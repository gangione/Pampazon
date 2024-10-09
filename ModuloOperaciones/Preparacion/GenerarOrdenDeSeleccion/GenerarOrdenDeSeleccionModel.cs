using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;
public class GenerarOrdenDeSeleccionModel
{
    private List<Cliente> _clientes;
    private List<OrdenDePreparacion> _ordenesDePreparacion;
    public GenerarOrdenDeSeleccionModel()
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
                Cuit = "12345678911",
                Nombre = "Empresa S.A",
            }
        };
        _ordenesDePreparacion = new()
        {
            new()
            {
                Numero = 1,
                Cliente = _clientes.Find(c => c.Numero == 1),
                FechaADespachar = DateTime.Now,
                MercaderiasAPreparar = new()
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
                    }
                }
            },
            new ()
            {
                Numero = 2,
                Cliente = _clientes.Find(c => c.Numero == 2),
                FechaADespachar = DateTime.Now.AddDays(1),
                MercaderiasAPreparar = new()
                {
                    new ()
                    {
                        NumeroCliente = 2,
                        Descripcion = "Azucar 1KG",
                        Cantidad = 10,
                        UnidadDeMedida = UnidadDeMedida.Palets,
                    },
                    new ()
                    {
                        NumeroCliente = 2,
                        Descripcion = "Manteca 500G",
                        Cantidad = 10,
                        UnidadDeMedida = UnidadDeMedida.Palets,
                    }
                }
            },

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
    public List<OrdenDePreparacion> ObtenerOrdenesDePreparacionPendientes()
    {
        return _ordenesDePreparacion;
    }
    public List<OrdenDePreparacion> ObtenerOrdenesPendientesPorCliente(Cliente cliente)
    {
        return _ordenesDePreparacion
            .Where(preparacion => preparacion.Cliente.Numero == cliente.Numero
        ).ToList();
    }
    public List<Mercaderia>? ObtenerMercaderiasAPrepararPorOrden(string nroOrden)
    {
        return _ordenesDePreparacion
            .Where(preparacion => preparacion.Numero == long.Parse(nroOrden))
            .ToList()
            .First()
            .MercaderiasAPreparar;
    }
}