using System.Collections.Generic;
using Temistocles.DAO;
using Temistocles.Entity;

namespace Temistocles.Model {
    public class BalancoModel {
        public static List<BalancoEntity> ListarTransacoes() {
            return new BalancoDAO().ListarTransacoes();
        }

        public static List<BalancoEntity> ListarTipo(string tipo) {
            return new BalancoDAO().ListarTipo(tipo);
        }
    }
}
