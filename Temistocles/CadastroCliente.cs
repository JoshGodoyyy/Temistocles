using System;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class CadastroCliente : Form {

        readonly Main main;
        public CadastroCliente(Main main) {
            InitializeComponent();
            this.main = main;
        }

        private void cancelarBtn_Click(object sender, System.EventArgs e) {
            DialogResult dialog = MessageBox.Show("Deseja mesmo fechar esta janela?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes) {
                Close();
            }
        }

        private void salvarBtn_Click(object sender, System.EventArgs e) {
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
                    EstaAtivo = true,
                };
                if(masculinoRdo.Checked) {
                    cliente.Sexo = "Masculino";
                } else {
                    cliente.Sexo = "Feminino";
                }

                ClienteModel.CadastrarCliente(cliente);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();

            WindowState = FormWindowState.Minimized;

            string sexo;
            if(masculinoRdo.Checked) sexo = "Masculino";
            else sexo = "Feminino";

            CadastrarAvaliacao avaliacao = new CadastrarAvaliacao(sexo);
            avaliacao.MdiParent = main;
            avaliacao.Show();

        }

        private void LimparCampos() {
            nomeTxt.Clear();
            masculinoRdo.Checked = true;
            enderecoTxt.Clear();
            contatoTxt.Clear();
        }

        private void contatoTxt_Leave(object sender, EventArgs e) {
            if(contatoTxt.Text.Length <= 10) contatoTxt.Mask = "(00) 0000-0000";
            else contatoTxt.Mask = "(00) 00000-0000";
        }

        private void limparLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            contatoTxt.Text = "";
            contatoTxt.Mask = "";
        }
    }
}
