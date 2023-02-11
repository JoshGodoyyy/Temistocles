using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Avaliacoes : Form {

        readonly Main main;
        private string resultado;

        public Avaliacoes() {
            InitializeComponent();
            ListarClientes();
        }

        public Avaliacoes(Main main) {
            InitializeComponent();
            ListarClientes();
            this.main = main;
        }

        private void ListarClientes() {
            try {
                List<ClienteEntity> clientes = new List<ClienteEntity>();
                clientes = ClienteModel.ListarCliente();

                clientesLst.DataSource = clientes;
                clientesLst.ValueMember = "id";
                clientesLst.DisplayMember = "nome";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos() {
            estaturaTxt.Clear();
            pesoNmr.Value = 0;
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

        private void CalcularIMC() {
            double peso, altura, resultado;
            peso = double.Parse(pesoNmr.Text);
            if(peso != 0) {
                if(estaturaTxt.Text != "") altura = double.Parse(estaturaTxt.Text);
                else altura = 0;
                resultado = peso / Math.Pow(altura, 2);
                imcTxt.Text = resultado.ToString("N2");
                Resultado(resultado);
            } else classificacaoLbl.Text = "Não definido";
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

        private void clientesLst_SelectedIndexChanged(object sender, EventArgs e) {
            LimparCampos();
            var aux = clientesLst.SelectedValue;
            if(clientesLst.SelectedValue != aux) {
                List<AvaliacaoEntity> avaliacao = new List<AvaliacaoEntity>();
                avaliacao = AvaliacaoModel.SelecionarAvaliacao(int.Parse(clientesLst.SelectedValue.ToString()));

                foreach(var cliente in avaliacao) {
                    pesoNmr.Value = decimal.Parse(cliente.Peso.ToString());
                    estaturaTxt.Text = cliente.Estatura.ToString();
                    toraxTxt.Text = cliente.Torax.ToString();
                    cinturaTxt.Text = cliente.Cintura.ToString();
                    abdomenTxt.Text = cliente.Abdomen.ToString();
                    quadrilTxt.Text = cliente.Quadril.ToString();
                    bracoDireitoTxt.Text = cliente.BracoDireito.ToString();
                    bracoEsquerdoTxt.Text = cliente.BracoEsquerdo.ToString();
                    antebracoDireitoTxt.Text = cliente.AntebracoDireito.ToString();
                    antebracoEsquerdoTxt.Text = cliente.AntebracoEsquerdo.ToString();
                    coxaDireitaTxt.Text = cliente.CoxaDireita.ToString();
                    coxaEsquerdaTxt.Text = cliente.CoxaEsquerda.ToString();
                    panturrilhaDireitaTxt.Text = cliente.PanturrilhaDireita.ToString();
                    panturrilhaEsquerdaTxt.Text = cliente.PanturrilhaEsquerda.ToString();
                    dataAvaliacaoDt.Value = DateTime.Parse(cliente.DataAvaliacao.ToString());
                }

                CalcularIMC();
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void novaBtn_Click(object sender, EventArgs e) {
            try {
                AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                    IdCliente = int.Parse(clientesLst.SelectedValue.ToString()),
                    Peso = double.Parse(pesoNmr.Value.ToString()),
                    Estatura = double.Parse(estaturaTxt.Text),
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
                    DataAvaliacao = DateTime.Parse(dataAvaliacaoDt.Text.ToString())
                };

                AvaliacaoModel.CriarAvaliacao(avaliacao);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarClientes();
        }

        private void historicoBtn_Click(object sender, EventArgs e) {
            Historicos historico = new Historicos(int.Parse(clientesLst.SelectedValue.ToString()));
            historico.MdiParent = main;
            historico.Show();
        }

        private void pesquisarTxt_TextChanged(object sender, EventArgs e) {
            if(pesquisarTxt.Text == "") ListarClientes();
            else {
                List<ClienteEntity> clientes = new List<ClienteEntity>();
                clientes = ClienteModel.PesquisarCliente("%" + pesquisarTxt.Text + "%");

                clientesLst.DataSource = clientes;
                clientesLst.ValueMember = "id";
                clientesLst.DisplayMember = "nome";
            }
        }

        private void calcularLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CalcularIMC();
        }

        private void limparBtn_Click(object sender, EventArgs e) {
            LimparCampos();
            dataAvaliacaoDt.Value = DateTime.Now;
        }
    }
}
