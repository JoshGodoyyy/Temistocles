using System;
using System.Collections.Generic;
using Temistocles.DAO;
using Temistocles.Entity;

namespace Temistocles.Model {
    public class BalancoModel {
        public static List<BalancoEntity> ListarTransacoes() {
            return new BalancoDAO().ListarTransacoes();
        }

        public static List<BalancoEntity> ListarPorMes(string tipo, DateTime diaMinimo, DateTime diaMaximo) {
            return new BalancoDAO().ListarPorMes(tipo, diaMinimo, diaMaximo);
        }
    }
}
