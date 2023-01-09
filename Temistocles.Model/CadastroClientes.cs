using Temistocles.Entity;
using Temistocles.DAO;

namespace Temistocles.Model {
    public class CadastroClientes {
        public ClienteEntity Cliente(ClienteEntity cliente) {
            return new Banco().CadastrarCliente(cliente);
        }
    }
}
