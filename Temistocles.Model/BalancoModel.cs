using System;
using System.Collections.Generic;
using Temistocles.DAO;
using Temistocles.Entity;

namespace Temistocles.Model {
    public class BalancoModel {
        public static List<BalancoEntity> Pesquisar(string pesquisa) {
            return new BalancoDAO().Pesquisar(pesquisa);
        }

        public static List<BalancoEntity> ListarPorMes(string tipo, DateTime diaMinimo, DateTime diaMaximo) {
            return new BalancoDAO().ListarPorMes(tipo, diaMinimo, diaMaximo);
        }

        public static BalancoEntity InserirItem(BalancoEntity item) {
            return new BalancoDAO().Inserir(item);
        }

        public static BalancoEntity EditarItem(BalancoEntity item) {
            return new BalancoDAO().EditarItem(item);
        }
    }
}
