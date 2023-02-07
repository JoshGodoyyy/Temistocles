using System;
using System.IO;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;
using Temistocles.Properties;

namespace Temistocles {
    public partial class Configuracoes : Form {
        public Configuracoes() {
            InitializeComponent();
            VerificarCaminho();
        }

        private void VerificarCaminho() {
            caminhoTxt.Text = Properties.Settings.Default.PathDatabase;
            dataLbl.Text = Settings.Default.DataBackup;
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

        private void backupBtn_Click(object sender, EventArgs e) {
            if(selecionarPastaDialog.ShowDialog() == DialogResult.OK) {

                string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
                string sourcePath = path + @"\db\";
                string fileName = "temistocles.db";
                string targetPath = caminhoTxt.Text.ToString();

                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, fileName);

                Directory.CreateDirectory(targetPath);

                File.Copy(sourceFile, destFile, true);
                dataLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
                Settings.Default.DataBackup = dataLbl.Text;
                Settings.Default.Save();
            }
        }

        private void importarBtn_Click(object sender, EventArgs e) {
            string sourcePath = caminhoTxt.Text;
            string targetPath = AppDomain.CurrentDomain.BaseDirectory + @"\db\";
            string fileName = "Temistocles.db";

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            try {
                Directory.CreateDirectory(targetPath);
                File.Copy(sourceFile, destFile, true);
            } catch(FileNotFoundException) {
                MessageBox.Show("Arquivo de banco de dados não encontrado, por favor, selecione o arquivo", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Database files (*.db) | *.db";
                if(openFile.ShowDialog() == DialogResult.OK) { }
            }
            dataLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Settings.Default.DataBackup = dataLbl.Text;
            Settings.Default.Save();

        }

        private void alterarLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(selecionarPastaDialog.ShowDialog() == DialogResult.OK) {
                caminhoTxt.Text = selecionarPastaDialog.SelectedPath;
                Settings.Default.PathDatabase = caminhoTxt.Text;
                Settings.Default.Save();
            }
        }
    }
}
