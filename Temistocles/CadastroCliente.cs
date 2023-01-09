using System;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class CadastroCliente : Form {
        public CadastroCliente() {
            InitializeComponent();
        }

        private void CalcularIMC() {
            double peso, altura, resultado;
            peso = double.Parse(pesoNmr.Text);
            if(estaturaTxt.Text != "") altura = double.Parse(estaturaTxt.Text);
            else altura = 0;
            resultado = peso / Math.Pow(altura, 2);
            imcTxt.Text = resultado.ToString("N2");
            Resultado(resultado);
        }

        public void Resultado(double valor) {
            string resultado;

            if(masculinoRdo.Checked) {
                if(valor < 20) {
                    resultado = "Abaixo do peso";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else if(valor >= 20 && valor <= 24.9) {
                    resultado = "Normal";
                    classificacaoTxt.ForeColor = Color.Green;
                } else if(valor >= 25 && valor < 30) {
                    resultado = "Obesidade leve";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else if(valor >= 30 && valor <= 39.9) {
                    resultado = "Obesidade grau II";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else {
                    resultado = "Obesidade mórbida";
                    classificacaoTxt.ForeColor = Color.Red;
                }
            } else {
                if(valor < 19) {
                    resultado = "Abaixo do peso";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else if(valor >= 19 && valor <= 23.9) {
                    resultado = "Normal";
                    classificacaoTxt.ForeColor = Color.Green;
                } else if(valor >= 24 && valor < 28.9) {
                    resultado = "Obesidade leve";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else if(valor >= 29 && valor <= 38.9) {
                    resultado = "Obesidade grau II";
                    classificacaoTxt.ForeColor = Color.OrangeRed;
                } else {
                    resultado = "Obesidade mórbida";
                    classificacaoTxt.ForeColor = Color.Red;
                }
            }
            
            classificacaoTxt.Text = resultado;
        }

        private void cancelarBtn_Click(object sender, System.EventArgs e) {
            DialogResult dialog = MessageBox.Show("Deseja mesmo fechar esta janela?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes) {
                Close();
            }
        }

        private void salvarBtn_Click(object sender, System.EventArgs e) {
            try {
                ClienteEntity cliente = new ClienteEntity() {
                    Nome = nomeTxt.Text,
                    Idade = int.Parse(idadeNmr.Value.ToString()),
                    Peso = double.Parse(pesoNmr.Value.ToString()),
                    Estatura = double.Parse(estaturaTxt.Text),
                    IMC = double.Parse(imcTxt.Text),
                    Resultado = classificacaoTxt.Text,
                    Torax = double.Parse(toraxTxt.Text),
                    Cintura = double.Parse(cinturaTxt.Text),
                    Abdomen = double.Parse(abdomenTxt.Text),
                    Quadril = double.Parse(quadrilTxt.Text),
                    BracoDireito = double.Parse(bracoDireitoTxt.Text),
                    BracoEsquerdo = double.Parse(bracoEsquerdoTxt.Text),
                    AntebracoDireito = double.Parse(antebracoDireitoTxt.Text),
                    AntebracoEsquerdo = double.Parse(antebracoEsquerdoTxt.Text),
                    CoxaDireita = double.Parse(coxaDireitaTxt.Text),
                    CoxaEsquerda = double.Parse(coxaEsquerdaTxt.Text),
                    PanturrilhaDireita = double.Parse(panturrilhaDireitaTxt.Text),
                    PanturrilhaEsquerda = double.Parse(panturrilhaEsquerdaTxt.Text),
                    DataAvaliacao = DateTime.Parse(dataAvaliacaoDt.Value.ToString()),
                };
                if(masculinoRdo.Checked) cliente.Sexo = "Masculino";
                else cliente.Sexo = "Feminino";

                CadastroClientes.CadastrarCliente(cliente);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();
        }

        private void estaturaTxt_TextChanged(object sender, EventArgs e) {
            if(estaturaTxt.Text == "") return;
            CalcularIMC();
        }

        private void masculinoRdo_CheckedChanged(object sender, EventArgs e) {
            CalcularIMC();
        }

        private void femininoRdo_CheckedChanged(object sender, EventArgs e) {
            CalcularIMC();
        }

        private void LimparCampos() {
            nomeTxt.Clear();
            idadeNmr.Value = 0;
            masculinoRdo.Checked = true;
            pesoNmr.Value = 0;
            estaturaTxt.Clear();
            imcTxt.Clear();
            classificacaoTxt.Text = "";
            toraxTxt.Clear();
            cinturaTxt.Clear();
            abdomenTxt.Clear();
            quadrilTxt.Clear();
            bracoDireitoTxt.Clear();
            bracoEsquerdoTxt.Clear();
            antebracoDireitoTxt.Clear();
            antebracoEsquerdoTxt.Clear();
            coxaDireitaTxt.Clear();
            coxaEsquerdaTxt.Clear();
            panturrilhaDireitaTxt.Clear();
            panturrilhaEsquerdaTxt.Clear();
        }
    }
}
