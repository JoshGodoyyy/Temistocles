namespace Temistocles {
    partial class CadastroCliente {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.masculinoRdo = new System.Windows.Forms.RadioButton();
            this.femininoRdo = new System.Windows.Forms.RadioButton();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.nascimentoDt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.contatoTxt = new System.Windows.Forms.MaskedTextBox();
            this.limparLink = new System.Windows.Forms.LinkLabel();
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
            this.nomeTxt.Location = new System.Drawing.Point(56, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(239, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // masculinoRdo
            // 
            this.masculinoRdo.AutoSize = true;
            this.masculinoRdo.Checked = true;
            this.masculinoRdo.Location = new System.Drawing.Point(52, 64);
            this.masculinoRdo.Name = "masculinoRdo";
            this.masculinoRdo.Size = new System.Drawing.Size(73, 17);
            this.masculinoRdo.TabIndex = 5;
            this.masculinoRdo.TabStop = true;
            this.masculinoRdo.Text = "Masculino";
            this.masculinoRdo.UseVisualStyleBackColor = true;
            // 
            // femininoRdo
            // 
            this.femininoRdo.AutoSize = true;
            this.femininoRdo.Location = new System.Drawing.Point(131, 64);
            this.femininoRdo.Name = "femininoRdo";
            this.femininoRdo.Size = new System.Drawing.Size(67, 17);
            this.femininoRdo.TabIndex = 6;
            this.femininoRdo.TabStop = true;
            this.femininoRdo.Text = "Feminino";
            this.femininoRdo.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(220, 139);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 44;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(139, 139);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 43;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // nascimentoDt
            // 
            this.nascimentoDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimentoDt.Location = new System.Drawing.Point(84, 38);
            this.nascimentoDt.Name = "nascimentoDt";
            this.nascimentoDt.Size = new System.Drawing.Size(82, 20);
            this.nascimentoDt.TabIndex = 3;
            this.nascimentoDt.Value = new System.DateTime(2023, 1, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço:";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.Location = new System.Drawing.Point(74, 87);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(221, 20);
            this.enderecoTxt.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Contato:";
            // 
            // contatoTxt
            // 
            this.contatoTxt.Location = new System.Drawing.Point(65, 113);
            this.contatoTxt.Name = "contatoTxt";
            this.contatoTxt.Size = new System.Drawing.Size(92, 20);
            this.contatoTxt.TabIndex = 10;
            this.contatoTxt.Leave += new System.EventHandler(this.contatoTxt_Leave);
            // 
            // limparLink
            // 
            this.limparLink.AutoSize = true;
            this.limparLink.Location = new System.Drawing.Point(163, 116);
            this.limparLink.Name = "limparLink";
            this.limparLink.Size = new System.Drawing.Size(38, 13);
            this.limparLink.TabIndex = 45;
            this.limparLink.TabStop = true;
            this.limparLink.Text = "Limpar";
            this.limparLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limparLink_LinkClicked);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 174);
            this.Controls.Add(this.limparLink);
            this.Controls.Add(this.contatoTxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nascimentoDt);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.femininoRdo);
            this.Controls.Add(this.masculinoRdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton masculinoRdo;
        private System.Windows.Forms.RadioButton femininoRdo;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.DateTimePicker nascimentoDt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox contatoTxt;
        private System.Windows.Forms.LinkLabel limparLink;
    }
}