using Pampazon.Almacenes;
using Pampazon.MenuInicio;
using System.Globalization;

namespace Pampazon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");

            ClienteAlmacen.Leer();
            TransportistaAlmacen.Leer();
            MercaderiaEnStockAlmacen.Leer();
            OrdenDePreparacionAlmacen.Leer();
            OrdenDeSeleccionAlmacen.Leer();
            OrdenDeEntregaAlmacen.Leer();
            RemitoAlmacen.Leer();

            Application.Run(new MenuInicioForm());

            ClienteAlmacen.Grabar();
            TransportistaAlmacen.Grabar();
            MercaderiaEnStockAlmacen.Grabar();
            OrdenDePreparacionAlmacen.Grabar();
            OrdenDeSeleccionAlmacen.Grabar();
            OrdenDeEntregaAlmacen.Grabar();
            RemitoAlmacen.Grabar();

            // Proceso IN. Posible nueva funcionalidad del flujo IN para el área de de Recepcion.
            //Application.Run(new RecepcionarMercaderiaForm());

            // Proceso OUT.
            //Application.Run(new GenerarOrdenDePreparacionForm());
            //Application.Run(new GenerarOrdenDeSeleccionForm());
            //Application.Run(new SeleccionarMercaderiasForm());
            //Application.Run(new GenerarOrdenDeEntregaForm());
            //Application.Run(new GenerarRemitoForm());
        }
    }
}