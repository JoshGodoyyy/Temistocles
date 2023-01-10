using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class EditarCliente : Form {
        private int id;
        public EditarCliente() {
            InitializeComponent();
            ListarClientes();
        }

        public void ListarClientes() {
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

        private void clientesLst_SelectedIndexChanged(object sender, EventArgs e) {
            var aux = clientesLst.SelectedValue;
            if(clientesLst.SelectedValue != aux) {
                try {
                    List<ClienteEntity> clientes = new List<ClienteEntity>();
                    clientes = ClienteModel.SelecionarCliente(int.Parse(clientesLst.SelectedValue.ToString()));

                    foreach(var cliente in clientes) {
                        id = cliente.Id;
                        nomeTxt.Text = cliente.Nome.ToString();
                        nascimentoDt.Text = cliente.Nascimento.ToString("dd/MM/yyyy");
                        if(cliente.Sexo == "Masculino") masculinoRdo.Checked = true;
                        else femininoRdo.Checked = true;
                        enderecoTxt.Text = cliente.Endereco.ToString();
                        contatoTxt.Text = cliente.Contato.ToString();
                        ativoChk.Checked = cliente.EstaAtivo;
                    }
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void salvarBtn_Click(object sender, EventArgs e) {
            try {
                ClienteEntity cliente = new ClienteEntity() {
                    Id = id,
                    Nome = nomeTxt.Text,
                    Endereco = enderecoTxt.Text,
                    Nascimento = DateTime.Parse(nascimentoDt.Text.ToString()),
                    Contato = contatoTxt.Text,
                };
                
                if(masculinoRdo.Checked) cliente.Sexo = "Masculino";
                else cliente.Sexo = "Feminino";

                if(ativoChk.Checked) cliente.EstaAtivo = true;
                else cliente.EstaAtivo = false;

                ClienteModel.EditarCliente(cliente);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListarClientes();
        }

        private void cancelarBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void contatoTxt_Leave(object sender, EventArgs e) {
            if(contatoTxt.Text.Length <= 10) contatoTxt.Mask = "(00) 0000-0000";
            else contatoTxt.Mask = "(00) 00000-0000";
        }

        private void limparLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            contatoTxt.Text = "";
            contatoTxt.Mask = "";
        }
    }
}
