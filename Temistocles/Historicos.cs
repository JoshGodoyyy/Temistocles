using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Historicos : Form {
        private readonly int id;
        private int idAvaliacao;
        public Historicos(int id) {
            InitializeComponent();
            this.id = id;
            Atualizar();
        }

        private void Atualizar() {
            try {
                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();
                avaliacoes = AvaliacaoModel.Historico(id);

                foreach(var i in avaliacoes) {
                    dataAvaliacaoCb.Items.Add(i.DataAvaliacao);
                }

                dataAvaliacaoCb.SelectedItem = dataAvaliacaoCb.Items[0];

                List<ClienteEntity> cliente = new List<ClienteEntity>();
                cliente = ClienteModel.SelecionarCliente(id);

                foreach(var i in cliente) {
                    nomeTxt.Text = i.Nome;
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graficoBtn_Click(object sender, EventArgs e) {
            Grafico grafico = new Grafico(id);
            grafico.ShowDialog();
        }

        private void dataAvaliacaoCb_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                List<AvaliacaoEntity> avaliacao = new List<AvaliacaoEntity>();
                avaliacao = AvaliacaoModel.ListarAvaliacao(DateTime.Parse(dataAvaliacaoCb.SelectedItem.ToString()));

                foreach(var i in avaliacao) {
                    idAvaliacao = i.Id;
                    toraxTxt.Text = i.Torax.ToString();
                    cinturaTxt.Text = i.Cintura.ToString();
                    abdomenTxt.Text = i.Abdomen.ToString();
                    quadrilTxt.Text = i.Quadril.ToString();
                    bracoDireitoTxt.Text = i.BracoDireito.ToString();
                    bracoEsquerdoTxt.Text = i.BracoEsquerdo.ToString();
                    antebracoDireitoTxt.Text = i.AntebracoDireito.ToString();
                    antebracoEsquerdoTxt.Text = i.AntebracoEsquerdo.ToString();
                    coxaDireitaTxt.Text = i.CoxaDireita.ToString();
                    coxaEsquerdaTxt.Text = i.CoxaEsquerda.ToString();
                    panturrilhaDireitaTxt.Text = i.PanturrilhaDireita.ToString();
                    panturrilhaEsquerdaTxt.Text = i.PanturrilhaEsquerda.ToString();
                    alturaTxt.Text = i.Estatura.ToString();
                    pesoTxt.Text = i.Peso.ToString();
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvarBtn_Click(object sender, EventArgs e) {
            if(salvarBtn.Text == "Editar") {
                AtivarCampos();
            } else {
                try {
                    AvaliacaoEntity avaliacao = new AvaliacaoEntity() {
                        Id = idAvaliacao,
                        Torax = double.Parse(toraxTxt.Text),
                        Cintura = double.Parse(cinturaTxt.Text),
                        Abdomen = double.Parse(abdomenTxt.Text),
                        Quadril = double.Parse(quadrilTxt.Text),
                        BracoDireito = double.Parse(bracoDireitoTxt.Text),
                        BracoEsquerdo = double.Parse(bracoEsquerdoTxt.Text),
                        AntebracoDireito = double.Parse(antebracoDireitoTxt.Text),
                        AntebracoEsquerdo = double.Parse(antebracoEsquerdoTxt.Text),
                        CoxaDireita = double.Parse(coxaDireitaTxt.Text),
                        CoxaEsquerda = double.Parse(coxaEsquerdaTxt.Text),
                        PanturrilhaDireita = double.Parse(panturrilhaDireitaTxt.Text),
                        PanturrilhaEsquerda = double.Parse(panturrilhaEsquerdaTxt.Text),
                        Estatura = double.Parse(alturaTxt.Text),
                        Peso = double.Parse(pesoTxt.Text),
                        DataAvaliacao = dataDt.Value,
                    };

                    AvaliacaoModel.EditarAvaliacao(avaliacao);
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DesativarCampos();
            }
        }

        private void AtivarCampos() {
            toraxTxt.Enabled = true;
            cinturaTxt.Enabled = true;
            abdomenTxt.Enabled = true;
            quadrilTxt.Enabled = true;
            bracoDireitoTxt.Enabled = true;
            bracoEsquerdoTxt.Enabled = true;
            antebracoDireitoTxt.Enabled = true;
            antebracoEsquerdoTxt.Enabled = true;
            coxaDireitaTxt.Enabled = true;
            coxaEsquerdaTxt.Enabled = true;
            panturrilhaDireitaTxt.Enabled = true;
            panturrilhaEsquerdaTxt.Enabled = true;
            alturaTxt.Enabled = true;
            pesoTxt.Enabled = true;
            dataAvaliacaoCb.Visible = false;
            dataDt.Visible = true;
            dataDt.Value = DateTime.Now;
            salvarBtn.Text = "Salvar";
            removerBtn.Text = "Cancelar";
        }

        private void DesativarCampos() {
            toraxTxt.Enabled = false;
            cinturaTxt.Enabled = false;
            abdomenTxt.Enabled = false;
            quadrilTxt.Enabled = false;
            bracoDireitoTxt.Enabled = false;
            bracoEsquerdoTxt.Enabled = false;
            antebracoDireitoTxt.Enabled = false;
            antebracoEsquerdoTxt.Enabled = false;
            coxaDireitaTxt.Enabled = false;
            coxaEsquerdaTxt.Enabled = false;
            panturrilhaDireitaTxt.Enabled = false;
            panturrilhaEsquerdaTxt.Enabled = false;
            alturaTxt.Enabled = false;
            pesoTxt.Enabled = false;
            dataAvaliacaoCb.Visible = true;
            dataDt.Visible = false;
            salvarBtn.Text = "Editar";
            removerBtn.Text = "Remover";
        }

        private void removerBtn_Click(object sender, EventArgs e) {
            if(removerBtn.Text == "Remover") {
                DialogResult dialogResult = MessageBox.Show("Deseja mesmo realizar essa operação?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(dialogResult == DialogResult.Yes) {
                    try {
                        AvaliacaoModel.RemoverAvaliacao(idAvaliacao);
                    } catch(Exception ex) {
                        MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Atualizar();
            } else {
                DesativarCampos();
            }
        }
    }
}
