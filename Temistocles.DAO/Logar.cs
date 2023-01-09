using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Temistocles.Entity;

namespace Temistocles.DAO {
    public class Logar {
        private static string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<LoginEntity> Login(LoginEntity login) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from usuarios where usuario = @usuario and senha = @senha";
                command.Parameters.AddWithValue("usuario", login.Usuario);
                command.Parameters.AddWithValue("senha", login.Senha);
                reader = command.ExecuteReader();

                List<LoginEntity> usuarios = new List<LoginEntity>();
                if(reader.HasRows) {
                    while(reader.Read()) {
                        LoginEntity usuario = new LoginEntity() {
                            Id = Convert.ToInt32(reader["id"]),
                            Usuario = Convert.ToString(reader["usuario"]),
                            Senha = Convert.ToString(reader["senha"])
                        };
                        usuarios.Add(usuario);
                    }
                }

                return usuarios;
            }
        }
    }
}
