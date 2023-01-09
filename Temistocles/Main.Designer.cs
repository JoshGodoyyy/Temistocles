namespace Temistocles {
    partial class Main {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versaoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cadastrosTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.novaAvaliacaoBtn = new System.Windows.Forms.Button();
            this.editarClienteBtn = new System.Windows.Forms.Button();
            this.novoClienteBtn = new System.Windows.Forms.Button();
            this.financeiroTab = new System.Windows.Forms.TabPage();
            this.pagamentosBtn = new System.Windows.Forms.Button();
            this.fluxoDeCaixaBtn = new System.Windows.Forms.Button();
            this.sairTab = new System.Windows.Forms.TabPage();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.encerrarBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cadastrosTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.financeiroTab.SuspendLayout();
            this.sairTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versaoTxt,
            this.usuarioTxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versaoTxt
            // 
            this.versaoTxt.Name = "versaoTxt";
            this.versaoTxt.Size = new System.Drawing.Size(0, 17);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cadastrosTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // cadastrosTab
            // 
            this.cadastrosTab.Controls.Add(this.tabPage1);
            this.cadastrosTab.Controls.Add(this.financeiroTab);
            this.cadastrosTab.Controls.Add(this.sairTab);
            this.cadastrosTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrosTab.Location = new System.Drawing.Point(0, 0);
            this.cadastrosTab.Name = "cadastrosTab";
            this.cadastrosTab.SelectedIndex = 0;
            this.cadastrosTab.Size = new System.Drawing.Size(800, 60);
            this.cadastrosTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.novaAvaliacaoBtn);
            this.tabPage1.Controls.Add(this.editarClienteBtn);
            this.tabPage1.Controls.Add(this.novoClienteBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 34);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // novaAvaliacaoBtn
            // 
            this.novaAvaliacaoBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.novaAvaliacaoBtn.FlatAppearance.BorderSize = 0;
            this.novaAvaliacaoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaAvaliacaoBtn.Location = new System.Drawing.Point(159, 3);
            this.novaAvaliacaoBtn.Name = "novaAvaliacaoBtn";
            this.novaAvaliacaoBtn.Size = new System.Drawing.Size(93, 28);
            this.novaAvaliacaoBtn.TabIndex = 4;
            this.novaAvaliacaoBtn.Text = "Nova Avaliação";
            this.novaAvaliacaoBtn.UseVisualStyleBackColor = true;
            this.novaAvaliacaoBtn.Click += new System.EventHandler(this.novaAvaliacaoBtn_Click);
            // 
            // editarClienteBtn
            // 
            this.editarClienteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editarClienteBtn.FlatAppearance.BorderSize = 0;
            this.editarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarClienteBtn.Location = new System.Drawing.Point(81, 3);
            this.editarClienteBtn.Name = "editarClienteBtn";
            this.editarClienteBtn.Size = new System.Drawing.Size(78, 28);
            this.editarClienteBtn.TabIndex = 3;
            this.editarClienteBtn.Text = "Editar Cliente";
            this.editarClienteBtn.UseVisualStyleBackColor = true;
            this.editarClienteBtn.Click += new System.EventHandler(this.editarClienteBtn_Click);
            // 
            // novoClienteBtn
            // 
            this.novoClienteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.novoClienteBtn.FlatAppearance.BorderSize = 0;
            this.novoClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoClienteBtn.Location = new System.Drawing.Point(3, 3);
            this.novoClienteBtn.Name = "novoClienteBtn";
            this.novoClienteBtn.Size = new System.Drawing.Size(78, 28);
            this.novoClienteBtn.TabIndex = 2;
            this.novoClienteBtn.Text = "Novo Cliente";
            this.novoClienteBtn.UseVisualStyleBackColor = true;
            this.novoClienteBtn.Click += new System.EventHandler(this.novoClienteBtn_Click);
            // 
            // financeiroTab
            // 
            this.financeiroTab.Controls.Add(this.fluxoDeCaixaBtn);
            this.financeiroTab.Controls.Add(this.pagamentosBtn);
            this.financeiroTab.Location = new System.Drawing.Point(4, 22);
            this.financeiroTab.Name = "financeiroTab";
            this.financeiroTab.Padding = new System.Windows.Forms.Padding(3);
            this.financeiroTab.Size = new System.Drawing.Size(792, 34);
            this.financeiroTab.TabIndex = 1;
            this.financeiroTab.Text = "Financeiro";
            this.financeiroTab.UseVisualStyleBackColor = true;
            // 
            // pagamentosBtn
            // 
            this.pagamentosBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagamentosBtn.FlatAppearance.BorderSize = 0;
            this.pagamentosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagamentosBtn.Location = new System.Drawing.Point(3, 3);
            this.pagamentosBtn.Name = "pagamentosBtn";
            this.pagamentosBtn.Size = new System.Drawing.Size(75, 28);
            this.pagamentosBtn.TabIndex = 0;
            this.pagamentosBtn.Text = "Pagamentos";
            this.pagamentosBtn.UseVisualStyleBackColor = true;
            this.pagamentosBtn.Click += new System.EventHandler(this.pagamentosBtn_Click);
            // 
            // fluxoDeCaixaBtn
            // 
            this.fluxoDeCaixaBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.fluxoDeCaixaBtn.FlatAppearance.BorderSize = 0;
            this.fluxoDeCaixaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fluxoDeCaixaBtn.Location = new System.Drawing.Point(78, 3);
            this.fluxoDeCaixaBtn.Name = "fluxoDeCaixaBtn";
            this.fluxoDeCaixaBtn.Size = new System.Drawing.Size(87, 28);
            this.fluxoDeCaixaBtn.TabIndex = 2;
            this.fluxoDeCaixaBtn.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaBtn.UseVisualStyleBackColor = true;
            this.fluxoDeCaixaBtn.Click += new System.EventHandler(this.fluxoDeCaixaBtn_Click);
            // 
            // sairTab
            // 
            this.sairTab.Controls.Add(this.encerrarBtn);
            this.sairTab.Controls.Add(this.logoutBtn);
            this.sairTab.Location = new System.Drawing.Point(4, 22);
            this.sairTab.Name = "sairTab";
            this.sairTab.Padding = new System.Windows.Forms.Padding(3);
            this.sairTab.Size = new System.Drawing.Size(792, 34);
            this.sairTab.TabIndex = 2;
            this.sairTab.Text = "Sair";
            this.sairTab.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(3, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 28);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // encerrarBtn
            // 
            this.encerrarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.encerrarBtn.FlatAppearance.BorderSize = 0;
            this.encerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encerrarBtn.Location = new System.Drawing.Point(78, 3);
            this.encerrarBtn.Name = "encerrarBtn";
            this.encerrarBtn.Size = new System.Drawing.Size(75, 28);
            this.encerrarBtn.TabIndex = 1;
            this.encerrarBtn.Text = "Encerrar";
            this.encerrarBtn.UseVisualStyleBackColor = true;
            this.encerrarBtn.Click += new System.EventHandler(this.encerrarBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temistoles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.cadastrosTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.financeiroTab.ResumeLayout(false);
            this.sairTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel versaoTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editarClienteBtn;
        private System.Windows.Forms.Button novoClienteBtn;
        private System.Windows.Forms.Button novaAvaliacaoBtn;
        private System.Windows.Forms.Button fluxoDeCaixaBtn;
        private System.Windows.Forms.Button pagamentosBtn;
        private System.Windows.Forms.TabPage sairTab;
        private System.Windows.Forms.Button encerrarBtn;
        private System.Windows.Forms.Button logoutBtn;
        public System.Windows.Forms.ToolStripStatusLabel usuarioTxt;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage financeiroTab;
        public System.Windows.Forms.TabControl cadastrosTab;
    }
}

