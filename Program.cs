using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;
using Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeEntrega;

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

            //Application.Run(new IniciarSesionForm());

            // Admin.
            //Application.Run(new AbmUsuariosForm()); 

            // Proceso IN. Posible nueva funcionalidad del flujo IN para el �rea de de Recepcion.
            //Application.Run(new RecepcionarMercaderiaForm());

            // Proceso OUT.
            //Application.Run(new GenerarOrdenDePreparacionForm());
            //Application.Run(new GenerarOrdenDeSeleccionForm());
            //Application.Run(new SeleccionarMercaderiasForm());
            Application.Run(new GenerarOrdenDeEntregaForm());
            //Application.Run(new GenerarRemitoForm());
        }
    }
}