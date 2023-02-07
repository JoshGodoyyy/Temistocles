namespace Temistocles {
    partial class Configuracoes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repetirSenhaTxt = new System.Windows.Forms.TextBox();
            this.mostrarSenhaChk = new System.Windows.Forms.CheckBox();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.backupBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.selecionarPastaDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.importarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.caminhoTxt = new System.Windows.Forms.TextBox();
            this.alterarLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(12, 25);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(261, 20);
            this.usuarioTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(12, 64);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(180, 20);
            this.senhaTxt.TabIndex = 3;
            this.senhaTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir senha:";
            // 
            // repetirSenhaTxt
            // 
            this.repetirSenhaTxt.Location = new System.Drawing.Point(12, 103);
            this.repetirSenhaTxt.Name = "repetirSenhaTxt";
            this.repetirSenhaTxt.Size = new System.Drawing.Size(180, 20);
            this.repetirSenhaTxt.TabIndex = 5;
            this.repetirSenhaTxt.UseSystemPasswordChar = true;
            // 
            // mostrarSenhaChk
            // 
            this.mostrarSenhaChk.AutoSize = true;
            this.mostrarSenhaChk.Location = new System.Drawing.Point(198, 64);
            this.mostrarSenhaChk.Name = "mostrarSenhaChk";
            this.mostrarSenhaChk.Size = new System.Drawing.Size(58, 17);
            this.mostrarSenhaChk.TabIndex = 6;
            this.mostrarSenhaChk.Text = "Mostar";
            this.mostrarSenhaChk.UseVisualStyleBackColor = true;
            this.mostrarSenhaChk.CheckedChanged += new System.EventHandler(this.mostrarSenhaChk_CheckedChanged);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(198, 101);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 7;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(12, 182);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(75, 23);
            this.backupBtn.TabIndex = 10;
            this.backupBtn.Text = "Exportar";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Último backup:";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(96, 165);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(0, 13);
            this.dataLbl.TabIndex = 12;
            // 
            // importarBtn
            // 
            this.importarBtn.Location = new System.Drawing.Point(93, 182);
            this.importarBtn.Name = "importarBtn";
            this.importarBtn.Size = new System.Drawing.Size(75, 23);
            this.importarBtn.TabIndex = 14;
            this.importarBtn.Text = "Importar";
            this.importarBtn.UseVisualStyleBackColor = true;
            this.importarBtn.Click += new System.EventHandler(this.importarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Caminho padrão:";
            // 
            // caminhoTxt
            // 
            this.caminhoTxt.Location = new System.Drawing.Point(12, 142);
            this.caminhoTxt.Name = "caminhoTxt";
            this.caminhoTxt.ReadOnly = true;
            this.caminhoTxt.Size = new System.Drawing.Size(218, 20);
            this.caminhoTxt.TabIndex = 16;
            // 
            // alterarLbl
            // 
            this.alterarLbl.AutoSize = true;
            this.alterarLbl.Location = new System.Drawing.Point(236, 145);
            this.alterarLbl.Name = "alterarLbl";
            this.alterarLbl.Size = new System.Drawing.Size(37, 13);
            this.alterarLbl.TabIndex = 17;
            this.alterarLbl.TabStop = true;
            this.alterarLbl.Text = "Alterar";
            this.alterarLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.alterarLbl_LinkClicked);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 217);
            this.Controls.Add(this.alterarLbl);
            this.Controls.Add(this.caminhoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.importarBtn);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.mostrarSenhaChk);
            this.Controls.Add(this.repetirSenhaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repetirSenhaTxt;
        private System.Windows.Forms.CheckBox mostrarSenhaChk;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.FolderBrowserDialog selecionarPastaDialog;
        private System.Windows.Forms.Button importarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caminhoTxt;
        private System.Windows.Forms.LinkLabel alterarLbl;
    }
}