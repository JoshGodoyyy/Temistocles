using Temistocles.Entity;
using Temistocles.DAO;
using System.Collections.Generic;

namespace Temistocles.Model {
    public class ClienteModel {
        public static ClienteEntity CadastrarCliente(ClienteEntity cliente) {
            return new Banco().CadastrarCliente(cliente);
        }

        public static List<ClienteEntity> ListarCliente() {
            return new Banco().ListarCliente();
        }

        public static List<ClienteEntity> PesquisarCliente(string nome) {
            return new Banco().PesquisarCliente(nome);
        }

        public static List<ClienteEntity> SelecionarCliente(int id) {
            return new Banco().SelecionarCliente(id);
        }

        public static ClienteEntity EditarCliente(ClienteEntity cliente) {
            return new Banco().EditarCliente(cliente);
        }

        public static AvaliacaoEntity CriarAvaliacao(AvaliacaoEntity avaliacao) {
            return new Banco().CriarAvaliacao(avaliacao);
        }

        public static List<AvaliacaoEntity> SelecionarAvaliacao(int idCliente) {
            return new Banco().SelecionarAvaliacao(idCliente);
        }

        public static List<AvaliacaoEntity> Historico(int idCliente) {
            return new Banco().Historico(idCliente);
        }
    }
}
