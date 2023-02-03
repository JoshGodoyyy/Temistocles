using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class CadastroCliente : Form {

        private bool salvo = false;
        public CadastroCliente() {
            InitializeComponent();
            dataAvaliacaoDt.Value = DateTime.Now;
            dataMatricula.Value = DateTime.Now;
        }

        private void cancelarBtn_Click(object sender, System.EventArgs e) {
            DialogResult dialog = MessageBox.Show("Deseja mesmo fechar esta janela?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes) {
                Close();
            }
        }

        private void LimparCampos() {
            nomeTxt.Clear();
            masculinoRdo.Checked = true;
            enderecoTxt.Clear();
            contatoTxt.Clear();
            servicoTxt.Clear();
            valorTxt.Clear();
            salvo = false;
        }

        private void contatoTxt_Leave(object sender, EventArgs e) {
            if(contatoTxt.Text.Length <= 10) contatoTxt.Mask = "(00) 0000-0000";
            else contatoTxt.Mask = "(00) 00000-0000";
        }

        private void limparLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            contatoTxt.Text = "";
            contatoTxt.Mask = "";
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
            if(masculinoRdo.Checked) {
                if(valor < 20) {
                    classificacaoLbl.Text = "Abaixo do peso";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 20 && valor <= 24.9) {
                    classificacaoLbl.Text = "Normal";
                    classificacaoLbl.ForeColor = Color.Green;
                } else if(valor >= 25 && valor < 30) {
                    classificacaoLbl.Text = "Obesidade leve";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 30 && valor <= 39.9) {
                    classificacaoLbl.Text = "Obesidade grau II";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else {
                    classificacaoLbl.Text = "Obesidade mórbida";
                    classificacaoLbl.ForeColor = Color.Red;
                }
            } else {
                if(valor < 19) {
                    classificacaoLbl.Text = "Abaixo do peso";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 19 && valor <= 23.9) {
                    classificacaoLbl.Text = "Normal";
                    classificacaoLbl.ForeColor = Color.Green;
                } else if(valor >= 24 && valor < 28.9) {
                    classificacaoLbl.Text = "Obesidade leve";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else if(valor >= 29 && valor <= 38.9) {
                    classificacaoLbl.Text = "Obesidade grau II";
                    classificacaoLbl.ForeColor = Color.OrangeRed;
                } else {
                    classificacaoLbl.Text = "Obesidade mórbida";
                    classificacaoLbl.ForeColor = Color.Red;
                }
            }
        }

        public void LimparCamposAvaliacao() {
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

        private void salvarLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(nomeTxt.Text == "" || enderecoTxt.Text == "" || contatoTxt.Text == "") {
                MessageBox.Show("Todos os campos devem estar preenchidos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                ClienteEntity cliente = new ClienteEntity() {
                    Nome = nomeTxt.Text,
                    Nascimento = DateTime.Parse(nascimentoDt.Value.ToString()),
                    Endereco = enderecoTxt.Text,
                    Contato = contatoTxt.Text,
                    DataMatricula = dataMatricula.Value,
                    Servico = servicoTxt.Text,
                    Valor = double.Parse(valorTxt.Text),
                    EstaAtivo = true,
                };
                if(masculinoRdo.Checked) {
                    cliente.Sexo = "Masculino";
                } else {
                    cliente.Sexo = "Feminino";
                }

                ClienteModel.CadastrarCliente(cliente);

                salvoLbl.Visible = true;


                ListarClientes();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void concluirBtn_Click(object sender, EventArgs e) {
            if(salvo) {
                MessageBox.Show("Você precisa salvar o cliente primeiro", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                    IdCliente = int.Parse(clientesCb.SelectedValue.ToString()),
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
            LimparCamposAvaliacao();
        }

        private void ListarClientes() {
            try {
                List<ClienteEntity> clientes = new List<ClienteEntity>();
                clientes = ClienteModel.ListarCliente();

                clientesCb.DataSource = clientes;
                clientesCb.ValueMember = "id";
                clientesCb.DisplayMember = "nome";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
