using Pampazon.Entities;
using Pampazon.Entities.Enums;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloOperaciones.Recepcion.RecibirMercaderia
{
    public class RecepcionarMercaderiaModel
    {
        private List<ClienteEntity> _clientes;
        private List<TransportistaEntity> _transportistas;
        private List<OrdenDeRecepcionEntity> _ordenesDeRecepcion;
        private List<ComprobanteDeRecepcionEntity> _comprobantesDeRecepcion;
        private List<NotaDeEspacioInsuficienteEntity> _notasDeEspacioInsuficiente;
        private List<RemitoEntity> _remitos;

        public RecepcionarMercaderiaModel()
        {
            _clientes = new()
            {
                new ()
                {
                    Numero = 1,
                    Cuit = "30518919349",
                    Nombre = "Mercadito S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678910",
                    Nombre = "Membrana S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
                },
                new ()
                {
                    Numero = 2,
                    Cuit = "12345678911",
                    Nombre = "Empresa S.A",
                    Domicilio = new()
                    {
                        CalleNumero = "Calle Falsa 123",
                        Ciudad = "Buenos Aires",
                        Provincia = "Buenos Aires",
                        CodigoPostal = "0000"
                    }
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
        public List<ClienteEntity> ObtenerClientes()
        {
            return _clientes;
        }
        public List<ClienteEntity> ObtenerClientesPorFiltro(string filtro)
        {
            return _clientes.Where(cliente => cliente.Nombre
                .ToString()
                .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
            ).ToList();
        }
        public List<TransportistaEntity> ObtenerTransportistas()
        {
            return _transportistas;
        }
        public List<TransportistaEntity> ObtenerTransportistasPorFiltro(string filtro)
        {
            return _transportistas.Where(transportista => transportista.NombreYApellido
                .ToString()
                .Contains(filtro, StringComparison.CurrentCultureIgnoreCase)
            ).ToList();
        }
        public Resultado<ComprobanteDeRecepcionEntity> GenerarComprobanteDeRecepcion(ComprobanteDeRecepcionEntity comprobante)
        {
            var resultadoEspacio = ComprobarEspacioCliente(comprobante);

            if (!resultadoEspacio.Exitoso)
                return new Resultado<ComprobanteDeRecepcionEntity>(
                    false,
                    resultadoEspacio.Mensaje,
                    comprobante
                );

            DateTime hoy = DateTime.Now;
            long numeroComprobante = _comprobantesDeRecepcion.LastOrDefault() is null ? 1 :
                _comprobantesDeRecepcion.Last().Numero + 1;
            comprobante.Numero = numeroComprobante;

            long numeroOrden = _comprobantesDeRecepcion.LastOrDefault() is null ? 1 :
                _comprobantesDeRecepcion.Last().Numero + 1;

            OrdenDeRecepcionEntity ordenDeRecepcion = new()
            {
                Numero = numeroOrden,
                Fecha = hoy,
                NumeroComprobante = numeroComprobante,
                MercaderiasAIngresar = comprobante.MercaderiasRecibidas,
                Estado = OrdenDeRecepcionEstados.Pendiente
            };

            RemitoEntity remito = new()
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

            return new Resultado<ComprobanteDeRecepcionEntity>(
                true,
                "Comprobante de Recepcion generado exitosamente!.",
                comprobante
            );
        }
        private Resultado<bool> ComprobarEspacioCliente(ComprobanteDeRecepcionEntity comprobante)
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
        public void GenerarNotaEspacioInsuficiente(ComprobanteDeRecepcionEntity comprobante)
        {

        }
    }
}