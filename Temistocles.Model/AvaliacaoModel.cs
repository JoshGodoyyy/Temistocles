using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temistocles.DAO;
using Temistocles.Entity;

namespace Temistocles.Model {
    public class AvaliacaoModel {
        public static AvaliacaoEntity CriarAvaliacao(AvaliacaoEntity avaliacao) {
            return new AvaliacaoDAO().CriarAvaliacao(avaliacao);
        }

        public static List<AvaliacaoEntity> SelecionarAvaliacao(int idCliente) {
            return new AvaliacaoDAO().SelecionarAvaliacao(idCliente);
        }

        public static List<AvaliacaoEntity> ListarAvaliacao(DateTime data) {
            return new AvaliacaoDAO().ListarAvaliacao(data);
        }

        public static List<AvaliacaoEntity> Historico(int idCliente) {
            return new AvaliacaoDAO().Historico(idCliente);
        }

        public static AvaliacaoEntity EditarAvaliacao(AvaliacaoEntity avaliacao) {
            return new AvaliacaoDAO().EditarAvaliacao(avaliacao);
        }

        public static int RemoverAvaliacao(int id) {
            return new AvaliacaoDAO().RemoverAvaliacao(id);
        }

    }
}
