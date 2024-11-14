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
                int cantidadEnSeleccion = OrdenDePreparacionAlmacen
                   .OrdenesPreparacion
                   .Where(op => op.NumeroCliente == numeroCliente &&
                        op.Estado == OPEstadoEnum.Pendiente ||
                        op.Estado == OPEstadoEnum.EnSeleccion
                   )
                   .Sum(op => op.Detalle
                       .Where(detalle => detalle.SKU == mercaderia.SKU)
                       .Sum(mercaderia => mercaderia.Cantidad)
                   );

                int cantidadDisponible = mercaderia.Ubicaciones
                    .Sum(u => u.Cantidad) - cantidadEnSeleccion;

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
    public Resultado<OrdenDePreparacionEnt> GenerarOrdenDePreparacion(OrdenDePreparacion orden)
    {
        var ordenDePreparacion = new OrdenDePreparacionEnt();

        // 1. Verificar si la fecha a despachar que el cliente desea es > a hoy.
        if (orden.FechaDeDespacho < DateTime.Now)
            return new Resultado<OrdenDePreparacionEnt>(
                false,
                "La fecha a despachar ingresada debe ser mayor o igual al día de hoy.",
                ordenDePreparacion
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
                    return new Resultado<OrdenDePreparacionEnt>(
                        false,
                        "La cantidad a retirar no puede superar a la cantidad en Stock.",
                        ordenDePreparacion
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
            transportista = TransportistaAlmacen
                .Agregar(new TransportistaEnt()
                {
                    DNI = orden.Transportista.DNI,
                    NombreApellido = orden.Transportista.NombreYApellido
                });
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

        // 5. Completar y Agregar la nueva Orden de Preparación.
        ordenDePreparacion.NumeroCliente = (int)orden.Cliente.Numero;
        ordenDePreparacion.FechaADespachar = orden.FechaDeDespacho;
        ordenDePreparacion.NumeroTransportista = transportista.NumeroTransportista;
        ordenDePreparacion.Estado = OPEstadoEnum.Pendiente;
        ordenDePreparacion.Prioridad = Enum.Parse<PrioridadEnum>(orden.Cliente.Prioridad.ToString());
        ordenDePreparacion.Detalle.AddRange(detalle);
        ordenDePreparacion = OrdenDePreparacionAlmacen.Agregar(ordenDePreparacion);

        TransportistaAlmacen.Grabar();
        OrdenDePreparacionAlmacen.Grabar();

        return new Resultado<OrdenDePreparacionEnt>(
            true,
            $"La OP Número {ordenDePreparacion.NumeroOP} se generó correctamente.",
            ordenDePreparacion
        );
    }
}