using System;
using System.Drawing;
using System.Windows.Forms;

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
    }
}
