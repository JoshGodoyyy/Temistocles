namespace Temistocles {
    partial class Grafico {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafico));
            this.panturrilhaEsquerdaChk = new System.Windows.Forms.CheckBox();
            this.panturrilhaDireitaChk = new System.Windows.Forms.CheckBox();
            this.coxaEsquerdaChk = new System.Windows.Forms.CheckBox();
            this.coxaDireitaChk = new System.Windows.Forms.CheckBox();
            this.antebracoEsquerdoChk = new System.Windows.Forms.CheckBox();
            this.antebracoDireitoChk = new System.Windows.Forms.CheckBox();
            this.bracoEsquerdoChk = new System.Windows.Forms.CheckBox();
            this.bracoDireitoChk = new System.Windows.Forms.CheckBox();
            this.quadrilChk = new System.Windows.Forms.CheckBox();
            this.abdomenChk = new System.Windows.Forms.CheckBox();
            this.cinturaChk = new System.Windows.Forms.CheckBox();
            this.toraxChk = new System.Windows.Forms.CheckBox();
            this.pesoChk = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pesoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.avaliacoesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panturrilhaEsquerdaChk
            // 
            this.panturrilhaEsquerdaChk.AutoSize = true;
            this.panturrilhaEsquerdaChk.Location = new System.Drawing.Point(12, 288);
            this.panturrilhaEsquerdaChk.Name = "panturrilhaEsquerdaChk";
            this.panturrilhaEsquerdaChk.Size = new System.Drawing.Size(124, 17);
            this.panturrilhaEsquerdaChk.TabIndex = 12;
            this.panturrilhaEsquerdaChk.Text = "Panturrilha Esquerda";
            this.panturrilhaEsquerdaChk.UseVisualStyleBackColor = true;
            this.panturrilhaEsquerdaChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // panturrilhaDireitaChk
            // 
            this.panturrilhaDireitaChk.AutoSize = true;
            this.panturrilhaDireitaChk.Location = new System.Drawing.Point(12, 265);
            this.panturrilhaDireitaChk.Name = "panturrilhaDireitaChk";
            this.panturrilhaDireitaChk.Size = new System.Drawing.Size(109, 17);
            this.panturrilhaDireitaChk.TabIndex = 11;
            this.panturrilhaDireitaChk.Text = "Panturrilha Direita";
            this.panturrilhaDireitaChk.UseVisualStyleBackColor = true;
            this.panturrilhaDireitaChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // coxaEsquerdaChk
            // 
            this.coxaEsquerdaChk.AutoSize = true;
            this.coxaEsquerdaChk.Location = new System.Drawing.Point(12, 242);
            this.coxaEsquerdaChk.Name = "coxaEsquerdaChk";
            this.coxaEsquerdaChk.Size = new System.Drawing.Size(98, 17);
            this.coxaEsquerdaChk.TabIndex = 10;
            this.coxaEsquerdaChk.Text = "Coxa Esquerda";
            this.coxaEsquerdaChk.UseVisualStyleBackColor = true;
            this.coxaEsquerdaChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // coxaDireitaChk
            // 
            this.coxaDireitaChk.AutoSize = true;
            this.coxaDireitaChk.Location = new System.Drawing.Point(12, 219);
            this.coxaDireitaChk.Name = "coxaDireitaChk";
            this.coxaDireitaChk.Size = new System.Drawing.Size(83, 17);
            this.coxaDireitaChk.TabIndex = 9;
            this.coxaDireitaChk.Text = "Coxa Direita";
            this.coxaDireitaChk.UseVisualStyleBackColor = true;
            this.coxaDireitaChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // antebracoEsquerdoChk
            // 
            this.antebracoEsquerdoChk.AutoSize = true;
            this.antebracoEsquerdoChk.Location = new System.Drawing.Point(12, 196);
            this.antebracoEsquerdoChk.Name = "antebracoEsquerdoChk";
            this.antebracoEsquerdoChk.Size = new System.Drawing.Size(123, 17);
            this.antebracoEsquerdoChk.TabIndex = 8;
            this.antebracoEsquerdoChk.Text = "Antebraço Esquerdo";
            this.antebracoEsquerdoChk.UseVisualStyleBackColor = true;
            this.antebracoEsquerdoChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // antebracoDireitoChk
            // 
            this.antebracoDireitoChk.AutoSize = true;
            this.antebracoDireitoChk.Location = new System.Drawing.Point(12, 173);
            this.antebracoDireitoChk.Name = "antebracoDireitoChk";
            this.antebracoDireitoChk.Size = new System.Drawing.Size(108, 17);
            this.antebracoDireitoChk.TabIndex = 7;
            this.antebracoDireitoChk.Text = "Antebraço Direito";
            this.antebracoDireitoChk.UseVisualStyleBackColor = true;
            this.antebracoDireitoChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // bracoEsquerdoChk
            // 
            this.bracoEsquerdoChk.AutoSize = true;
            this.bracoEsquerdoChk.Location = new System.Drawing.Point(12, 150);
            this.bracoEsquerdoChk.Name = "bracoEsquerdoChk";
            this.bracoEsquerdoChk.Size = new System.Drawing.Size(102, 17);
            this.bracoEsquerdoChk.TabIndex = 6;
            this.bracoEsquerdoChk.Text = "Braço Esquerdo";
            this.bracoEsquerdoChk.UseVisualStyleBackColor = true;
            this.bracoEsquerdoChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // bracoDireitoChk
            // 
            this.bracoDireitoChk.AutoSize = true;
            this.bracoDireitoChk.Location = new System.Drawing.Point(12, 127);
            this.bracoDireitoChk.Name = "bracoDireitoChk";
            this.bracoDireitoChk.Size = new System.Drawing.Size(87, 17);
            this.bracoDireitoChk.TabIndex = 5;
            this.bracoDireitoChk.Text = "Braço Direito";
            this.bracoDireitoChk.UseVisualStyleBackColor = true;
            this.bracoDireitoChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // quadrilChk
            // 
            this.quadrilChk.AutoSize = true;
            this.quadrilChk.Location = new System.Drawing.Point(12, 104);
            this.quadrilChk.Name = "quadrilChk";
            this.quadrilChk.Size = new System.Drawing.Size(59, 17);
            this.quadrilChk.TabIndex = 4;
            this.quadrilChk.Text = "Quadril";
            this.quadrilChk.UseVisualStyleBackColor = true;
            this.quadrilChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // abdomenChk
            // 
            this.abdomenChk.AutoSize = true;
            this.abdomenChk.Location = new System.Drawing.Point(12, 81);
            this.abdomenChk.Name = "abdomenChk";
            this.abdomenChk.Size = new System.Drawing.Size(71, 17);
            this.abdomenChk.TabIndex = 3;
            this.abdomenChk.Text = "Abdomen";
            this.abdomenChk.UseVisualStyleBackColor = true;
            this.abdomenChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // cinturaChk
            // 
            this.cinturaChk.AutoSize = true;
            this.cinturaChk.Location = new System.Drawing.Point(12, 58);
            this.cinturaChk.Name = "cinturaChk";
            this.cinturaChk.Size = new System.Drawing.Size(59, 17);
            this.cinturaChk.TabIndex = 2;
            this.cinturaChk.Text = "Cintura";
            this.cinturaChk.UseVisualStyleBackColor = true;
            this.cinturaChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // toraxChk
            // 
            this.toraxChk.AutoSize = true;
            this.toraxChk.Location = new System.Drawing.Point(12, 35);
            this.toraxChk.Name = "toraxChk";
            this.toraxChk.Size = new System.Drawing.Size(53, 17);
            this.toraxChk.TabIndex = 1;
            this.toraxChk.Text = "Tórax";
            this.toraxChk.UseVisualStyleBackColor = true;
            this.toraxChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // pesoChk
            // 
            this.pesoChk.AutoSize = true;
            this.pesoChk.Location = new System.Drawing.Point(12, 12);
            this.pesoChk.Name = "pesoChk";
            this.pesoChk.Size = new System.Drawing.Size(50, 17);
            this.pesoChk.TabIndex = 0;
            this.pesoChk.Text = "Peso";
            this.pesoChk.UseVisualStyleBackColor = true;
            this.pesoChk.CheckedChanged += new System.EventHandler(this.check);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pesoChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.avaliacoesChart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(247, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 687);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pesoChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pesoChart.ChartAreas.Add(chartArea1);
            this.pesoChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.pesoChart.Legends.Add(legend1);
            this.pesoChart.Location = new System.Drawing.Point(3, 3);
            this.pesoChart.Name = "pesoChart";
            this.pesoChart.Size = new System.Drawing.Size(751, 337);
            this.pesoChart.TabIndex = 0;
            this.pesoChart.Text = "chart1";
            // 
            // avaliacoesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.avaliacoesChart.ChartAreas.Add(chartArea2);
            this.avaliacoesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.avaliacoesChart.Legends.Add(legend2);
            this.avaliacoesChart.Location = new System.Drawing.Point(3, 346);
            this.avaliacoesChart.Name = "avaliacoesChart";
            this.avaliacoesChart.Size = new System.Drawing.Size(751, 338);
            this.avaliacoesChart.TabIndex = 1;
            this.avaliacoesChart.Text = "chart2";
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 687);
            this.Controls.Add(this.panturrilhaEsquerdaChk);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panturrilhaDireitaChk);
            this.Controls.Add(this.coxaEsquerdaChk);
            this.Controls.Add(this.pesoChk);
            this.Controls.Add(this.coxaDireitaChk);
            this.Controls.Add(this.toraxChk);
            this.Controls.Add(this.antebracoEsquerdoChk);
            this.Controls.Add(this.cinturaChk);
            this.Controls.Add(this.antebracoDireitoChk);
            this.Controls.Add(this.abdomenChk);
            this.Controls.Add(this.bracoEsquerdoChk);
            this.Controls.Add(this.quadrilChk);
            this.Controls.Add(this.bracoDireitoChk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafico";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pesoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avaliacoesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox panturrilhaEsquerdaChk;
        private System.Windows.Forms.CheckBox panturrilhaDireitaChk;
        private System.Windows.Forms.CheckBox coxaEsquerdaChk;
        private System.Windows.Forms.CheckBox coxaDireitaChk;
        private System.Windows.Forms.CheckBox antebracoEsquerdoChk;
        private System.Windows.Forms.CheckBox antebracoDireitoChk;
        private System.Windows.Forms.CheckBox bracoEsquerdoChk;
        private System.Windows.Forms.CheckBox bracoDireitoChk;
        private System.Windows.Forms.CheckBox quadrilChk;
        private System.Windows.Forms.CheckBox abdomenChk;
        private System.Windows.Forms.CheckBox cinturaChk;
        private System.Windows.Forms.CheckBox toraxChk;
        private System.Windows.Forms.CheckBox pesoChk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pesoChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart avaliacoesChart;
    }
}