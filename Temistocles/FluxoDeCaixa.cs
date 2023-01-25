using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class FluxoDeCaixa : Form {
        double valorEntradas = 0;
        double valorSaidas = 0;

        public FluxoDeCaixa() {
            InitializeComponent();
            mesesCb.SelectedIndex = DateTime.Now.Month - 1;
            ListarTransacoes();
        }

        private DateTime DataMinima() {
            int ano = DateTime.Now.Year;
            return DateTime.Parse($"01/{mesesCb.SelectedIndex + 1}/{ano}");
        }

        private DateTime DataMaxima() {
            int ano = DateTime.Now.Year;
            int dia = DateTime.DaysInMonth(ano, mesesCb.SelectedIndex + 1);
            return DateTime.Parse($"{dia}/{mesesCb.SelectedIndex + 1}/{ano}");
        }

        public void ListarTransacoes() {
            List<BalancoEntity> entradas = new List<BalancoEntity>();
            List<BalancoEntity> saidas = new List<BalancoEntity>();

            try {
                entradas = BalancoModel.ListarPorMes("Entrada", DataMinima(), DataMaxima());
                saidas = BalancoModel.ListarPorMes("Saída", DataMinima(), DataMaxima());
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            entradasDg.DataSource = entradas;
            entradasDg.Columns[0].Visible = false;
            entradasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            entradasDg.Columns[1].HeaderText = "Descrição";
            entradasDg.Columns[3].Visible = false;

            foreach(var item in entradas) {
                valorEntradas += item.Valor;
                entradasLbl.Text = "R$ " + valorEntradas.ToString();
            }

            saidasDg.DataSource = saidas;
            saidasDg.Columns[0].Visible = false;
            saidasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            saidasDg.Columns[1].HeaderText = "Descrição";
            saidasDg.Columns[3].Visible = false;

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

        private void mesesCb_SelectedIndexChanged(object sender, EventArgs e) {
            valorEntradas = 0;
            valorSaidas = 0;
            entradasLbl.Text = "R$ " + valorEntradas.ToString();
            saidasLbl.Text = "R$ " + valorSaidas.ToString();
            ListarTransacoes();
        }
    }
}
