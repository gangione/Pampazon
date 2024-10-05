using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Dtos;
using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Enums;
using Pampazon.ModuloOperaciones.Recepcion.RecepcionarMercaderia.Utilidades;

namespace Pampazon.ModuloOperaciones.Recepcion.RecibirMercaderia
{
    public class RecepcionarMercaderiaModel
    {
        private List<Cliente> _clientes;
        private List<Transportista> _transportistas;
        private List<OrdenDeRecepcion> _ordenesDeRecepcion;
        private List<ComprobanteDeRecepcion> _comprobantesDeRecepcion;
        private List<NotaDeEspacioInsuficiente> _notasDeEspacioInsuficiente;
        private List<Remito> _remitos;

        public RecepcionarMercaderiaModel()
        {
            _clientes = new()
            {
                new ()
                {
                    Numero = 1,
                    Cuit = "30518919349",
                    Nombre = "Mercadito S.A"
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678910",
                    Nombre = "Membrana S.A"
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678911",
                    Nombre = "Empresa S.A"
                }
            };
            _transportistas = new()
            {
                new()
                {
                    DNI = "12.123.123",
                    NombreYApellido = "Ricardo"
                },
                new()
                {
                    DNI = "12.123.123",
                    NombreYApellido = "Daiana"
                },
                new()
                {
                    DNI = "12.123.123",
                    NombreYApellido = "Ariadna"
                },

            };

            _ordenesDeRecepcion = new();
            _comprobantesDeRecepcion = new();
            _remitos = new();
        }
        public List<Cliente> ObtenerClientes()
        {
            return _clientes;
        }
        public List<Cliente> ObtenerClientesPorFiltro(string filtro)
        {
            return _clientes.Where(cliente => cliente.Nombre
                .ToString()
                .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
            ).ToList();
        }
        public List<Transportista> ObtenerTransportistas()
        {
            return _transportistas;
        }
        public List<Transportista> ObtenerTransportistasPorFiltro(string filtro)
        {
            return _transportistas.Where(transportista => transportista.NombreYApellido
                .ToString()
                .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
            ).ToList();
        }
        public Resultado<ComprobanteDeRecepcion> GenerarComprobanteDeRecepcion(ComprobanteDeRecepcion comprobante)
        {
            var resultadoEspacio = ComprobarEspacioCliente(comprobante);

            if (!resultadoEspacio.Exitoso)
                return new Resultado<ComprobanteDeRecepcion>(
                    false,
                    resultadoEspacio.Mensaje,
                    comprobante
                );

            DateTime hoy = DateTime.Now;
            long numeroComprobante = _comprobantesDeRecepcion.LastOrDefault() is null ? 1 :
                _comprobantesDeRecepcion.Last().Numero + 1;
            comprobante.Numero = numeroComprobante;

            long numeroOrden = _ordenesDeRecepcion.LastOrDefault() is null ? 1 :
                _comprobantesDeRecepcion.Last().Numero + 1;

            OrdenDeRecepcion ordenDeRecepcion = new()
            {
                Numero = numeroOrden,
                Fecha = hoy,
                NumeroComprobante = numeroComprobante,
                MercaderiasAIngresar = comprobante.MercaderiasRecibidas,
                Estado = OrdenDeRecepcionEstado.Pendiente
            };

            Remito remito = new()
            {
                Numero = comprobante.NumeroRemito,
                Fecha = hoy,
                Transportista = comprobante.Transportista,
                Observaciones = comprobante.Observaciones,
                Emisor = comprobante.Cliente.Nombre,
                Receptor = "PAMPAZON S.A."
            };

            _comprobantesDeRecepcion.Add(comprobante);
            _ordenesDeRecepcion.Add(ordenDeRecepcion);
            _remitos.Add(remito);

            return new Resultado<ComprobanteDeRecepcion>(
                true,
                "Comprobante de Recepcion generado exitosamente!.",
                comprobante
            );
        }
        private Resultado<bool> ComprobarEspacioCliente(ComprobanteDeRecepcion comprobante)
        {
            decimal totalMercaderias = 0;
            comprobante.MercaderiasRecibidas
                .ForEach(mercaderia => totalMercaderias += mercaderia.Cantidad);

            if (totalMercaderias > 10)
                return new Resultado<bool>(
                    false,
                    "El cliente no tiene espacio en almacén. Genere una Nota de Espacio Insuficiente",
                    false
                );

            return new Resultado<bool>(
                true,
                "El cliente tiene espacio en almacén.",
                true
            );
        }
        public void GenerarNotaEspacioInsuficiente(ComprobanteDeRecepcion comprobante)
        {

        }
    }
}