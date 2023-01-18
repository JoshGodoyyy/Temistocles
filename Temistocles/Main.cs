﻿using System;
using System.Windows.Forms;

namespace Temistocles {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
            versaoTxt.Text = Global.Versao;
            Conexao();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Conexao() {
            if(!Global.estaLogado) {
                Login login = new Login(this);
                login.MdiParent = this;
                login.Show();
                cadastrosTab.Enabled = false;
                financeiroTab.Enabled = false;
                logoutBtn.Enabled = false;
                Global.Usuario = "Desconectado";
                usuarioTxt.Text = Global.Usuario;
            }
        }

        private void novoClienteBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["CadastroCliente"];
            if(formOpenned == null) {
                formOpenned = new CadastroCliente(this);
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void editarClienteBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["EditarCliente"];
            if(formOpenned == null) {
                formOpenned = new EditarCliente();
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void avaliacoesBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Avaliacoes"];
            if(formOpenned == null) {
                formOpenned = new Avaliacoes(this);
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void pagamentosBtn_Click(object sender, EventArgs e) {

        }

        private void fluxoDeCaixaBtn_Click(object sender, EventArgs e) {

        }

        private void logoutBtn_Click(object sender, EventArgs e) {
            Global.estaLogado = false;
            Conexao();
        }

        private void encerrarBtn_Click(object sender, EventArgs e) {
            DialogResult dialog = MessageBox.Show("Deseja mesmo encerrar a aplicação?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
