using Temistocles.Entity;
using System.Data.SQLite;

namespace Temistocles.DAO {
    public class Banco {
        private static string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataAdapter dataAdapter;
        private static SQLiteDataReader reader;

        public ClienteEntity CadastrarCliente(ClienteEntity cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into clientes (nome, idade, sexo, peso, estatura, imc, resultado, torax, cintura, abdomen, quadril, bracodireito, bracoesquerdo, antebracodireito, antebracoesquerdo, coxadireita, coxaesquerda, panturrilhadireita, panturrilhaesquerda, dataavaliacao) values (@nome, @idade, @sexo, @peso, @estatura, @imc, @resultado, @torax, @cintura, @abdomen, @quadril, @bracodireito, @bracoesquerdo, @antebracodireito, @antebracoesquerdo, @coxadireita, @coxaesquerda, @panturrilhadireita, @panturrilhaesquerda, @dataavaliacao)";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("idade", cliente.Idade);
                command.Parameters.AddWithValue("sexo", cliente.Sexo);
                command.Parameters.AddWithValue("peso", cliente.Peso);
                command.Parameters.AddWithValue("estatura", cliente.Estatura);
                command.Parameters.AddWithValue("imc", cliente.IMC);
                command.Parameters.AddWithValue("resultado", cliente.Resultado);
                command.Parameters.AddWithValue("torax", cliente.Torax);
                command.Parameters.AddWithValue("cintura", cliente.Cintura);
                command.Parameters.AddWithValue("abdomen", cliente.Abdomen);
                command.Parameters.AddWithValue("quadril", cliente.Quadril);
                command.Parameters.AddWithValue("bracodireito", cliente.BracoDireito);
                command.Parameters.AddWithValue("bracoesquerdo", cliente.BracoEsquerdo);
                command.Parameters.AddWithValue("antebracodireito", cliente.AntebracoDireito);
                command.Parameters.AddWithValue("antebracoesquerdo", cliente.AntebracoEsquerdo);
                command.Parameters.AddWithValue("coxadireita", cliente.CoxaDireita);
                command.Parameters.AddWithValue("coxaesquerda", cliente.CoxaEsquerda);
                command.Parameters.AddWithValue("panturrilhadireita", cliente.PanturrilhaDireita);
                command.Parameters.AddWithValue("panturrilhaesquerda", cliente.PanturrilhaEsquerda);
                command.Parameters.AddWithValue("dataavaliacao", cliente.DataAvaliacao);
                command.ExecuteNonQuery();
                return cliente;
            }
        }
    }
}
