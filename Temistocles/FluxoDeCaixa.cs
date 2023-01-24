using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class FluxoDeCaixa : Form {
        public FluxoDeCaixa() {
            InitializeComponent();
            ListarTransacoes();
            mesesCb.SelectedIndex = DateTime.Now.Month - 1;
        }

        public void ListarTransacoes() {
            List<BalancoEntity> entradas = new List<BalancoEntity>();
            List<BalancoEntity> saidas = new List<BalancoEntity>();

            if(mesRdo.Checked) {
                try {
                    entradas = BalancoModel.ListarTipo("Entrada");
                    saidas = BalancoModel.ListarTipo("Saída");
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                try {
                    entradas = BalancoModel.ListarPorData("Entrada", buscarDt.Value);
                    saidas = BalancoModel.ListarPorData("Saída", buscarDt.Value);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        }

        private void CalcularResultado(double entrada, double saida) {
            double total = entrada - saida;
            totalLbl.Text = "R$ " + total.ToString();

            if(total > 0) totalLbl.ForeColor = Color.Green;
            else if(total < 0) totalLbl.ForeColor = Color.Red;
            else totalLbl.ForeColor = Color.Black;
        }

        private void Radios(object sender, EventArgs e) {
            ListarTransacoes();
            if (mesRdo.Checked) {
                mesesCb.Visible = true;
                buscarDt.Visible = false;
            } else {
                mesesCb.Visible = false;
                buscarDt.Visible = true;
            }
        }

        private void buscarDt_ValueChanged(object sender, EventArgs e) {
            ListarTransacoes();
        }

        private void mesesCb_TextChanged(object sender, EventArgs e) {
            ListarTransacoes();
        }
    }
}
