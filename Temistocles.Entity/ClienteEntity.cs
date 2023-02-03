namespace Temistocles.Entity {
    public class ClienteEntity {
        public int Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public string Sexo { get; set; }
        public System.DateTime DataMatricula { get; set; }
        public string Servico { get; set; }
        public double Valor { get; set; }
        public bool EstaAtivo { get; set; }
    }
}
