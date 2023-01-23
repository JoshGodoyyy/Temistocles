using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class FluxoDeCaixa : Form {

        Main main;

        public FluxoDeCaixa(Main main) {
            InitializeComponent();
            this.main = main;
            ListarTransacoes();
        }

        private void ListarTransacoes() {
            try {
                List<BalancoEntity> entradas = new List<BalancoEntity>();
                entradas = BalancoModel.ListarTipo("Entrada");

                entradasDg.DataSource = entradas;
                entradasDg.Columns[0].Visible = false;
                entradasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                entradasDg.Columns[1].HeaderText = "Descrição";
                entradasDg.Columns[3].Visible = false;

                double valorEntradas = 0;
                foreach(var item in entradas) {
                    valorEntradas += item.Valor;
                    entradasLbl.Text = "R$ " + valorEntradas.ToString();
                }

                List<BalancoEntity> saidas = new List<BalancoEntity>();
                saidas = BalancoModel.ListarTipo("Saída");

                saidasDg.DataSource = saidas;
                saidasDg.Columns[0].Visible = false;
                saidasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                saidasDg.Columns[1].HeaderText = "Descrição";
                saidasDg.Columns[3].Visible = false;

                double valorSaidas = 0;
                foreach(var item in saidas) {
                    valorSaidas += item.Valor;
                    saidasLbl.Text = "R$ " + valorSaidas.ToString();
                }

                CalcularResultado(valorEntradas, valorSaidas);

            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularResultado(double entrada, double saida) {
            double total = entrada - saida;
            totalLbl.Text = "R$ " + total.ToString();

            if(total > 0) totalLbl.ForeColor = Color.Green;
            else if(total < 0) totalLbl.ForeColor = Color.Red;
            else totalLbl.ForeColor = Color.Black;
        }

        private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e) {
            Lancamentos lancamentos = new Lancamentos();
            lancamentos.MdiParent = main;
            lancamentos.Show();
        }
    }
}
