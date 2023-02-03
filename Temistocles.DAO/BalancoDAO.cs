using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Temistocles.Entity;

namespace Temistocles.DAO {
    public class BalancoDAO {
        private static readonly string path = "Data Source =" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public List<BalancoEntity> Pesquisar(string pesquisa) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from balanco where descricao like @pesquisa";
                command.Parameters.AddWithValue("pesquisa", pesquisa);

                reader = command.ExecuteReader();
                List<BalancoEntity> extrato = new List<BalancoEntity>();
                while(reader.Read()) {
                    BalancoEntity item = new BalancoEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        Valor = Convert.ToDouble(reader["valor"]),
                        Tipo = Convert.ToString(reader["tipo"]),
                        Data = Convert.ToDateTime(reader["data"]),
                    };
                    extrato.Add(item);
                }
                return extrato;
            }
        }

        public List<BalancoEntity> ListarPorMes(string tipo, DateTime menorData, DateTime maiorData) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from balanco where tipo = @tipo and data between @dataminima and @datamaxima";
                command.Parameters.AddWithValue("tipo", tipo);
                command.Parameters.AddWithValue("dataminima", menorData);
                command.Parameters.AddWithValue("datamaxima", maiorData);

                reader = command.ExecuteReader();
                List<BalancoEntity> extrato = new List<BalancoEntity>();
                while(reader.Read()) {
                    BalancoEntity item = new BalancoEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        Valor = Convert.ToDouble(reader["valor"]),
                        Tipo = Convert.ToString(reader["tipo"]),
                        Data = Convert.ToDateTime(reader["data"]),
                    };
                    extrato.Add(item);
                }
                return extrato;
            }
        }

        public BalancoEntity Inserir(BalancoEntity item) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into balanco (descricao, valor, data, tipo) values (@descricao, @valor, @data, @tipo)";
                command.Parameters.AddWithValue("descricao", item.Descricao);
                command.Parameters.AddWithValue("valor", item.Valor);
                command.Parameters.AddWithValue("data", item.Data);
                command.Parameters.AddWithValue("tipo", item.Tipo);
                command.ExecuteNonQuery();
                return item;
            }
        }

        public BalancoEntity EditarItem(BalancoEntity item) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update balanco set descricao = @descricao, valor = @valor, data = @data, tipo = @tipo where id = @id";
                command.Parameters.AddWithValue("descricao", item.Descricao);
                command.Parameters.AddWithValue("valor", item.Valor);
                command.Parameters.AddWithValue("data", item.Data);
                command.Parameters.AddWithValue("tipo", item.Tipo);
                command.Parameters.AddWithValue("id", item.Id);
                command.ExecuteNonQuery();
                return item;
            }
        }
    }
}
