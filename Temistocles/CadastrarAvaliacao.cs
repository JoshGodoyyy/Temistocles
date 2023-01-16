using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class CadastrarAvaliacao : Form {
        string resultado;

        public CadastrarAvaliacao(string resultado) {
            InitializeComponent();
            this.resultado = resultado;
            ListarClientes();
            dataAvaliacaoDt.Value = DateTime.Now;
        }

        public void ListarClientes() {
            try {
                List<ClienteEntity> clientes = new List<ClienteEntity>();
                clientes = ClienteModel.ListarCliente();

                pacientesCb.DataSource = clientes;
                pacientesCb.ValueMember = "id";
                pacientesCb.DisplayMember = "nome";

                int id = 0;
                for(int i = 0; i < clientes.Count; i++) {
                    id = i;
                }

                pacientesCb.SelectedIndex = id;

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if(resultado == "Masculino") {
                if(valor < 20) {
                    resultado = "Abaixo do peso";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 20 && valor <= 24.9) {
                    resultado = "Normal";
                    classificacaoLbl.ForeColor = Color.Green;
                } else if(valor >= 25 && valor < 30) {
                    resultado = "Obesidade leve";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 30 && valor <= 39.9) {
                    resultado = "Obesidade grau II";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else {
                    resultado = "Obesidade mórbida";
                    classificacaoLbl.ForeColor = Color.Red;
                }
            } else {
                if(valor < 19) {
                    resultado = "Abaixo do peso";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 19 && valor <= 23.9) {
                    resultado = "Normal";
                    classificacaoLbl.ForeColor = Color.Green;
                } else if(valor >= 24 && valor < 28.9) {
                    resultado = "Obesidade leve";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 29 && valor <= 38.9) {
                    resultado = "Obesidade grau II";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else {
                    resultado = "Obesidade mórbida";
                    classificacaoLbl.ForeColor = Color.Red;
                }
            }

            classificacaoLbl.Text = resultado;
        }

        public void LimparCampos() {
            pesoNmr.Value = 0;
            estaturaTxt.Clear();
            imcTxt.Clear();
            classificacaoLbl.Text = "";
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

        private void calcularLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CalcularIMC();
        }

        private void salvarBtn_Click(object sender, EventArgs e) {
            try {
                AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                    IdCliente = int.Parse(pacientesCb.SelectedValue.ToString()),
                    Estatura = double.Parse(estaturaTxt.Text),
                    Peso = double.Parse(pesoNmr.Value.ToString()),
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
                    DataAvaliacao = DateTime.Parse(dataAvaliacaoDt.Text.ToString()),
                };

                ClienteModel.CriarAvaliacao(avaliacao);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
        }

        private void cancelarBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void pesoNmr_ValueChanged(object sender, EventArgs e) {
            CalcularIMC();
        }
    }
}
