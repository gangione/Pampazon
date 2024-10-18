using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Dtos;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Enums;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public class GenerarRemitoModel
{
    private List<Transportista> _transportistas;
    private List<OrdenDeEntrega> _ordenesDeEntrega;
    private List<OrdenDePreparacion> _ordenesDePreparacion;
    private List<Mercaderia> _mercaderias;
    private List<Remito> _remitos;
    public GenerarRemitoModel()
    {
        _transportistas = new()
        {
            new()
            {
                DNI = 12123123,
                NombreYApellido = "Ricardo"
            },
            new()
            {
                DNI = 22222222,
                NombreYApellido = "Juan Pablo"
            },
            new()
            {
                DNI = 33333333,
                NombreYApellido = "Juan Ignacio"
            },
        };
        _ordenesDeEntrega = new()
        {
            new()
            {
                NroOrdenDePreparacion = 1,
                Cliente = "Mercadito S.A.",
                SKU = "AA-10",
                Cantidad = 50,
                DNITransportista = 12123123,
                Estado = OrdenDeEntregaEstado.Pendiente
            },
            new()
            {
                NroOrdenDePreparacion = 1,
                Cliente = "Mercadito S.A.",
                SKU = "AB-20",
                Cantidad = 500,
                DNITransportista = 12123123,
                Estado = OrdenDeEntregaEstado.Pendiente
            },
            new()
            {
                NroOrdenDePreparacion = 1,
                Cliente = "Mercadito S.A.",
                SKU = "AC-30",
                Cantidad = 150,
                DNITransportista = 12123123,
                Estado = OrdenDeEntregaEstado.Pendiente
            }
        };
        _ordenesDePreparacion = new()
        {
            new()
            {
                Numero = 1,
                Estado = OrdenDePreparacionEstado.Preparada,
            }
        };
        _mercaderias = new()
        {
            new()
            {
                SKU = "AA-10",
                Cantidad = 50,
                Estado = MercaderiaEstado.EnDespacho,
                NroOrdenDePreparacion = 1,
            },
            new()
            {
                SKU = "AB-20",
                Cantidad = 500,
                Estado = MercaderiaEstado.EnDespacho,
                NroOrdenDePreparacion = 1,
            },
            new()
            {
                SKU = "AC-30",
                Cantidad = 150,
                Estado = MercaderiaEstado.EnDespacho,
                NroOrdenDePreparacion = 1,
            }
        };
        _remitos = new();
    }

    public List<Transportista> ObtenerTransportistas()
    {
        return _transportistas;
    }

    public List<OrdenDeEntrega> ObtenerOrdenesDeEntregaPendientesPorTransportista(long dniTransportista)
    {
        return _ordenesDeEntrega
            .Where(entrega => entrega.DNITransportista == dniTransportista &&
                entrega.Estado == OrdenDeEntregaEstado.Pendiente)
            .ToList();
    }
    public Resultado<bool> DespacharOrdenesDePreparacion(long dniTransportista)
    {
        Transportista? transportista = _transportistas
            .Find(t => t.DNI == dniTransportista);

        if (transportista is null)
            return new Resultado<bool>(
                false,
                $"No se enontró el Transportista con DNI {dniTransportista}.",
                false
            );

        List<OrdenDeEntrega> ordenesAEntregar = ObtenerOrdenesDeEntregaPendientesPorTransportista(dniTransportista);

        if (ordenesAEntregar.Count == 0)
            return new Resultado<bool>(
                false,
                "El Transportista seleccionado no posee ordenes a despachar.",
                false
            );

        foreach (var entrega in ordenesAEntregar)
        {
            OrdenDePreparacion? op = _ordenesDePreparacion
                .Find(op => op.Numero == entrega.NroOrdenDePreparacion
                    && op.Estado == OrdenDePreparacionEstado.Preparada);

            if (op is not null)
            {
                var mercaderias = _mercaderias
                    .FindAll(m => m.NroOrdenDePreparacion == entrega.NroOrdenDePreparacion);

                foreach (Mercaderia mercaderia in mercaderias)
                {
                    mercaderia.Estado = MercaderiaEstado.Entregada;
                    _mercaderias.Remove(mercaderia);
                }
                _mercaderias.AddRange(mercaderias);

                entrega.Estado = OrdenDeEntregaEstado.Despachada;
                op.Estado = OrdenDePreparacionEstado.Despachada;

                _ordenesDeEntrega.Remove(entrega);
                _ordenesDeEntrega.Add(entrega);

                _ordenesDePreparacion.Remove(op);
                _ordenesDePreparacion.Add(op);
                _remitos.Add(new Remito()
                {
                    Numero = _remitos.LastOrDefault() is null ? 1 : _remitos.Last().Numero + 1,
                    Fecha = DateTime.Now,
                    Transportista = transportista,
                    Mercaderias = mercaderias
                });
            }
            else
            {
                entrega.Estado = OrdenDeEntregaEstado.Despachada;
                _ordenesDeEntrega.Remove(entrega);
                _ordenesDeEntrega.Add(entrega);
            }
        }

        return new Resultado<bool>(
            true,
            "Ordenes de preparación despacahadas.\n\n" +
            "Se ha generado el remito correctamente.\n" +
            "Se ha realizado la baja del Stock.",
            true
        );
    }
}