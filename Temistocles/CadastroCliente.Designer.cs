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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idadeNmr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.masculinoRdo = new System.Windows.Forms.RadioButton();
            this.femininoRdo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pesoNmr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.estaturaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imcTxt = new System.Windows.Forms.TextBox();
            this.classificacaoTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panturrilhaEsquerdaTxt = new System.Windows.Forms.TextBox();
            this.panturrilhaDireitaTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.coxaEsquerdaTxt = new System.Windows.Forms.TextBox();
            this.coxaDireitaTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.antebracoEsquerdoTxt = new System.Windows.Forms.TextBox();
            this.antebracoDireitoTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bracoEsquerdoTxt = new System.Windows.Forms.TextBox();
            this.bracoDireitoTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.quadrilTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.abdomenTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cinturaTxt = new System.Windows.Forms.TextBox();
            this.toraxTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dataAvaliacaoDt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.idadeNmr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoNmr)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.nomeTxt.Size = new System.Drawing.Size(240, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade:";
            // 
            // idadeNmr
            // 
            this.idadeNmr.Location = new System.Drawing.Point(56, 38);
            this.idadeNmr.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.idadeNmr.Name = "idadeNmr";
            this.idadeNmr.Size = new System.Drawing.Size(47, 20);
            this.idadeNmr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // masculinoRdo
            // 
            this.masculinoRdo.AutoSize = true;
            this.masculinoRdo.Checked = true;
            this.masculinoRdo.Location = new System.Drawing.Point(149, 38);
            this.masculinoRdo.Name = "masculinoRdo";
            this.masculinoRdo.Size = new System.Drawing.Size(73, 17);
            this.masculinoRdo.TabIndex = 5;
            this.masculinoRdo.TabStop = true;
            this.masculinoRdo.Text = "Masculino";
            this.masculinoRdo.UseVisualStyleBackColor = true;
            this.masculinoRdo.CheckedChanged += new System.EventHandler(this.masculinoRdo_CheckedChanged);
            // 
            // femininoRdo
            // 
            this.femininoRdo.AutoSize = true;
            this.femininoRdo.Location = new System.Drawing.Point(228, 38);
            this.femininoRdo.Name = "femininoRdo";
            this.femininoRdo.Size = new System.Drawing.Size(67, 17);
            this.femininoRdo.TabIndex = 6;
            this.femininoRdo.TabStop = true;
            this.femininoRdo.Text = "Feminino";
            this.femininoRdo.UseVisualStyleBackColor = true;
            this.femininoRdo.CheckedChanged += new System.EventHandler(this.femininoRdo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peso:";
            // 
            // pesoNmr
            // 
            this.pesoNmr.DecimalPlaces = 2;
            this.pesoNmr.Location = new System.Drawing.Point(56, 64);
            this.pesoNmr.Name = "pesoNmr";
            this.pesoNmr.Size = new System.Drawing.Size(47, 20);
            this.pesoNmr.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estatura:";
            // 
            // estaturaTxt
            // 
            this.estaturaTxt.Location = new System.Drawing.Point(164, 64);
            this.estaturaTxt.Name = "estaturaTxt";
            this.estaturaTxt.Size = new System.Drawing.Size(58, 20);
            this.estaturaTxt.TabIndex = 10;
            this.estaturaTxt.TextChanged += new System.EventHandler(this.estaturaTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "IMC:";
            // 
            // imcTxt
            // 
            this.imcTxt.Location = new System.Drawing.Point(52, 90);
            this.imcTxt.Name = "imcTxt";
            this.imcTxt.Size = new System.Drawing.Size(100, 20);
            this.imcTxt.TabIndex = 13;
            // 
            // classificacaoTxt
            // 
            this.classificacaoTxt.AutoSize = true;
            this.classificacaoTxt.Location = new System.Drawing.Point(158, 93);
            this.classificacaoTxt.Name = "classificacaoTxt";
            this.classificacaoTxt.Size = new System.Drawing.Size(0, 13);
            this.classificacaoTxt.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panturrilhaEsquerdaTxt);
            this.groupBox1.Controls.Add(this.panturrilhaDireitaTxt);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.coxaEsquerdaTxt);
            this.groupBox1.Controls.Add(this.coxaDireitaTxt);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.antebracoEsquerdoTxt);
            this.groupBox1.Controls.Add(this.antebracoDireitoTxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.bracoEsquerdoTxt);
            this.groupBox1.Controls.Add(this.bracoDireitoTxt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.quadrilTxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.abdomenTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cinturaTxt);
            this.groupBox1.Controls.Add(this.toraxTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 188);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perímetros (cm)";
            // 
            // panturrilhaEsquerdaTxt
            // 
            this.panturrilhaEsquerdaTxt.Location = new System.Drawing.Point(178, 162);
            this.panturrilhaEsquerdaTxt.Name = "panturrilhaEsquerdaTxt";
            this.panturrilhaEsquerdaTxt.Size = new System.Drawing.Size(100, 20);
            this.panturrilhaEsquerdaTxt.TabIndex = 34;
            // 
            // panturrilhaDireitaTxt
            // 
            this.panturrilhaDireitaTxt.Location = new System.Drawing.Point(72, 162);
            this.panturrilhaDireitaTxt.Name = "panturrilhaDireitaTxt";
            this.panturrilhaDireitaTxt.Size = new System.Drawing.Size(100, 20);
            this.panturrilhaDireitaTxt.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Panturrilha:";
            // 
            // coxaEsquerdaTxt
            // 
            this.coxaEsquerdaTxt.Location = new System.Drawing.Point(178, 136);
            this.coxaEsquerdaTxt.Name = "coxaEsquerdaTxt";
            this.coxaEsquerdaTxt.Size = new System.Drawing.Size(100, 20);
            this.coxaEsquerdaTxt.TabIndex = 31;
            // 
            // coxaDireitaTxt
            // 
            this.coxaDireitaTxt.Location = new System.Drawing.Point(72, 136);
            this.coxaDireitaTxt.Name = "coxaDireitaTxt";
            this.coxaDireitaTxt.Size = new System.Drawing.Size(100, 20);
            this.coxaDireitaTxt.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Coxa:";
            // 
            // antebracoEsquerdoTxt
            // 
            this.antebracoEsquerdoTxt.Location = new System.Drawing.Point(178, 110);
            this.antebracoEsquerdoTxt.Name = "antebracoEsquerdoTxt";
            this.antebracoEsquerdoTxt.Size = new System.Drawing.Size(100, 20);
            this.antebracoEsquerdoTxt.TabIndex = 28;
            // 
            // antebracoDireitoTxt
            // 
            this.antebracoDireitoTxt.Location = new System.Drawing.Point(72, 110);
            this.antebracoDireitoTxt.Name = "antebracoDireitoTxt";
            this.antebracoDireitoTxt.Size = new System.Drawing.Size(100, 20);
            this.antebracoDireitoTxt.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Antebraço:";
            // 
            // bracoEsquerdoTxt
            // 
            this.bracoEsquerdoTxt.Location = new System.Drawing.Point(178, 84);
            this.bracoEsquerdoTxt.Name = "bracoEsquerdoTxt";
            this.bracoEsquerdoTxt.Size = new System.Drawing.Size(100, 20);
            this.bracoEsquerdoTxt.TabIndex = 25;
            // 
            // bracoDireitoTxt
            // 
            this.bracoDireitoTxt.Location = new System.Drawing.Point(72, 84);
            this.bracoDireitoTxt.Name = "bracoDireitoTxt";
            this.bracoDireitoTxt.Size = new System.Drawing.Size(100, 20);
            this.bracoDireitoTxt.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Braço:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Esquerdo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Direito";
            // 
            // quadrilTxt
            // 
            this.quadrilTxt.Location = new System.Drawing.Point(209, 45);
            this.quadrilTxt.Name = "quadrilTxt";
            this.quadrilTxt.Size = new System.Drawing.Size(69, 20);
            this.quadrilTxt.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quadril:";
            // 
            // abdomenTxt
            // 
            this.abdomenTxt.Location = new System.Drawing.Point(67, 45);
            this.abdomenTxt.Name = "abdomenTxt";
            this.abdomenTxt.Size = new System.Drawing.Size(87, 20);
            this.abdomenTxt.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Abdomen:";
            // 
            // cinturaTxt
            // 
            this.cinturaTxt.Location = new System.Drawing.Point(191, 19);
            this.cinturaTxt.Name = "cinturaTxt";
            this.cinturaTxt.Size = new System.Drawing.Size(87, 20);
            this.cinturaTxt.TabIndex = 18;
            // 
            // toraxTxt
            // 
            this.toraxTxt.Location = new System.Drawing.Point(49, 19);
            this.toraxTxt.Name = "toraxTxt";
            this.toraxTxt.Size = new System.Drawing.Size(87, 20);
            this.toraxTxt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cintura:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tórax:";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(220, 336);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 16;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(139, 336);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 17;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(85, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Data de Avaliação:";
            // 
            // dataAvaliacaoDt
            // 
            this.dataAvaliacaoDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAvaliacaoDt.Location = new System.Drawing.Point(189, 310);
            this.dataAvaliacaoDt.Name = "dataAvaliacaoDt";
            this.dataAvaliacaoDt.Size = new System.Drawing.Size(106, 20);
            this.dataAvaliacaoDt.TabIndex = 19;
            this.dataAvaliacaoDt.Value = new System.DateTime(2023, 1, 7, 0, 0, 0, 0);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 371);
            this.Controls.Add(this.dataAvaliacaoDt);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.classificacaoTxt);
            this.Controls.Add(this.imcTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estaturaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesoNmr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.femininoRdo);
            this.Controls.Add(this.masculinoRdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idadeNmr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.idadeNmr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoNmr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idadeNmr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton masculinoRdo;
        private System.Windows.Forms.RadioButton femininoRdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown pesoNmr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox estaturaTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox imcTxt;
        private System.Windows.Forms.Label classificacaoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox panturrilhaEsquerdaTxt;
        private System.Windows.Forms.TextBox panturrilhaDireitaTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox coxaEsquerdaTxt;
        private System.Windows.Forms.TextBox coxaDireitaTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox antebracoEsquerdoTxt;
        private System.Windows.Forms.TextBox antebracoDireitoTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bracoEsquerdoTxt;
        private System.Windows.Forms.TextBox bracoDireitoTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox quadrilTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox abdomenTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cinturaTxt;
        private System.Windows.Forms.TextBox toraxTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dataAvaliacaoDt;
    }
}