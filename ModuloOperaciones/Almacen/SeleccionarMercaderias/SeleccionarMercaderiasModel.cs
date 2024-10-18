using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Utilidades;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
public class SeleccionarMercaderiasModel
{
    private List<OrdenDeSeleccion> _ordenesDeSeleccion;
    public SeleccionarMercaderiasModel()
    {
        _ordenesDeSeleccion = new()
        {
            new()
            {
                Numero = 1,
                Prioridad = Prioridad.Alta,
                FechaADespachar = DateTime.Now.AddDays(1),
                Estado = OrdenDeSeleccionEstado.Pendiente,
                OrdenesDePreparacion = new()
                {
                    new ()
                    {
                        Numero = 1,
                        Estado = OrdenDePreparacionEstado.EnSeleccion,
                        MercaderiasAPreparar = new ()
                        {
                            new ()
                            {
                                SKU = "AA-10",
                                Descripcion = "Cemento",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,1,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 1
                            },
                            new ()
                            {
                                SKU = "AB-20",
                                Descripcion = "Ladrillos",
                                Cantidad = 450,
                                Ubicacion = new Ubicacion(1,2,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 1
                            },
                            new ()
                            {
                                SKU = "AB-20",
                                Descripcion = "Ladrillos",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,1,2),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 1
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Arena",
                                Cantidad = 25,
                                Ubicacion = new Ubicacion(1,2,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 1
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Arena",
                                Cantidad = 25,
                                Ubicacion = new Ubicacion(1,2,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 1
                            }
                        }
                    },
                    new()
                    {
                        Numero = 2,
                        Estado = OrdenDePreparacionEstado.EnSeleccion,
                        MercaderiasAPreparar = new()
                        {
                            new ()
                            {
                                SKU = "BA-10",
                                Descripcion = "Zapatillas",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,2,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 2
                            },
                            new ()
                            {
                                SKU = "BA-10",
                                Descripcion = "Zapatillas",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,2,2),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 2
                            },
                            new ()
                            {
                                SKU = "BA-20",
                                Descripcion = "Remeras",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,2,1),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 2
                            },
                            new ()
                            {
                                SKU = "BA-20",
                                Descripcion = "Remeras",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,2,2),
                                Estado = MercaderiaEstado.ASeleccionar,
                                NroOrdenDePreparacion = 2
                            }
                        }
                    }
                },
            }
        };
    }

    public List<OrdenDeSeleccion> ObtenerOrdenesDeSeleccionPendiente()
    {
        return _ordenesDeSeleccion
            .Where(os => os.Estado == OrdenDeSeleccionEstado.Pendiente)
            .OrderBy(os => os.Prioridad)
            .OrderByDescending(os => os.FechaADespachar)
            .ToList();
    }

    public List<OrdenDeSeleccion> ObtenerOrdenesDeSeleccionPendientePorPrioridad(Prioridad? prioridad)
    {
        return _ordenesDeSeleccion
            .Where(os => os.Prioridad == prioridad)
            .OrderByDescending(os => os.FechaADespachar)
            .ToList();
    }

    public List<Mercaderia> ObtenerMercaderiasPorNumeroDeSeleccion(long numero)
    {
        var ordenDeSeleccion = _ordenesDeSeleccion
            .First(os => os.Numero == numero);

        var ordenesDePreparacion = ordenDeSeleccion.OrdenesDePreparacion;

        List<Mercaderia> mercaderiasAgrupadas = new();
        foreach (var op in ordenesDePreparacion)
        {
            if (op.MercaderiasAPreparar is not null)
                mercaderiasAgrupadas.AddRange(op.MercaderiasAPreparar);
        }

        return mercaderiasAgrupadas
                .OrderBy(m => m.Ubicacion.Sector)
                .ThenBy(m => m.Ubicacion.Posicion)
                .ThenBy(m => m.Ubicacion.Fila)
                .GroupBy(m => m.Ubicacion.ToString())
                .SelectMany(grupo => grupo)
                .ToList();
    }

    public Resultado<bool> ConfirmarSeleccion(long nroOrdenSeleccion)
    {
        OrdenDeSeleccion? os = _ordenesDeSeleccion
            .Find(os => os.Numero == nroOrdenSeleccion);

        if (os is not null)
        {
            os.OrdenesDePreparacion.ForEach(op =>
            {
                op.Estado = OrdenDePreparacionEstado.EnPreparacion;
                op.MercaderiasAPreparar?.ForEach(mercaderia =>
                {
                    mercaderia.Estado = MercaderiaEstado.EnPreparacion;
                });
            });
            os.Estado = OrdenDeSeleccionEstado.APreparar;

            _ordenesDeSeleccion.Remove(os);
            _ordenesDeSeleccion.Add(os);
        }

        return new Resultado<bool>(
            true,
            "Seleccion Confirmada.\n\n" +
            "Se ha realizado la baja del Stock seleccionado.",
            true
        );
    }
}