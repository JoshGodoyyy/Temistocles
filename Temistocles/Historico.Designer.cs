namespace Temistocles {
    partial class Historico {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contatoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.historicoDG = new System.Windows.Forms.DataGridView();
            this.sairBtn = new System.Windows.Forms.Button();
            this.graficoBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nascimentoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Enabled = false;
            this.nomeTxt.Location = new System.Drawing.Point(53, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.ReadOnly = true;
            this.nomeTxt.Size = new System.Drawing.Size(200, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contato:";
            // 
            // contatoTxt
            // 
            this.contatoTxt.Enabled = false;
            this.contatoTxt.Location = new System.Drawing.Point(312, 12);
            this.contatoTxt.Name = "contatoTxt";
            this.contatoTxt.ReadOnly = true;
            this.contatoTxt.Size = new System.Drawing.Size(100, 20);
            this.contatoTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.Enabled = false;
            this.enderecoTxt.Location = new System.Drawing.Point(74, 38);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.ReadOnly = true;
            this.enderecoTxt.Size = new System.Drawing.Size(510, 20);
            this.enderecoTxt.TabIndex = 5;
            // 
            // historicoDG
            // 
            this.historicoDG.AllowUserToAddRows = false;
            this.historicoDG.AllowUserToDeleteRows = false;
            this.historicoDG.AllowUserToResizeRows = false;
            this.historicoDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historicoDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.historicoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoDG.Location = new System.Drawing.Point(12, 77);
            this.historicoDG.Name = "historicoDG";
            this.historicoDG.ReadOnly = true;
            this.historicoDG.RowHeadersVisible = false;
            this.historicoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historicoDG.ShowEditingIcon = false;
            this.historicoDG.Size = new System.Drawing.Size(572, 187);
            this.historicoDG.TabIndex = 6;
            // 
            // sairBtn
            // 
            this.sairBtn.Location = new System.Drawing.Point(509, 270);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(75, 23);
            this.sairBtn.TabIndex = 7;
            this.sairBtn.Text = "Sair";
            this.sairBtn.UseVisualStyleBackColor = true;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // graficoBtn
            // 
            this.graficoBtn.Location = new System.Drawing.Point(12, 270);
            this.graficoBtn.Name = "graficoBtn";
            this.graficoBtn.Size = new System.Drawing.Size(75, 23);
            this.graficoBtn.TabIndex = 8;
            this.graficoBtn.Text = "Gráfico";
            this.graficoBtn.UseVisualStyleBackColor = true;
            this.graficoBtn.Click += new System.EventHandler(this.graficoBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nascimento:";
            // 
            // nascimentoTxt
            // 
            this.nascimentoTxt.Enabled = false;
            this.nascimentoTxt.Location = new System.Drawing.Point(490, 12);
            this.nascimentoTxt.Name = "nascimentoTxt";
            this.nascimentoTxt.ReadOnly = true;
            this.nascimentoTxt.Size = new System.Drawing.Size(94, 20);
            this.nascimentoTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medidas (cm)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(335, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(53, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medidas (cm)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(339, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 12;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nascimentoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.graficoBtn);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.historicoDG);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contatoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.historicoDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contatoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.DataGridView historicoDG;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Button graficoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nascimentoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}