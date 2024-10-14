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
                    Nombre = "Mercadito S.A",
                    Prioridad = Prioridad.Alta
                },
                new ()
                {
                    Numero = 2,
                    Nombre = "Empresa S.A",
                    Prioridad = Prioridad.Baja
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
                SKU = "AA-10",
                NumeroCliente = 1,
                Descripcion = "Cemento",
                Cantidad = 50,
                Estado = MercaderiaEstado.EnAlmacen,
            },
            new ()
            {
                SKU = "AB-20",
                NumeroCliente = 1,
                Descripcion = "Arena",
                Cantidad = 150,
                Estado = MercaderiaEstado.EnAlmacen
            },
            new ()
            {
                SKU = "AC-30",
                NumeroCliente = 1,
                Descripcion = "Ladrillos",
                Cantidad = 500,
                Estado = MercaderiaEstado.EnAlmacen
            },
            new ()
            {
                SKU = "BA-10",
                NumeroCliente = 2,
                Descripcion = "Zapatillas",
                Cantidad = 100,
                Estado = MercaderiaEstado.EnAlmacen
            },
            new ()
            {
                SKU = "BA-20",
                NumeroCliente = 2,
                Descripcion = "Remeras",
                Cantidad = 100,
                Estado = MercaderiaEstado.EnAlmacen
            }
        };
        _ordenesDePreparacion = new();
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
    public List<Mercaderia> ObtenerMercaderiasEnStockPorCliente(Cliente cliente)
    {
        return _mercaderias
            .Where(mercaderia =>
                mercaderia.NumeroCliente == cliente.Numero
                && mercaderia.Estado == MercaderiaEstado.EnAlmacen)
            .ToList();
    }
    public Resultado<bool> GenerarOrdenDePreparacion(OrdenDePreparacion orden)
    {
        if (orden.FechaDeDespacho < DateTime.Now)
            return new Resultado<bool>(
                false,
                "La fecha a despachar ingresada debe ser mayor o igual al día de hoy.",
                false
            );

        // CAMBIAR DE ESTADO LAS MERCADERÍAS
        for (int i = 0; i < orden.MercaderiasAPreparar?.Count; i++)
        {
            Mercaderia mercaderiaARetirar = orden.MercaderiasAPreparar[i];

            Mercaderia mercaderiaEnStock = _mercaderias
                .First(m => m.SKU == mercaderiaARetirar.SKU
                    && m.Estado == MercaderiaEstado.EnAlmacen);

            if (mercaderiaARetirar.Cantidad > mercaderiaEnStock.Cantidad)
                return new Resultado<bool>(
                    false,
                    "La cantidad a retirar no puede superar a la cantidad en Stock.",
                    false
                );

            mercaderiaEnStock.Cantidad = mercaderiaEnStock.Cantidad - mercaderiaARetirar.Cantidad;

            if (mercaderiaEnStock.Cantidad == 0)
                _mercaderias.Remove(mercaderiaEnStock);

            mercaderiaARetirar.Estado = MercaderiaEstado.ASeleccionar;
            _mercaderias.Add(mercaderiaARetirar);
        }

        long numeroOrden = _ordenesDePreparacion.LastOrDefault() is null ? 1 :
            _ordenesDePreparacion.Last().Numero + 1;

        OrdenDePreparacion op = new()
        {
            Numero = numeroOrden,
            Fecha = DateTime.Now,
            FechaDeDespacho = orden.FechaDeDespacho,
            Estado = OrdenDePreparacionEstado.Pendiente,
            MercaderiasAPreparar = orden.MercaderiasAPreparar
        };

        _ordenesDePreparacion.Add(op);

        return new Resultado<bool>(
            true,
            "La orden se generó correctamente.",
            true
        );
    }
}