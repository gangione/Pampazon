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
                                Estado = MercaderiaEstado.ASeleccionar
                            },
                            new ()
                            {
                                SKU = "AB-20",
                                Descripcion = "Ladrillos",
                                Cantidad = 450,
                                Ubicacion = new Ubicacion(1,1,1),
                                Estado = MercaderiaEstado.ASeleccionar
                            },
                            new ()
                            {
                                SKU = "AB-20",
                                Descripcion = "Ladrillos",
                                Cantidad = 50,
                                Ubicacion = new Ubicacion(1,1,2),
                                Estado = MercaderiaEstado.ASeleccionar
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Arena",
                                Cantidad = 25,
                                Ubicacion = new Ubicacion(1,1,2),
                                Estado = MercaderiaEstado.ASeleccionar
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Arena",
                                Cantidad = 25,
                                Ubicacion = new Ubicacion(1,1,2),
                                Estado = MercaderiaEstado.ASeleccionar
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Arena",
                                Cantidad = 100,
                                Ubicacion = new Ubicacion(1,1,3),
                                Estado = MercaderiaEstado.ASeleccionar
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

    public OrdenDeSeleccion ObtenerOrdenDeSeleccionPorNumero(long numero)
    {
        return _ordenesDeSeleccion
            .First(os => os.Numero == numero);
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