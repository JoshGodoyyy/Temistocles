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
        private int id;

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
            valorEntradas = 0;
            valorSaidas = 0;

            try {
                entradas = BalancoModel.ListarPorMes("Entrada", DataMinima(), DataMaxima());
                saidas = BalancoModel.ListarPorMes("Saída", DataMinima(), DataMaxima());
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            entradasDg.DataSource = entradas;
            entradasDg.Columns[0].Visible = false;
            entradasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            entradasDg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            entradasDg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        public void ListarTransacoes(string pesquisa){
            List<BalancoEntity> entradas = new List<BalancoEntity>();
            valorEntradas = 0;

            try {
                entradas = BalancoModel.Pesquisar(pesquisa);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            entradasDg.DataSource = entradas;
            entradasDg.Columns[0].Visible = false;
            entradasDg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            entradasDg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            entradasDg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            entradasDg.Columns[1].HeaderText = "Descrição";
            entradasDg.Columns[3].Visible = false;


            foreach(var item in entradas) {
                valorEntradas += item.Valor;
                entradasLbl.Text = "R$ " + valorEntradas.ToString();
            }

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

        private void salvarBtn_Click(object sender, EventArgs e) {
            switch(salvarBtn.Text) {
                case "Salvar":
                    if(descricaoTxt.Text == null || valorTxt.Text == null || entradaRdo.Checked == false && saidaRdo.Checked == false) {
                        MessageBox.Show("Você deve preencher todos os campos", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try {
                        BalancoEntity item = new BalancoEntity() {
                            Descricao = descricaoTxt.Text,
                            Valor = double.Parse(valorTxt.Text),
                            Data = DateTime.Parse(dataTransacaoDt.Text)
                        };
                        if(entradaRdo.Checked) item.Tipo = "Entrada";
                        else item.Tipo = "Saída";

                        BalancoModel.InserirItem(item);
                    } catch(Exception ex) {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    try {
                        BalancoEntity item = new BalancoEntity() {
                            Id = id,
                            Descricao = descricaoTxt.Text,
                            Valor = double.Parse(valorTxt.Text),
                            Data = DateTime.Parse(dataTransacaoDt.Text)
                        };
                        if(entradaRdo.Checked) item.Tipo = "Entrada";
                        else item.Tipo = "Saída";

                        BalancoModel.EditarItem(item);
                    } catch(Exception ex) {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            LimparCampos();
            ListarTransacoes();
        }

        private void LimparCampos() {
            descricaoTxt.Clear();
            valorTxt.Clear();
            dataTransacaoDt.Value = DateTime.Now;
            entradaRdo.Checked = false;
            saidaRdo.Checked = false;
            salvarBtn.Text = "Salvar";
            limparLnk.Visible = false;
        }

        private void limparLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LimparCampos();
        }

        private void entradasDg_CellClick(object sender, DataGridViewCellEventArgs e) {
            id = int.Parse(entradasDg.CurrentRow.Cells[0].Value.ToString());
            descricaoTxt.Text = entradasDg.CurrentRow.Cells[1].Value.ToString();
            valorTxt.Text = entradasDg.CurrentRow.Cells[2].Value.ToString();
            if(entradasDg.CurrentRow.Cells[3].Value.ToString() == "Entrada") entradaRdo.Checked = true;
            else saidaRdo.Checked = true;
            dataTransacaoDt.Value = DateTime.Parse(entradasDg.CurrentRow.Cells[4].Value.ToString());
            salvarBtn.Text = "Editar";
            limparLnk.Visible = true;
        }

        private void saidasDg_CellClick(object sender, DataGridViewCellEventArgs e) {
            id = int.Parse(saidasDg.CurrentRow.Cells[0].Value.ToString());
            descricaoTxt.Text = saidasDg.CurrentRow.Cells[1].Value.ToString();
            valorTxt.Text = saidasDg.CurrentRow.Cells[2].Value.ToString();
            if(saidasDg.CurrentRow.Cells[3].Value.ToString() == "Entrada") entradaRdo.Checked = true;
            else saidaRdo.Checked = true;
            dataTransacaoDt.Value = DateTime.Parse(saidasDg.CurrentRow.Cells[4].Value.ToString());
            salvarBtn.Text = "Editar";
            limparLnk.Visible = true;
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e) {
            if(buscarTxt.Text == "") {
                ListarTransacoes();
            } else {
                ListarTransacoes("%" + buscarTxt.Text + "%");
            }
        }
    }
}
