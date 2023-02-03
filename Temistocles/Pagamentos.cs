using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Pagamentos : Form {
        public Pagamentos() {
            InitializeComponent();
            Listar();
        }

        private void Listar() {
            try {
                List<ClienteEntity> clientes = new List<ClienteEntity>();
                clientes = ClienteModel.ListarCliente();

                clientesCb.DataSource= clientes;
                clientesCb.ValueMember = "id";
                clientesCb.DisplayMember= "nome";

                foreach(var i in clientes) {
                    servicoTxt.Text = $"Mensalidade: {i.Servico}";
                    valorTxt.Text = i.Valor.ToString();
                }

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void incluirBtn_Click(object sender, EventArgs e) {
            try {
                string descricao = servicoTxt.Text + " - " + clientesCb.Text;
                BalancoEntity balanco = new BalancoEntity() {
                    Descricao = descricao,
                    Valor = double.Parse(valorTxt.Text),
                    Tipo = "Entrada",
                    Data = dataDt.Value
                };

                BalancoModel.InserirItem(balanco);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
