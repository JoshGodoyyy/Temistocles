namespace Temistocles {
    partial class Pagamentos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamentos));
            this.incluirBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.servicoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.valorTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // incluirBtn
            // 
            this.incluirBtn.Location = new System.Drawing.Point(106, 91);
            this.incluirBtn.Name = "incluirBtn";
            this.incluirBtn.Size = new System.Drawing.Size(75, 23);
            this.incluirBtn.TabIndex = 29;
            this.incluirBtn.Text = "Incluir";
            this.incluirBtn.UseVisualStyleBackColor = true;
            this.incluirBtn.Click += new System.EventHandler(this.incluirBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(187, 91);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 28;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cliente:";
            // 
            // clientesCb
            // 
            this.clientesCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientesCb.FormattingEnabled = true;
            this.clientesCb.Location = new System.Drawing.Point(64, 12);
            this.clientesCb.Name = "clientesCb";
            this.clientesCb.Size = new System.Drawing.Size(198, 21);
            this.clientesCb.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Serviço:";
            // 
            // servicoTxt
            // 
            this.servicoTxt.Location = new System.Drawing.Point(64, 39);
            this.servicoTxt.Name = "servicoTxt";
            this.servicoTxt.Size = new System.Drawing.Size(198, 20);
            this.servicoTxt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data:";
            // 
            // dataDt
            // 
            this.dataDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDt.Location = new System.Drawing.Point(64, 65);
            this.dataDt.Name = "dataDt";
            this.dataDt.Size = new System.Drawing.Size(80, 20);
            this.dataDt.TabIndex = 35;
            this.dataDt.Value = new System.DateTime(2023, 2, 3, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Valor:";
            // 
            // valorTxt
            // 
            this.valorTxt.Location = new System.Drawing.Point(190, 65);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(72, 20);
            this.valorTxt.TabIndex = 37;
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 126);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataDt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.servicoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientesCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incluirBtn);
            this.Controls.Add(this.cancelarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incluirBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientesCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox servicoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataDt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorTxt;
    }
}