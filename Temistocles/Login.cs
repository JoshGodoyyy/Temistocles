using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Login : Form {
        readonly Main main;
        public Login(Main main) {
            InitializeComponent();
            this.main = main;
        }

        private void entrarBtn_Click(object sender, EventArgs e) {
            LoginEntity login = new LoginEntity() {
                Usuario = usuarioTxt.Text,
                Senha = senhaTxt.Text
            };

            List<LoginEntity> usuario = new List<LoginEntity>();
            usuario = LoginModel.Login(login);

            if(usuario.Count > 0) {
                Global.estaLogado = true;
                Global.Usuario = usuarioTxt.Text;
                main.usuarioLbl.Text = Global.Usuario;
                main.cadastrosTab.Enabled = true;
                main.financeiroTab.Enabled = true;
                main.logoutBtn.Enabled = true;
                main.configuracoesBtn.Visible = true;
                Close();
            } else {
                MessageBox.Show("Usuário e/ou senha inválido(s).", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
