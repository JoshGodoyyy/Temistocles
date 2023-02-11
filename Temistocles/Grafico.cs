using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Temistocles.Entity;
using Temistocles.Model;

namespace Temistocles {
    public partial class Grafico : Form {

        private int idPaciente;

        public Grafico(int id) {
            InitializeComponent();
            idPaciente = id;
        }

        private void GerarGrafico() {
            try {
                List<AvaliacaoEntity> avaliacoes = new List<AvaliacaoEntity>();
                avaliacoes = AvaliacaoModel.Historico(idPaciente);

                if(pesoChk.Checked) {
                    pesoChart.Series.Add("peso");
                    pesoChart.Series["peso"].LegendText = "Peso";

                    pesoChart.Series["peso"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        pesoChart.Series["peso"].Points.AddXY(i.DataAvaliacao, i.Peso);
                    }
                }

                if(toraxChk.Checked) {
                    avaliacoesChart.Series.Add("torax");
                    avaliacoesChart.Series["torax"].LegendText = "Torax";

                    avaliacoesChart.Series["torax"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["torax"].Points.AddXY(i.DataAvaliacao, i.Torax);
                    }
                }

                if(cinturaChk.Checked) {
                    avaliacoesChart.Series.Add("cintura");
                    avaliacoesChart.Series["cintura"].LegendText = "Cintura";

                    avaliacoesChart.Series["cintura"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["cintura"].Points.AddXY(i.DataAvaliacao, i.Cintura);
                    }
                }
                
                if(abdomenChk.Checked) {
                    avaliacoesChart.Series.Add("abdomen");
                    avaliacoesChart.Series["abdomen"].LegendText = "Abdomen";

                    avaliacoesChart.Series["abdomen"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["abdomen"].Points.AddXY(i.DataAvaliacao, i.Abdomen);
                    }
                }

                if(quadrilChk.Checked) {
                    avaliacoesChart.Series.Add("quadril");
                    avaliacoesChart.Series["quadril"].LegendText = "Quadril";

                    avaliacoesChart.Series["quadril"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["quadril"].Points.AddXY(i.DataAvaliacao, i.Quadril);
                    }
                }
                
                if(bracoDireitoChk.Checked) {
                    avaliacoesChart.Series.Add("bracodireito");
                    avaliacoesChart.Series["bracodireito"].LegendText = "Braço Direito";

                    avaliacoesChart.Series["bracodireito"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["bracodireito"].Points.AddXY(i.DataAvaliacao, i.BracoDireito);
                    }
                }

                if(bracoEsquerdoChk.Checked) {
                    avaliacoesChart.Series.Add("bracoesquerdo");
                    avaliacoesChart.Series["bracoesquerdo"].LegendText = "Braço Esquerdo";

                    avaliacoesChart.Series["bracoesquerdo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["bracoesquerdo"].Points.AddXY(i.DataAvaliacao, i.BracoEsquerdo);
                    }
                }

                if(antebracoDireitoChk.Checked) {
                    avaliacoesChart.Series.Add("antebracodireito");
                    avaliacoesChart.Series["antebracodireito"].LegendText = "Antebraço direito";

                    avaliacoesChart.Series["antebracodireito"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["antebracodireito"].Points.AddXY(i.DataAvaliacao, i.AntebracoDireito);
                    }
                }
                
                if(antebracoEsquerdoChk.Checked) {
                    avaliacoesChart.Series.Add("antebracoesquerdo");
                    avaliacoesChart.Series["antebracoesquerdo"].LegendText = "Antebraço esquerdo";

                    avaliacoesChart.Series["antebracoesquerdo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["antebracoesquerdo"].Points.AddXY(i.DataAvaliacao, i.AntebracoEsquerdo);
                    }
                }

                if(coxaDireitaChk.Checked) {
                    avaliacoesChart.Series.Add("coxadireita");
                    avaliacoesChart.Series["coxadireita"].LegendText = "Coxa Direita";

                    avaliacoesChart.Series["coxadireita"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["coxadireita"].Points.AddXY(i.DataAvaliacao, i.CoxaDireita);
                    }
                }
                
                if(coxaEsquerdaChk.Checked) {
                    avaliacoesChart.Series.Add("coxaesquerda");
                    avaliacoesChart.Series["coxaesquerda"].LegendText = "Coxa Esquerda";

                    avaliacoesChart.Series["coxaesquerda"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["coxaesquerda"].Points.AddXY(i.DataAvaliacao, i.CoxaEsquerda);
                    }
                }
                
                if(panturrilhaDireitaChk.Checked) {
                    avaliacoesChart.Series.Add("panturrilhadireita");
                    avaliacoesChart.Series["panturrilhadireita"].LegendText = "Panturrilha direita";

                    avaliacoesChart.Series["panturrilhadireita"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["panturrilhadireita"].Points.AddXY(i.DataAvaliacao, i.PanturrilhaDireita);
                    }
                }
                
                if(panturrilhaEsquerdaChk.Checked) {
                    avaliacoesChart.Series.Add("panturrilhaesquerda");
                    avaliacoesChart.Series["panturrilhaesquerda"].LegendText = "Panturrilha esquerda";

                    avaliacoesChart.Series["panturrilhaesquerda"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                    foreach(var i in avaliacoes) {
                        avaliacoesChart.Series["panturrilhaesquerda"].Points.AddXY(i.DataAvaliacao, i.PanturrilhaEsquerda);
                    }
                }
            
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void check(object sender, EventArgs e) {
            pesoChart.Series.Clear();
            avaliacoesChart.Series.Clear();
            GerarGrafico();
        }
    }
}
