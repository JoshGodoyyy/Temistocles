using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temistocles.Entity;

namespace Temistocles.DAO {
    public class AvaliacaoDAO {
        private static string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public AvaliacaoEntity CriarAvaliacao(AvaliacaoEntity cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into avaliacoes (idcliente, peso, estatura, torax, cintura, abdomen, quadril, bracodireito, bracoesquerdo, antebracodireito, antebracoesquerdo, coxadireita, coxaesquerda, panturrilhadireita, panturrilhaesquerda, dataavaliacao) values (@idcliente, @peso, @estatura, @torax, @cintura, @abdomen, @quadril, @bracodireito, @bracoesquerdo, @antebracodireito, @antebracoesquerdo, @coxadireita, @coxaesquerda, @panturrilhadireita, @panturrilhaesquerda, @dataavaliacao)";
                command.Parameters.AddWithValue("idcliente", cliente.IdCliente);
                command.Parameters.AddWithValue("peso", cliente.Peso);
                command.Parameters.AddWithValue("estatura", cliente.Estatura);
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

        public List<AvaliacaoEntity> SelecionarAvaliacao(int idCliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from avaliacoes where idcliente = @idcliente order by id desc limit 1";
                command.Parameters.AddWithValue("idcliente", idCliente);

                reader = command.ExecuteReader();
                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();

                while(reader.Read()) {
                    AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        IdCliente = Convert.ToInt32(reader["idcliente"]),
                        Peso = Convert.ToDouble(reader["peso"]),
                        Estatura = Convert.ToDouble(reader["estatura"]),
                        Torax = Convert.ToDouble(reader["torax"]),
                        Cintura = Convert.ToDouble(reader["cintura"]),
                        Abdomen = Convert.ToDouble(reader["abdomen"]),
                        Quadril = Convert.ToDouble(reader["quadril"]),
                        BracoDireito = Convert.ToDouble(reader["bracodireito"]),
                        BracoEsquerdo = Convert.ToDouble(reader["bracoesquerdo"]),
                        AntebracoDireito = Convert.ToDouble(reader["antebracodireito"]),
                        AntebracoEsquerdo = Convert.ToDouble(reader["antebracoesquerdo"]),
                        CoxaDireita = Convert.ToDouble(reader["coxadireita"]),
                        CoxaEsquerda = Convert.ToDouble(reader["coxaesquerda"]),
                        PanturrilhaDireita = Convert.ToDouble(reader["panturrilhadireita"]),
                        PanturrilhaEsquerda = Convert.ToDouble(reader["panturrilhaesquerda"]),
                        DataAvaliacao = Convert.ToDateTime(reader["dataavaliacao"]),
                    };

                    avaliacoes.Add(avaliacao);
                }

                return avaliacoes;
            }
        }

        public List<AvaliacaoEntity> ListarAvaliacao(DateTime data) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from avaliacoes where dataavaliacao = @data";
                command.Parameters.AddWithValue("data", data);

                reader = command.ExecuteReader();
                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();

                while(reader.Read()) {
                    AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        IdCliente = Convert.ToInt32(reader["idcliente"]),
                        Peso = Convert.ToDouble(reader["peso"]),
                        Estatura = Convert.ToDouble(reader["estatura"]),
                        Torax = Convert.ToDouble(reader["torax"]),
                        Cintura = Convert.ToDouble(reader["cintura"]),
                        Abdomen = Convert.ToDouble(reader["abdomen"]),
                        Quadril = Convert.ToDouble(reader["quadril"]),
                        BracoDireito = Convert.ToDouble(reader["bracodireito"]),
                        BracoEsquerdo = Convert.ToDouble(reader["bracoesquerdo"]),
                        AntebracoDireito = Convert.ToDouble(reader["antebracodireito"]),
                        AntebracoEsquerdo = Convert.ToDouble(reader["antebracoesquerdo"]),
                        CoxaDireita = Convert.ToDouble(reader["coxadireita"]),
                        CoxaEsquerda = Convert.ToDouble(reader["coxaesquerda"]),
                        PanturrilhaDireita = Convert.ToDouble(reader["panturrilhadireita"]),
                        PanturrilhaEsquerda = Convert.ToDouble(reader["panturrilhaesquerda"]),
                        DataAvaliacao = Convert.ToDateTime(reader["dataavaliacao"]),
                    };
                    avaliacoes.Add(avaliacao);
                }

                return avaliacoes;
            }
        }

        public List<AvaliacaoEntity> Historico(int idCliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from avaliacoes where idcliente = @idcliente";
                command.Parameters.AddWithValue("idcliente", idCliente);

                reader = command.ExecuteReader();
                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();

                while(reader.Read()) {
                    AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                        Id = Convert.ToInt32(reader["id"]),
                        IdCliente = Convert.ToInt32(reader["idcliente"]),
                        Peso = Convert.ToDouble(reader["peso"]),
                        Estatura = Convert.ToDouble(reader["estatura"]),
                        Torax = Convert.ToDouble(reader["torax"]),
                        Cintura = Convert.ToDouble(reader["cintura"]),
                        Abdomen = Convert.ToDouble(reader["abdomen"]),
                        Quadril = Convert.ToDouble(reader["quadril"]),
                        BracoDireito = Convert.ToDouble(reader["bracodireito"]),
                        BracoEsquerdo = Convert.ToDouble(reader["bracoesquerdo"]),
                        AntebracoDireito = Convert.ToDouble(reader["antebracodireito"]),
                        AntebracoEsquerdo = Convert.ToDouble(reader["antebracoesquerdo"]),
                        CoxaDireita = Convert.ToDouble(reader["coxadireita"]),
                        CoxaEsquerda = Convert.ToDouble(reader["coxaesquerda"]),
                        PanturrilhaDireita = Convert.ToDouble(reader["panturrilhadireita"]),
                        PanturrilhaEsquerda = Convert.ToDouble(reader["panturrilhaesquerda"]),
                        DataAvaliacao = Convert.ToDateTime(reader["dataavaliacao"]),
                    };

                    avaliacoes.Add(avaliacao);
                }

                return avaliacoes;
            }
        }

        public AvaliacaoEntity EditarAvaliacao(AvaliacaoEntity cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update avaliacoes set peso = @peso, estatura = @estatura, torax = @torax, cintura = @cintura, abdomen = @abdomen, quadril = @quadril, bracodireito = @bracodireito, bracoesquerdo = @bracoesquerdo, antebracodireito = @antebracodireito, antebracoesquerdo = @antebracoesquerdo, coxadireita = @coxadireita, coxaesquerda = @coxaesquerda, panturrilhadireita = @panturrilhadireita, panturrilhaesquerda = @panturrilhaesquerda where id = @id";
                command.Parameters.AddWithValue("id", cliente.Id);
                command.Parameters.AddWithValue("peso", cliente.Peso);
                command.Parameters.AddWithValue("estatura", cliente.Estatura);
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

        public int RemoverAvaliacao(int id) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from avaliacoes where id = @id";
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
                
                return id;
            }
        }
    }
}
