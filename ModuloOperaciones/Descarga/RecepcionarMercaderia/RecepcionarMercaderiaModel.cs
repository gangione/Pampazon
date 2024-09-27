using Pampazon.Entities;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloOperaciones.Recepcion.RecibirMercaderia
{
    public class RecepcionarMercaderiaModel
    {
        private List<ClienteEntity> _clientes;
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
        }
        public List<ClienteEntity> ObtenerClientes()
        {
            return _clientes;
        }
        public List<ClienteEntity> ObtenerClientesPorFiltro(string filtro)
        {
            return _clientes;
        }
        public Resultado<bool> ComprobarEspacioCliente()
        {
            return new Resultado<bool>(
                false,
                "El cliente no tiene espacio en almacén. Genere una Nota de Espacio Insuficiente",
                false
            );
        }
        public void GenerarNotaEspacioInsuficiente()
        {

        }
        public void GenerarOrdenDePreparacion()
        {

        }
        public void GenerarComprobanteDeRecepcion()
        {

        }
        public void GuardarRemito()
        {

        }
    }
}
