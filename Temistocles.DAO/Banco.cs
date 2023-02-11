using Temistocles.Entity;
using System.Data.SQLite;
using System.Collections.Generic;
using System;

namespace Temistocles.DAO {
    public class Banco {
        private static string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public ClienteEntity CadastrarCliente(ClienteEntity cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into clientes (nome, nascimento, endereco, contato, sexo, datamatricula, servico, valor, estaativo) values (@nome, @nascimento, @endereco, @contato, @sexo, @datamatricula, @servico, @valor, @estaativo)";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("nascimento", cliente.Nascimento);
                command.Parameters.AddWithValue("endereco", cliente.Endereco);
                command.Parameters.AddWithValue("contato", cliente.Contato);
                command.Parameters.AddWithValue("sexo", cliente.Sexo);
                command.Parameters.AddWithValue("datamatricula", cliente.DataMatricula);
                command.Parameters.AddWithValue("servico", cliente.Servico);
                command.Parameters.AddWithValue("valor", cliente.Valor);
                command.Parameters.AddWithValue("estaativo", cliente.EstaAtivo);
                command.ExecuteNonQuery();

                return cliente;
            }
        }

        public List<ClienteEntity> ListarCliente() {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from clientes";

                List<ClienteEntity> clientes = new List<ClienteEntity>();
                reader = command.ExecuteReader();

                while(reader.Read()) {
                    ClienteEntity cliente = new ClienteEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"]),
                        Nascimento = Convert.ToDateTime(reader["nascimento"]),
                        Endereco = Convert.ToString(reader["endereco"]),
                        Contato = Convert.ToString(reader["contato"]),
                        Sexo = Convert.ToString(reader["sexo"]),
                        DataMatricula = Convert.ToDateTime(reader["datamatricula"]),
                        Servico= Convert.ToString(reader["servico"]),
                        Valor = Convert.ToDouble(reader["valor"]),
                        EstaAtivo = Convert.ToBoolean(reader["estaativo"])
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public List<ClienteEntity> PesquisarCliente(string nome) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from clientes where nome like @nome";
                command.Parameters.AddWithValue("nome", nome);

                reader = command.ExecuteReader();
                List<ClienteEntity> clientes = new List<ClienteEntity>();

                while(reader.Read()) {
                    ClienteEntity cliente = new ClienteEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"])
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public List<ClienteEntity> SelecionarCliente(int id) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from clientes where id = @id";
                command.Parameters.AddWithValue("id", id);

                List<ClienteEntity> clientes = new List<ClienteEntity>();
                reader = command.ExecuteReader();

                while(reader.Read()) {
                    ClienteEntity cliente = new ClienteEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"]),
                        Nascimento = Convert.ToDateTime(reader["nascimento"]),
                        Sexo = Convert.ToString(reader["sexo"]),
                        Endereco = Convert.ToString(reader["endereco"]),
                        Contato = Convert.ToString(reader["contato"]),
                        DataMatricula = Convert.ToDateTime(reader["datamatricula"]),
                        EstaAtivo = Convert.ToBoolean(reader["estaativo"])
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public ClienteEntity EditarCliente(ClienteEntity cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update clientes set nome = @nome, nascimento = @nascimento, sexo = @sexo, endereco = @endereco, contato = @contato, estaativo = @estaativo where id = @id";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("nascimento", cliente.Nascimento);
                command.Parameters.AddWithValue("sexo", cliente.Sexo);
                command.Parameters.AddWithValue("endereco", cliente.Endereco);
                command.Parameters.AddWithValue("contato", cliente.Contato);
                command.Parameters.AddWithValue("estaativo", cliente.EstaAtivo);
                command.Parameters.AddWithValue("servico", cliente.Servico);
                command.Parameters.AddWithValue("valor", cliente.Valor);
                command.Parameters.AddWithValue("id", cliente.Id);
                command.ExecuteNonQuery();
                return cliente;
            }
        }
    }
}
