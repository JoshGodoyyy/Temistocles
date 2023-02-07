using System;
using System.IO;
using System.Windows.Forms;
using Temistocles.Properties;

namespace Temistocles {
    public partial class Main : Form {

        public Main() {
            InitializeComponent();
            versaoLbl.Text = Global.Versao;
            empresaLbl.Text = Global.CompanyName;
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
                usuarioLbl.Text = Global.Usuario;
                configuracoesBtn.Visible = false;
            }
        }

        private void novoClienteBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["CadastroCliente"];
            if(formOpenned == null) {
                formOpenned = new CadastroCliente();
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
            Form formOpenned = Application.OpenForms["Pagamentos"];
            if(formOpenned == null) {
                formOpenned = new Pagamentos();
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void fluxoDeCaixaBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["FluxoDeCaixa"];
            if(formOpenned == null) {
                formOpenned = new FluxoDeCaixa();
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e) {
            Global.estaLogado = false;
            Conexao();
        }

        private void encerrarBtn_Click(object sender, EventArgs e) {
            DialogResult dialog = MessageBox.Show("Deseja mesmo encerrar a aplicação?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) {
                timer1.Start();
                logLbl.Visible = true;
            }
        }

        private void configuracoesBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Configuracoes"];
            if(formOpenned == null) {
                formOpenned = new Configuracoes();
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            progressSave.Value++;
            if(progressSave.Value == progressSave.Maximum) {
                timer1.Stop();
                logLbl.Visible = false;
                string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
                string sourcePath = path + @"\db\";
                string fileName = "temistocles.db";
                string targetPath = Settings.Default.PathDatabase;

                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, fileName);

                Directory.CreateDirectory(targetPath);

                File.Copy(sourceFile, destFile, true);
                Settings.Default.DataBackup = DateTime.Now.ToString("dd/MM/yyyy");
                Settings.Default.Save();
                Close();
            }
        }
    }
}
