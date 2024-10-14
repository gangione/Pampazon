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
                Estado = OrdenDeSeleccionEstado.APreparar,
                OrdenesASeleccionar = new()
                {
                    new()
                    {
                        Numero = 1,
                        MercaderiasAPreparar = new ()
                        {
                            new ()
                            {
                                SKU = "AA-10",
                                Descripcion = "Cemento",
                                Cantidad = 50,
                                Estado = MercaderiaEstado.EnPreparacion
                            },
                            new ()
                            {
                                SKU = "AB-20",
                                Descripcion = "Arena",
                                Cantidad = 150,
                                Estado = MercaderiaEstado.EnPreparacion
                            },
                            new ()
                            {
                                SKU = "AC-30",
                                Descripcion = "Ladrillos",
                                Cantidad = 500,
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
            .Where(os => os.Estado == OrdenDeSeleccionEstado.APreparar)
            .OrderBy(os => os.Prioridad)
            .OrderByDescending(os => os.FechaADespachar)
            .FirstOrDefault();
    }
    public void ConfirmarEmpaquetado(long numeroOrdenSeleccion)
    {
        _ordenesDeSeleccion.ForEach(os =>
        {
            if (os.Numero == numeroOrdenSeleccion)
            {
                os.Estado = OrdenDeSeleccionEstado.Cumplida;
                os.OrdenesASeleccionar.ForEach(op =>
                {
                    op.Estado = OrdenDePreparacionEstado.Preparada;
                    op.MercaderiasAPreparar?.ForEach(m =>
                    {
                        m.Estado = MercaderiaEstado.EnDespacho;
                    });
                });
            }
        });
    }
}