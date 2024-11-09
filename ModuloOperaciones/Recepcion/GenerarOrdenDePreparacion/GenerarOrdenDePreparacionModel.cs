using Pampazon.Almacenes;
using Pampazon.Entidades;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Enums;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion.Utilidades;

namespace Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;
public class GenerarOrdenDePreparacionModel
{
    public GenerarOrdenDePreparacionModel()
    {
    }
    public List<Cliente> ObtenerClientes()
    {
        return ClienteAlmacen.Clientes
            .Select(cliente =>
            {
                return new Cliente()
                {
                    Numero = cliente.NumeroCliente,
                    Nombre = cliente.RazonSocial,
                    Prioridad = Enum.Parse<Prioridad>(cliente.Prioridad.ToString()),
                };
            })
            .ToList();
    }
    public List<Cliente> ObtenerClientesPorFiltro(string filtro)
    {
        return ClienteAlmacen.Clientes
            .Select(cliente =>
            {
                return new Cliente()
                {
                    Numero = cliente.NumeroCliente,
                    Nombre = cliente.RazonSocial,
                    Prioridad = Enum.Parse<Prioridad>(cliente.Prioridad.ToString()),
                };
            })
            .Where(cliente => cliente.Nombre.ToString().Contains(
                filtro, StringComparison.CurrentCultureIgnoreCase
            ))
            .ToList();
    }
    public List<Transportista> ObtenerTransportistas()
    {
        return TransportistaAlmacen.Transportistas
            .Select(transportista =>
            {
                return new Transportista()
                {
                    DNI = transportista.DNI,
                    NombreYApellido = transportista.NombreApellido
                };
            })
            .ToList();
    }
    public List<Transportista> ObtenerTransportistasPorFiltro(string filtro)
    {
        return TransportistaAlmacen.Transportistas
            .Select(transportista =>
            {
                return new Transportista()
                {
                    DNI = transportista.DNI,
                    NombreYApellido = transportista.NombreApellido
                };
            })
            .Where(transportista => transportista.NombreYApellido.ToString().Contains(
                filtro, StringComparison.CurrentCultureIgnoreCase
            ))
            .ToList();
    }
    public List<Mercaderia> ObtenerMercaderiasDisponiblesPorCliente(int numeroCliente)
    {
        var mercaderiasDisponibles = new List<Mercaderia>();

        foreach (var mercaderia in MercaderiaEnStockAlmacen.Mercaderias)
        {
            var mercaderiasEnStock = new List<Mercaderia>();

            if (mercaderia.NumeroCliente == numeroCliente)
            {
                int cantidadEnPreparacion = OrdenDePreparacionAlmacen
                   .OrdenesPreparacion
                   .Where(op => op.NumeroCliente == numeroCliente)
                   .Sum(op => op.Detalle
                       .Where(detalle => detalle.SKU == mercaderia.SKU)
                       .Sum(mercaderia => mercaderia.Cantidad)
                   );

                int cantidadDisponible = mercaderia.Ubicaciones
                    .Sum(u => u.Cantidad) - cantidadEnPreparacion;

                if (cantidadDisponible > 0)
                    mercaderiasDisponibles.Add(new Mercaderia()
                    {
                        SKU = mercaderia.SKU,
                        Descripcion = mercaderia.TipoDeMercaderia,
                        Cantidad = cantidadDisponible
                    });
            }
        }

        return mercaderiasDisponibles;
    }
    public Resultado<bool> GenerarOrdenDePreparacion(OrdenDePreparacion orden)
    {
        // 1. Verificar si la fecha a despachar que el cliente desea es > a hoy.
        if (orden.FechaDeDespacho < DateTime.Now)
            return new Resultado<bool>(
                false,
                "La fecha a despachar ingresada debe ser mayor o igual al día de hoy.",
                false
            );

        // 2. Verificar si el cliente tiene suficiente stock de Mercaderías.
        foreach (var mercaderiaSolicitada in orden.MercaderiasAPreparar)
        {
            if (mercaderiaSolicitada is not null)
            {
                Mercaderia mercaderiaEnStock = ObtenerMercaderiasDisponiblesPorCliente(
                    (int)orden.Cliente.Numero
                )
                .First(m => m.SKU == mercaderiaSolicitada.SKU);

                if (mercaderiaSolicitada.Cantidad > mercaderiaEnStock.Cantidad)
                    return new Resultado<bool>(
                        false,
                        "La cantidad a retirar no puede superar a la cantidad en Stock.",
                        false
                    );
            }
        }

        // 3. Verificar si existe el Transportista. Si no existe en la DB, agregar.
        var transportista = TransportistaAlmacen
                .Transportistas
                .Where(t => t.DNI == orden.Transportista.DNI)
                .FirstOrDefault();

        if (transportista is null)
        {
            int numeroTransportista = TransportistaAlmacen
                .Transportistas.LastOrDefault() is null ? 1 :
            TransportistaAlmacen.Transportistas.Last().NumeroTransportista + 1;

            transportista = new TransportistaEnt()
            {
                NumeroTransportista = numeroTransportista,
                DNI = orden.Transportista.DNI,
                NombreApellido = orden.Transportista.NombreYApellido
            };

            TransportistaAlmacen.Agregar(transportista);
        }

        // 4. Crear el detalle.
        var detalle = orden.MercaderiasAPreparar?
            .Select(mercaderia =>
            {
                return new OrdenDePreparacionDetalle()
                {
                    SKU = mercaderia.SKU,
                    Cantidad = mercaderia.Cantidad
                };
            });

        // 5. Crear y Agregar la nueva Orden de Preparación.
        int numeroOrden = OrdenDePreparacionAlmacen
            .OrdenesPreparacion.LastOrDefault() is null ? 1 :
            OrdenDePreparacionAlmacen.OrdenesPreparacion.Last().NumeroOP + 1;

        OrdenDePreparacionEnt op = new()
        {
            NumeroOP = numeroOrden,
            NumeroCliente = (int)orden.Cliente.Numero,
            FechaADespachar = orden.FechaDeDespacho,
            NumeroTransportista = transportista.NumeroTransportista,
            Estado = OPEstadoEnum.Pendiente,
            Prioridad = Enum.Parse<PrioridadEnum>(orden.Cliente.Prioridad.ToString()),
        };
        op.Detalle.AddRange(detalle);
        OrdenDePreparacionAlmacen.Agregar(op);

        return new Resultado<bool>(
            true,
            "La orden se generó correctamente.",
            true
        );
    }
}