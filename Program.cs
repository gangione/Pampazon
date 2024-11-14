using Pampazon.Almacenes;
using Pampazon.MenuInicio;

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

            // Limpiar los datos de Prueba. Dejar solo los Correspondientes y
            // descomentar para Demo con Pampazon.
            //MigrarDatabaseInicial();
            //CargarDatabaseProd();

            CargarDatabaseProd();
            //CargarDatabaseTest();

            //Application.Run(new IniciarSesionForm());
            Application.Run(new MenuInicioForm());

            // Proceso IN. Posible nueva funcionalidad del flujo IN para el área de de Recepcion.
            //Application.Run(new RecepcionarMercaderiaForm());

            // Proceso OUT.
            //Application.Run(new GenerarOrdenDePreparacionForm());
            //Application.Run(new GenerarOrdenDeSeleccionForm());
            //Application.Run(new SeleccionarMercaderiasForm());
            //Application.Run(new GenerarOrdenDeEntregaForm());
            //Application.Run(new GenerarRemitoForm());
        }

        /// <summary>
        /// Método para Iniciar el Sistema en modo Testing.
        /// Para simular un flujo completo de OUT.
        /// </summary>
        private static void CargarDatabaseTest()
        {
            // Cargar Seeders del sistema para Testing.
            // Repositorios de Prueba.

            // Archivo de Clientes.
            ClienteAlmacen.LeerDatosDePrueba();

            // Archivo de Transportistas.
            TransportistaAlmacen.LeerDatosDePrueba();

            // Archivo de Mercaderias en Stock.
            MercaderiaEnStockAlmacen.LeerDatosDePrueba();
        }
        /// <summary>
        /// Método para Iniciar el sistema con una base inicial de Pampazon con 
        /// una migración inicial de datos de Clientes, Transportistas y Mercaderías.
        /// </summary>
        private static void MigrarDatabaseInicial()
        {
            // Repositorios
            ClienteAlmacen.LeerDatosDePrueba();
            TransportistaAlmacen.LeerDatosDePrueba();
            MercaderiaEnStockAlmacen.LeerDatosDePrueba();

            // Grabar los Datos de la migración del sistema para comenzar a utilizar
            ClienteAlmacen.Grabar();
            TransportistaAlmacen.Grabar();
            MercaderiaEnStockAlmacen.Grabar();
        }
        /// <summary>
        /// Método para Iniciar el sistema con su base de datos Productiva
        /// Luego de correr la migración inicial del Sistema.
        /// </summary>
        private static void CargarDatabaseProd()
        {
            // Cargar Repositorios Productivos
            ClienteAlmacen.Leer();
            TransportistaAlmacen.Leer();
            MercaderiaEnStockAlmacen.Leer();
            OrdenDePreparacionAlmacen.Leer();
            OrdenDeSeleccionAlmacen.Leer();
            OrdenDeEntregaAlmacen.Leer();
            RemitoAlmacen.Leer();
        }
    }
}