namespace Temistocles {
    partial class EditarCliente {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientesLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nascimentoDt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.masculinoRdo = new System.Windows.Forms.RadioButton();
            this.femininoRdo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contatoTxt = new System.Windows.Forms.MaskedTextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.ativoChk = new System.Windows.Forms.CheckBox();
            this.limparLnk = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientesLst);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // clientesLst
            // 
            this.clientesLst.FormattingEnabled = true;
            this.clientesLst.Location = new System.Drawing.Point(6, 19);
            this.clientesLst.Name = "clientesLst";
            this.clientesLst.Size = new System.Drawing.Size(188, 199);
            this.clientesLst.TabIndex = 0;
            this.clientesLst.SelectedIndexChanged += new System.EventHandler(this.clientesLst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(218, 28);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(240, 20);
            this.nomeTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nascimento:";
            // 
            // nascimentoDt
            // 
            this.nascimentoDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimentoDt.Location = new System.Drawing.Point(290, 54);
            this.nascimentoDt.Name = "nascimentoDt";
            this.nascimentoDt.Size = new System.Drawing.Size(79, 20);
            this.nascimentoDt.TabIndex = 4;
            this.nascimentoDt.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo:";
            // 
            // masculinoRdo
            // 
            this.masculinoRdo.AutoSize = true;
            this.masculinoRdo.Location = new System.Drawing.Point(258, 80);
            this.masculinoRdo.Name = "masculinoRdo";
            this.masculinoRdo.Size = new System.Drawing.Size(73, 17);
            this.masculinoRdo.TabIndex = 6;
            this.masculinoRdo.TabStop = true;
            this.masculinoRdo.Text = "Masculino";
            this.masculinoRdo.UseVisualStyleBackColor = true;
            // 
            // femininoRdo
            // 
            this.femininoRdo.AutoSize = true;
            this.femininoRdo.Location = new System.Drawing.Point(337, 78);
            this.femininoRdo.Name = "femininoRdo";
            this.femininoRdo.Size = new System.Drawing.Size(67, 17);
            this.femininoRdo.TabIndex = 7;
            this.femininoRdo.TabStop = true;
            this.femininoRdo.Text = "Feminino";
            this.femininoRdo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço:";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.Location = new System.Drawing.Point(218, 116);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(240, 20);
            this.enderecoTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contato:";
            // 
            // contatoTxt
            // 
            this.contatoTxt.Location = new System.Drawing.Point(218, 155);
            this.contatoTxt.Name = "contatoTxt";
            this.contatoTxt.Size = new System.Drawing.Size(125, 20);
            this.contatoTxt.TabIndex = 11;
            this.contatoTxt.Leave += new System.EventHandler(this.contatoTxt_Leave);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(383, 213);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 12;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(302, 213);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 13;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // ativoChk
            // 
            this.ativoChk.AutoSize = true;
            this.ativoChk.Location = new System.Drawing.Point(218, 181);
            this.ativoChk.Name = "ativoChk";
            this.ativoChk.Size = new System.Drawing.Size(50, 17);
            this.ativoChk.TabIndex = 14;
            this.ativoChk.Text = "Ativo";
            this.ativoChk.UseVisualStyleBackColor = true;
            // 
            // limparLnk
            // 
            this.limparLnk.AutoSize = true;
            this.limparLnk.Location = new System.Drawing.Point(349, 158);
            this.limparLnk.Name = "limparLnk";
            this.limparLnk.Size = new System.Drawing.Size(38, 13);
            this.limparLnk.TabIndex = 15;
            this.limparLnk.TabStop = true;
            this.limparLnk.Text = "Limpar";
            this.limparLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limparLnk_LinkClicked);
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 248);
            this.Controls.Add(this.limparLnk);
            this.Controls.Add(this.ativoChk);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.contatoTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.femininoRdo);
            this.Controls.Add(this.masculinoRdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nascimentoDt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox clientesLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker nascimentoDt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton masculinoRdo;
        private System.Windows.Forms.RadioButton femininoRdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox contatoTxt;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.CheckBox ativoChk;
        private System.Windows.Forms.LinkLabel limparLnk;
    }
}