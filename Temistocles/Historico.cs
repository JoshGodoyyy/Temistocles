using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Historico : Form {
        private readonly int id;

        public Historico(int id) {
            InitializeComponent();
            this.id = id;
            Atualizar();
        }

        private void Atualizar() {
            try {
                List<ClienteEntity> cliente = new List<ClienteEntity>();
                cliente = ClienteModel.SelecionarCliente(id);

                foreach(var i in cliente) {
                    nomeTxt.Text = i.Nome.ToString();
                    contatoTxt.Text = i.Contato.ToString();
                    nascimentoTxt.Text = i.Nascimento.ToString().Remove(10);
                    enderecoTxt.Text = i.Endereco.ToString();
                }

                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();
                avaliacoes = ClienteModel.Historico(id);

                historicoDG.DataSource = avaliacoes;
                historicoDG.Columns[0].Visible = false;
                historicoDG.Columns[1].Visible = false;
                for(int i = 2; i < historicoDG.Columns.Count; i++) {
                    historicoDG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }

                historicoDG.Columns[2].HeaderText = "Data de Avaliação";
                historicoDG.Columns[9].HeaderText = "Braço direito";
                historicoDG.Columns[10].HeaderText = "Braço esquerdo";
                historicoDG.Columns[11].HeaderText = "Antebraço direito";
                historicoDG.Columns[12].HeaderText = "Antebraço esquerdo";
                historicoDG.Columns[13].HeaderText = "Coxa direita";
                historicoDG.Columns[14].HeaderText = "Coxa esquerda";
                historicoDG.Columns[15].HeaderText = "Panturrilha direita";
                historicoDG.Columns[16].HeaderText = "Panturrilha esquerda";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graficoBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["Grafico"];
            if(formOpenned == null) {
                formOpenned = new Grafico(id);
                formOpenned.ShowDialog();
            }
        }

        private void sairBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
