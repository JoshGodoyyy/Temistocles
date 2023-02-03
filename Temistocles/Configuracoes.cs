using System;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Configuracoes : Form {
        public Configuracoes() {
            InitializeComponent();
        }

        private void salvarBtn_Click(object sender, EventArgs e) {
            if(repetirSenhaTxt.Text != senhaTxt.Text) {
                MessageBox.Show("Os campos de senhas devem estar iguais", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {
                LoginEntity login = new LoginEntity() {
                    Usuario = usuarioTxt.Text,
                    Senha = senhaTxt.Text,
                };
                LoginModel.AlterarDados(login);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            usuarioTxt.Clear();
            senhaTxt.Clear();
            repetirSenhaTxt.Clear();
        }

        private void mostrarSenhaChk_CheckedChanged(object sender, EventArgs e) {
            if(mostrarSenhaChk.Checked) senhaTxt.UseSystemPasswordChar = false;
            else senhaTxt.UseSystemPasswordChar = true;
        }
    }
}
