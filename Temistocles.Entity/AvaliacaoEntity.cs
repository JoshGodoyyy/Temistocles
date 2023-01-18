namespace Temistocles.Entity {
    public class AvaliacaoEntity {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public System.DateTime DataAvaliacao { get; set; }
        public double Peso { get; set; }
        public double Estatura { get; set; }
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
    }
}
