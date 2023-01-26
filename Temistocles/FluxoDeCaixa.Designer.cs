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
            this.label4 = new System.Windows.Forms.Label();
            this.entradasLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.saidasLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saidaRdo = new System.Windows.Forms.RadioButton();
            this.entradaRdo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valorTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataTransacaoDt = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.mesesCb = new System.Windows.Forms.ComboBox();
            this.limparLnk = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.entradasDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasDg)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.entradasDg.Location = new System.Drawing.Point(218, 25);
            this.entradasDg.Name = "entradasDg";
            this.entradasDg.ReadOnly = true;
            this.entradasDg.RowHeadersVisible = false;
            this.entradasDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entradasDg.Size = new System.Drawing.Size(350, 315);
            this.entradasDg.TabIndex = 0;
            this.entradasDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entradasDg_CellClick);
            // 
            // saidasDg
            // 
            this.saidasDg.AllowUserToAddRows = false;
            this.saidasDg.AllowUserToDeleteRows = false;
            this.saidasDg.AllowUserToResizeRows = false;
            this.saidasDg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saidasDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saidasDg.Location = new System.Drawing.Point(574, 25);
            this.saidasDg.Name = "saidasDg";
            this.saidasDg.ReadOnly = true;
            this.saidasDg.RowHeadersVisible = false;
            this.saidasDg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saidasDg.Size = new System.Drawing.Size(350, 315);
            this.saidasDg.TabIndex = 1;
            this.saidasDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saidasDg_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saídas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total de Entradas:";
            // 
            // entradasLbl
            // 
            this.entradasLbl.AutoSize = true;
            this.entradasLbl.ForeColor = System.Drawing.Color.Green;
            this.entradasLbl.Location = new System.Drawing.Point(9, 254);
            this.entradasLbl.Name = "entradasLbl";
            this.entradasLbl.Size = new System.Drawing.Size(21, 13);
            this.entradasLbl.TabIndex = 7;
            this.entradasLbl.Text = "R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(9, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 1);
            this.panel2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total de Saídas:";
            // 
            // saidasLbl
            // 
            this.saidasLbl.AutoSize = true;
            this.saidasLbl.ForeColor = System.Drawing.Color.Red;
            this.saidasLbl.Location = new System.Drawing.Point(126, 254);
            this.saidasLbl.Name = "saidasLbl";
            this.saidasLbl.Size = new System.Drawing.Size(21, 13);
            this.saidasLbl.TabIndex = 10;
            this.saidasLbl.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Saldo Total:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(9, 287);
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
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(137, 309);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 31);
            this.salvarBtn.TabIndex = 6;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descricaoTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Location = new System.Drawing.Point(6, 32);
            this.descricaoTxt.Multiline = true;
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(188, 53);
            this.descricaoTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.saidaRdo);
            this.groupBox1.Controls.Add(this.entradaRdo);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo:";
            // 
            // saidaRdo
            // 
            this.saidaRdo.AutoSize = true;
            this.saidaRdo.Location = new System.Drawing.Point(111, 19);
            this.saidaRdo.Name = "saidaRdo";
            this.saidaRdo.Size = new System.Drawing.Size(54, 17);
            this.saidaRdo.TabIndex = 5;
            this.saidaRdo.TabStop = true;
            this.saidaRdo.Text = "Saída";
            this.saidaRdo.UseVisualStyleBackColor = true;
            // 
            // entradaRdo
            // 
            this.entradaRdo.AutoSize = true;
            this.entradaRdo.Location = new System.Drawing.Point(43, 19);
            this.entradaRdo.Name = "entradaRdo";
            this.entradaRdo.Size = new System.Drawing.Size(62, 17);
            this.entradaRdo.TabIndex = 4;
            this.entradaRdo.TabStop = true;
            this.entradaRdo.Text = "Entrada";
            this.entradaRdo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valorTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataTransacaoDt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 79);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // valorTxt
            // 
            this.valorTxt.Location = new System.Drawing.Point(73, 18);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(121, 20);
            this.valorTxt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "R$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor:";
            // 
            // dataTransacaoDt
            // 
            this.dataTransacaoDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTransacaoDt.Location = new System.Drawing.Point(43, 45);
            this.dataTransacaoDt.Name = "dataTransacaoDt";
            this.dataTransacaoDt.Size = new System.Drawing.Size(151, 20);
            this.dataTransacaoDt.TabIndex = 3;
            this.dataTransacaoDt.Value = new System.DateTime(2023, 1, 23, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Data:";
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
            this.mesesCb.Location = new System.Drawing.Point(61, 12);
            this.mesesCb.Name = "mesesCb";
            this.mesesCb.Size = new System.Drawing.Size(151, 21);
            this.mesesCb.TabIndex = 0;
            this.mesesCb.SelectedIndexChanged += new System.EventHandler(this.mesesCb_SelectedIndexChanged);
            // 
            // limparLnk
            // 
            this.limparLnk.AutoSize = true;
            this.limparLnk.Location = new System.Drawing.Point(93, 318);
            this.limparLnk.Name = "limparLnk";
            this.limparLnk.Size = new System.Drawing.Size(38, 13);
            this.limparLnk.TabIndex = 22;
            this.limparLnk.TabStop = true;
            this.limparLnk.Text = "Limpar";
            this.limparLnk.Visible = false;
            this.limparLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limparLnk_LinkClicked);
            // 
            // FluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 352);
            this.Controls.Add(this.limparLnk);
            this.Controls.Add(this.mesesCb);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saidasLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entradasLbl);
            this.Controls.Add(this.label4);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView entradasDg;
        private System.Windows.Forms.DataGridView saidasDg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label entradasLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label saidasLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton saidaRdo;
        private System.Windows.Forms.RadioButton entradaRdo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valorTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dataTransacaoDt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox mesesCb;
        private System.Windows.Forms.LinkLabel limparLnk;
    }
}