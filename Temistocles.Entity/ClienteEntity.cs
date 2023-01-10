namespace Temistocles.Entity {
    public class ClienteEntity {
        public int Id { get; set; }
        public string Nome { get; set; }
        public System.DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
        public double IMC { get; set; }
        public string Resultado { get; set; }
        public double Torax { get; set; }
        public double Cintura { get; set; }
        public double Abdomen { get; set; }
        public double Quadril { get; set; }
        public double BracoDireito { get; set; }
        public double BracoEsquerdo { get; set; }
        public double AntebracoDireito { get; set; }
        public double AntebracoEsquerdo { get; set; }
        public double CoxaDireita { get; set; }
        public double CoxaEsquerda { get; set; }
        public double PanturrilhaDireita { get; set; }
        public double PanturrilhaEsquerda { get; set; }
        public System.DateTime DataAvaliacao { get; set; }
        public bool EstaAtivo { get; set; }
    }
}
