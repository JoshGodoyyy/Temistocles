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

        public List<BalancoEntity> ListarTransacoes() {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from balanco";

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
    }
}
