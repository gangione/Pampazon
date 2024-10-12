using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Dtos;
using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias.Enums;

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
                MercaderiasASeleccionar = new()
                {
                    new ()
                    {
                        Descripcion = "Cemento",
                        Cantidad = "50 bolsas",
                        Ubicacion = "12-43-2",
                        Estado = MercaderiaEstado.EnAlmacen
                    },
                    new ()
                    {
                        Descripcion = "Arena",
                        Cantidad = "150 bolsas",
                        Ubicacion = "12-43-2",
                        Estado = MercaderiaEstado.EnAlmacen
                    },
                    new ()
                    {
                        Descripcion = "Ladrillos",
                        Cantidad = "500 unidades",
                        Ubicacion = "12-43-2",
                        Estado = MercaderiaEstado.EnAlmacen
                    }
                }
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
}