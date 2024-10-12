using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Enums;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion.Utilidades;

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
                Prioridad = Prioridad.Alta
            },
            new ()
            {
                Numero = 2,
                Cuit = "12345678911",
                Nombre = "Empresa S.A",
                Prioridad = Prioridad.Baja
            }
        };
        _ordenesDePreparacion = new()
        {
            new()
            {
                Numero = 1,
                Cliente = _clientes.Find(c => c.Numero == 1),
                FechaADespachar = DateTime.Now,
                Estado = OrdenDePreparacionEstado.Pendiente,
                MercaderiasAPreparar = new()
                {
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Cemento",
                        Cantidad = 50,
                        UnidadDeMedida = UnidadDeMedida.Bolsas,
                        Ubicacion = "12-43-2"
                    },
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Arena",
                        Cantidad = 150,
                        UnidadDeMedida = UnidadDeMedida.Bolsas,
                        Ubicacion = "12-43-2"
                    },
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Ladrillos",
                        Cantidad = 500,
                        UnidadDeMedida = UnidadDeMedida.Unidades,
                        Ubicacion = "12-43-2"
                    }
                }
            },
            new ()
            {
                Numero = 2,
                Cliente = _clientes.Find(c => c.Numero == 2),
                FechaADespachar = DateTime.Now.AddDays(1),
                Estado = OrdenDePreparacionEstado.Pendiente,
                MercaderiasAPreparar = new()
                {
                    new ()
                    {
                        NumeroCliente = 2,
                        Descripcion = "Azucar",
                        Cantidad = 10,
                        UnidadDeMedida = UnidadDeMedida.Palets,
                        Ubicacion = "12-43-2"
                    },
                    new ()
                    {
                        NumeroCliente = 2,
                        Descripcion = "Harina",
                        Cantidad = 10,
                        UnidadDeMedida = UnidadDeMedida.Palets,
                        Ubicacion = "12-43-2"
                    }
                }
            },
            new()
            {
                Numero = 3,
                Cliente = _clientes.Find(c => c.Numero == 1),
                FechaADespachar = DateTime.Now,
                Estado = OrdenDePreparacionEstado.Pendiente,
                MercaderiasAPreparar = new()
                {
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Cemento",
                        Cantidad = 2,
                        UnidadDeMedida = UnidadDeMedida.Bolsas,
                        Ubicacion = "12-43-2"
                    },
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Arena",
                        Cantidad = 5,
                        UnidadDeMedida = UnidadDeMedida.Bolsas,
                        Ubicacion = "12-43-2"
                    },
                    new ()
                    {
                        NumeroCliente = 1,
                        Descripcion = "Ladrillos",
                        Cantidad = 500,
                        UnidadDeMedida = UnidadDeMedida.Unidades,
                        Ubicacion = "12-43-2"
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
        return _ordenesDePreparacion
            .Where(op => op.Estado == OrdenDePreparacionEstado.Pendiente)
            .ToList();
    }
    public List<OrdenDePreparacion> ObtenerOrdenesPendientesPorCliente(Cliente cliente)
    {
        return _ordenesDePreparacion
            .Where(preparacion => preparacion.Cliente.Numero == cliente.Numero
        ).ToList();
    }
    public OrdenDePreparacion ObtenerOrdenDePreparacionPorNumero(long nroOrden)
    {
        return _ordenesDePreparacion
            .Where(op => op.Numero == nroOrden)
            .First();
    }
    public List<Mercaderia>? ObtenerMercaderiasAPrepararPorOrden(string nroOrden)
    {
        return _ordenesDePreparacion
            .Where(preparacion => preparacion.Numero == long.Parse(nroOrden))
            .ToList()
            .First()
            .MercaderiasAPreparar;
    }
    public Resultado<bool> GenerarOrdenDeSeleccion(OrdenDeSeleccion orden)
    {
        // Validar las reglas de negocio.
        // CAMBIAR DE ESTADO
        for (int i = 0; i < orden.OrdenesASeleccionar.Count; i++)
        {
            OrdenDePreparacion preparacion = _ordenesDePreparacion
                .First(op => op.Numero == orden.OrdenesASeleccionar[i].Numero);

            preparacion.Estado = OrdenDePreparacionEstado.EnPreparacion;

            _ordenesDePreparacion.Remove(preparacion);
            _ordenesDePreparacion.Add(preparacion);
        }

        return new Resultado<bool>(
            true,
            "La orden se generó correctamente.",
            true
        );
    }
}