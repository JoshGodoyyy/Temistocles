namespace Temistocles {
    partial class FluxoDeCaixa {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FluxoDeCaixa));
            this.entradasDg = new System.Windows.Forms.DataGridView();
            this.saidasDg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.entradasLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.saidasLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buscarDt = new System.Windows.Forms.DateTimePicker();
            this.mesesCb = new System.Windows.Forms.ComboBox();
            this.mesRdo = new System.Windows.Forms.RadioButton();
            this.dataRdo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.entradasDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasDg)).BeginInit();
            this.SuspendLayout();
            // 
            // entradasDg
            // 
            this.entradasDg.AllowUserToAddRows = false;
            this.entradasDg.AllowUserToDeleteRows = false;
            this.entradasDg.AllowUserToResizeRows = false;
            this.entradasDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entradasDg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.entradasDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradasDg.Location = new System.Drawing.Point(12, 52);
            this.entradasDg.Name = "entradasDg";
            this.entradasDg.ReadOnly = true;
            this.entradasDg.RowHeadersVisible = false;
            this.entradasDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entradasDg.Size = new System.Drawing.Size(350, 315);
            this.entradasDg.TabIndex = 0;
            // 
            // saidasDg
            // 
            this.saidasDg.AllowUserToAddRows = false;
            this.saidasDg.AllowUserToDeleteRows = false;
            this.saidasDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saidasDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saidasDg.Location = new System.Drawing.Point(368, 52);
            this.saidasDg.Name = "saidasDg";
            this.saidasDg.ReadOnly = true;
            this.saidasDg.RowHeadersVisible = false;
            this.saidasDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saidasDg.Size = new System.Drawing.Size(350, 315);
            this.saidasDg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saídas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(724, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 315);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total de Entradas:";
            // 
            // entradasLbl
            // 
            this.entradasLbl.AutoSize = true;
            this.entradasLbl.ForeColor = System.Drawing.Color.Green;
            this.entradasLbl.Location = new System.Drawing.Point(731, 65);
            this.entradasLbl.Name = "entradasLbl";
            this.entradasLbl.Size = new System.Drawing.Size(21, 13);
            this.entradasLbl.TabIndex = 7;
            this.entradasLbl.Text = "R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(731, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 1);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total de Saídas:";
            // 
            // saidasLbl
            // 
            this.saidasLbl.AutoSize = true;
            this.saidasLbl.ForeColor = System.Drawing.Color.Red;
            this.saidasLbl.Location = new System.Drawing.Point(731, 98);
            this.saidasLbl.Name = "saidasLbl";
            this.saidasLbl.Size = new System.Drawing.Size(21, 13);
            this.saidasLbl.TabIndex = 10;
            this.saidasLbl.Text = "R$";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(731, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 1);
            this.panel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(731, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Saldo Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(731, 131);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(21, 13);
            this.totalLbl.TabIndex = 13;
            this.totalLbl.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Buscar:";
            // 
            // buscarDt
            // 
            this.buscarDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.buscarDt.Location = new System.Drawing.Point(63, 12);
            this.buscarDt.Name = "buscarDt";
            this.buscarDt.Size = new System.Drawing.Size(121, 20);
            this.buscarDt.TabIndex = 15;
            this.buscarDt.Value = new System.DateTime(2023, 1, 22, 0, 0, 0, 0);
            this.buscarDt.ValueChanged += new System.EventHandler(this.buscarDt_ValueChanged);
            // 
            // mesesCb
            // 
            this.mesesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesesCb.FormattingEnabled = true;
            this.mesesCb.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.mesesCb.Location = new System.Drawing.Point(63, 12);
            this.mesesCb.Name = "mesesCb";
            this.mesesCb.Size = new System.Drawing.Size(121, 21);
            this.mesesCb.TabIndex = 16;
            this.mesesCb.TextChanged += new System.EventHandler(this.mesesCb_TextChanged);
            // 
            // mesRdo
            // 
            this.mesRdo.AutoSize = true;
            this.mesRdo.Checked = true;
            this.mesRdo.Location = new System.Drawing.Point(190, 13);
            this.mesRdo.Name = "mesRdo";
            this.mesRdo.Size = new System.Drawing.Size(45, 17);
            this.mesRdo.TabIndex = 17;
            this.mesRdo.TabStop = true;
            this.mesRdo.Text = "Mês";
            this.mesRdo.UseVisualStyleBackColor = true;
            this.mesRdo.CheckedChanged += new System.EventHandler(this.Radios);
            // 
            // dataRdo
            // 
            this.dataRdo.AutoSize = true;
            this.dataRdo.Location = new System.Drawing.Point(241, 13);
            this.dataRdo.Name = "dataRdo";
            this.dataRdo.Size = new System.Drawing.Size(48, 17);
            this.dataRdo.TabIndex = 18;
            this.dataRdo.Text = "Data";
            this.dataRdo.UseVisualStyleBackColor = true;
            this.dataRdo.CheckedChanged += new System.EventHandler(this.Radios);
            // 
            // FluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 379);
            this.Controls.Add(this.dataRdo);
            this.Controls.Add(this.mesRdo);
            this.Controls.Add(this.mesesCb);
            this.Controls.Add(this.buscarDt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saidasLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entradasLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saidasDg);
            this.Controls.Add(this.entradasDg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FluxoDeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.entradasDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView entradasDg;
        private System.Windows.Forms.DataGridView saidasDg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label entradasLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label saidasLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker buscarDt;
        private System.Windows.Forms.ComboBox mesesCb;
        private System.Windows.Forms.RadioButton mesRdo;
        private System.Windows.Forms.RadioButton dataRdo;
    }
}