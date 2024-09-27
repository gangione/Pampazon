using Pampazon.Entities;
using Pampazon.ModuloCompartido;

namespace Pampazon.ModuloVentas.Clientes
{
    public class AbmClientesModel
    {
        private readonly List<ClienteEntity> _clientes;
        public AbmClientesModel()
        {
            _clientes = new List<ClienteEntity>()
            {
                new ()
                {
                    Numero = 1,
                    Cuit = "20397623778",
                    Nombre = "Mercadito S.A",
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
        public List<ClienteEntity> ObtenerTodos()
        {
            return _clientes;
        }

        public Resultado<ClienteEntity> Guardar(ClienteEntity cliente)
        {
            if (_clientes.Contains(cliente))
                return new Resultado<ClienteEntity>(false, "Ya existe un cliente con ese Numero.", cliente);

            foreach (var c in _clientes)
            {
                if (cliente.Cuit == c.Cuit)
                    return new Resultado<ClienteEntity>(
                        false,
                        "Ya existe un cliente con ese CUIT.",
                        cliente
                    );
            }

            _clientes.Add(cliente);

            return new Resultado<ClienteEntity>(true, "El Cliente se guardó correctamente.", cliente);
        }

        public Resultado<ClienteEntity> Actualizar(ClienteEntity cliente)
        {
            if (!_clientes.Contains(cliente))
                return new Resultado<ClienteEntity>(false, "No existe un cliente con ese Numero", cliente);

            int indice = _clientes.IndexOf(cliente);

            _clientes[indice] = cliente;

            return new Resultado<ClienteEntity>(true, "El Cliente se actualizó correctamente.", cliente);
        }

        public Resultado<ClienteEntity> Eliminar(ClienteEntity cliente)
        {
            if (!_clientes.Contains(cliente))
                return new Resultado<ClienteEntity>(false, "El Cliente no existe.", cliente);

            _clientes.Remove(cliente);

            return new Resultado<ClienteEntity>(true, "El Cliente se eliminó correctamente.", cliente);
        }
    }
}