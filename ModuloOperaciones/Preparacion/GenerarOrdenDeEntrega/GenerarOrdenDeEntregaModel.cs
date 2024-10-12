using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Dtos;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Enums;

namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;
public class GenerarOrdenDeEntregaModel
{
    private List<OrdenDeSeleccion> _ordenesDeSeleccion;
    public GenerarOrdenDeEntregaModel()
    {
        _ordenesDeSeleccion = new()
        {
            new ()
            {
                Numero = 1,
                Prioridad = Prioridad.Alta,
                FechaADespachar = DateTime.Now.AddDays(1),
                Estado = OrdenDeSeleccionEstado.Cumplida,
                OrdenesASeleccionar = new()
                {
                    new()
                    {
                        Numero = 1,
                        MercaderiasAPreparar = new ()
                        {
                            new ()
                            {
                                Descripcion = "Cemento",
                                Cantidad = "50 bolsas",
                                Ubicacion = "12-43-2",
                                Estado = MercaderiaEstado.EnPreparacion
                            },
                            new ()
                            {
                                Descripcion = "Arena",
                                Cantidad = "150 bolsas",
                                Ubicacion = "12-43-2",
                                Estado = MercaderiaEstado.EnPreparacion
                            },
                            new ()
                            {
                                Descripcion = "Ladrillos",
                                Cantidad = "500 unidades",
                                Ubicacion = "12-43-2",
                                Estado = MercaderiaEstado.EnPreparacion
                            }
                        }
                    }
                },
            }
        };
    }

    public OrdenDeSeleccion? ObtenerSiguienteOrdenAEmpaquetar()
    {
        return _ordenesDeSeleccion
            .Where(os => os.Estado == OrdenDeSeleccionEstado.Cumplida)
            .OrderBy(os => os.Prioridad)
            .OrderByDescending(os => os.FechaADespachar)
            .FirstOrDefault();
    }
}