using Temistocles.Entity;
using Temistocles.DAO;

namespace Temistocles.Model {
    public class CadastroClientes {
        public static ClienteEntity CadastrarCliente(ClienteEntity cliente) {
            return new Banco().CadastrarCliente(cliente);
        }
    }
}
