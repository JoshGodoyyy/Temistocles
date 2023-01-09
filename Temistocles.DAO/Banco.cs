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
                command.CommandText = "";
                return cliente;
            }
        }
    }
}
