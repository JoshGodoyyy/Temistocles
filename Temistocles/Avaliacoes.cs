using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Avaliacoes : Form {
        public Avaliacoes() {
            InitializeComponent();
            ListarClientes();
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

        private void clientesLst_SelectedIndexChanged(object sender, EventArgs e) {
            var aux = clientesLst.SelectedValue;
            if(clientesLst.SelectedValue != aux) {

            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void novaBtn_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void historicoBtn_Click(object sender, EventArgs e) {

        }

        private void pesquisarTxt_TextChanged(object sender, EventArgs e) {

        }
    }
}
