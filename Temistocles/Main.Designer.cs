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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.versaoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.companyLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cadastrosTab = new System.Windows.Forms.TabPage();
            this.avaliacoesBtn = new System.Windows.Forms.Button();
            this.editarClienteBtn = new System.Windows.Forms.Button();
            this.novoClienteBtn = new System.Windows.Forms.Button();
            this.financeiroTab = new System.Windows.Forms.TabPage();
            this.fluxoDeCaixaBtn = new System.Windows.Forms.Button();
            this.pagamentosBtn = new System.Windows.Forms.Button();
            this.sairTab = new System.Windows.Forms.TabPage();
            this.encerrarBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.configuracoesBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versaoLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.empresaLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressSave = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.cadastrosTab.SuspendLayout();
            this.financeiroTab.SuspendLayout();
            this.sairTab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // versaoTxt
            // 
            this.versaoTxt.Name = "versaoTxt";
            this.versaoTxt.Size = new System.Drawing.Size(23, 23);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // companyLbl
            // 
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(23, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cadastrosTab);
            this.tabControl1.Controls.Add(this.financeiroTab);
            this.tabControl1.Controls.Add(this.sairTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 60);
            this.tabControl1.TabIndex = 2;
            // 
            // cadastrosTab
            // 
            this.cadastrosTab.Controls.Add(this.avaliacoesBtn);
            this.cadastrosTab.Controls.Add(this.editarClienteBtn);
            this.cadastrosTab.Controls.Add(this.novoClienteBtn);
            this.cadastrosTab.Location = new System.Drawing.Point(4, 22);
            this.cadastrosTab.Name = "cadastrosTab";
            this.cadastrosTab.Size = new System.Drawing.Size(792, 34);
            this.cadastrosTab.TabIndex = 0;
            this.cadastrosTab.Text = "Cadastros";
            this.cadastrosTab.UseVisualStyleBackColor = true;
            // 
            // avaliacoesBtn
            // 
            this.avaliacoesBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.avaliacoesBtn.FlatAppearance.BorderSize = 0;
            this.avaliacoesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avaliacoesBtn.Location = new System.Drawing.Point(156, 0);
            this.avaliacoesBtn.Name = "avaliacoesBtn";
            this.avaliacoesBtn.Size = new System.Drawing.Size(70, 34);
            this.avaliacoesBtn.TabIndex = 4;
            this.avaliacoesBtn.Text = "Avaliações";
            this.avaliacoesBtn.UseVisualStyleBackColor = true;
            this.avaliacoesBtn.Click += new System.EventHandler(this.avaliacoesBtn_Click);
            // 
            // editarClienteBtn
            // 
            this.editarClienteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editarClienteBtn.FlatAppearance.BorderSize = 0;
            this.editarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarClienteBtn.Location = new System.Drawing.Point(78, 0);
            this.editarClienteBtn.Name = "editarClienteBtn";
            this.editarClienteBtn.Size = new System.Drawing.Size(78, 34);
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
            this.novoClienteBtn.Location = new System.Drawing.Point(0, 0);
            this.novoClienteBtn.Name = "novoClienteBtn";
            this.novoClienteBtn.Size = new System.Drawing.Size(78, 34);
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
            this.financeiroTab.Size = new System.Drawing.Size(792, 34);
            this.financeiroTab.TabIndex = 1;
            this.financeiroTab.Text = "Financeiro";
            this.financeiroTab.UseVisualStyleBackColor = true;
            // 
            // fluxoDeCaixaBtn
            // 
            this.fluxoDeCaixaBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.fluxoDeCaixaBtn.FlatAppearance.BorderSize = 0;
            this.fluxoDeCaixaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fluxoDeCaixaBtn.Location = new System.Drawing.Point(75, 0);
            this.fluxoDeCaixaBtn.Name = "fluxoDeCaixaBtn";
            this.fluxoDeCaixaBtn.Size = new System.Drawing.Size(87, 34);
            this.fluxoDeCaixaBtn.TabIndex = 2;
            this.fluxoDeCaixaBtn.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaBtn.UseVisualStyleBackColor = true;
            this.fluxoDeCaixaBtn.Click += new System.EventHandler(this.fluxoDeCaixaBtn_Click);
            // 
            // pagamentosBtn
            // 
            this.pagamentosBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pagamentosBtn.FlatAppearance.BorderSize = 0;
            this.pagamentosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagamentosBtn.Location = new System.Drawing.Point(0, 0);
            this.pagamentosBtn.Name = "pagamentosBtn";
            this.pagamentosBtn.Size = new System.Drawing.Size(75, 34);
            this.pagamentosBtn.TabIndex = 0;
            this.pagamentosBtn.Text = "Pagamentos";
            this.pagamentosBtn.UseVisualStyleBackColor = true;
            this.pagamentosBtn.Click += new System.EventHandler(this.pagamentosBtn_Click);
            // 
            // sairTab
            // 
            this.sairTab.Controls.Add(this.encerrarBtn);
            this.sairTab.Controls.Add(this.logoutBtn);
            this.sairTab.Location = new System.Drawing.Point(4, 22);
            this.sairTab.Name = "sairTab";
            this.sairTab.Size = new System.Drawing.Size(792, 34);
            this.sairTab.TabIndex = 2;
            this.sairTab.Text = "Sair";
            this.sairTab.UseVisualStyleBackColor = true;
            // 
            // encerrarBtn
            // 
            this.encerrarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.encerrarBtn.FlatAppearance.BorderSize = 0;
            this.encerrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encerrarBtn.Location = new System.Drawing.Point(75, 0);
            this.encerrarBtn.Name = "encerrarBtn";
            this.encerrarBtn.Size = new System.Drawing.Size(75, 34);
            this.encerrarBtn.TabIndex = 1;
            this.encerrarBtn.Text = "Encerrar";
            this.encerrarBtn.UseVisualStyleBackColor = true;
            this.encerrarBtn.Click += new System.EventHandler(this.encerrarBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Location = new System.Drawing.Point(0, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 34);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // configuracoesBtn
            // 
            this.configuracoesBtn.BackColor = System.Drawing.Color.Transparent;
            this.configuracoesBtn.FlatAppearance.BorderSize = 0;
            this.configuracoesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuracoesBtn.Image = global::Temistocles.Properties.Resources.Painel_de_Controle;
            this.configuracoesBtn.Location = new System.Drawing.Point(12, 66);
            this.configuracoesBtn.Name = "configuracoesBtn";
            this.configuracoesBtn.Size = new System.Drawing.Size(85, 85);
            this.configuracoesBtn.TabIndex = 2;
            this.configuracoesBtn.Text = "Configurações";
            this.configuracoesBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.configuracoesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.configuracoesBtn.UseVisualStyleBackColor = false;
            this.configuracoesBtn.Visible = false;
            this.configuracoesBtn.Click += new System.EventHandler(this.configuracoesBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versaoLbl,
            this.usuarioLbl,
            this.toolStripStatusLabel4,
            this.empresaLbl,
            this.logLbl,
            this.progressSave});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versaoLbl
            // 
            this.versaoLbl.Name = "versaoLbl";
            this.versaoLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(454, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // empresaLbl
            // 
            this.empresaLbl.Name = "empresaLbl";
            this.empresaLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // progressSave
            // 
            this.progressSave.Maximum = 10;
            this.progressSave.Name = "progressSave";
            this.progressSave.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logLbl
            // 
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(194, 17);
            this.logLbl.Text = "Criando backup de banco de dados";
            this.logLbl.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Temistocles.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.configuracoesBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temistocles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.cadastrosTab.ResumeLayout(false);
            this.financeiroTab.ResumeLayout(false);
            this.sairTab.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel versaoTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editarClienteBtn;
        private System.Windows.Forms.Button novoClienteBtn;
        private System.Windows.Forms.Button avaliacoesBtn;
        private System.Windows.Forms.Button fluxoDeCaixaBtn;
        private System.Windows.Forms.Button pagamentosBtn;
        private System.Windows.Forms.TabPage sairTab;
        private System.Windows.Forms.Button encerrarBtn;
        public System.Windows.Forms.ToolStripStatusLabel usuarioTxt;
        public System.Windows.Forms.TabPage cadastrosTab;
        public System.Windows.Forms.TabPage financeiroTab;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel companyLbl;
        public System.Windows.Forms.Button configuracoesBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel versaoLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel empresaLbl;
        public System.Windows.Forms.ToolStripStatusLabel usuarioLbl;
        private System.Windows.Forms.ToolStripProgressBar progressSave;
        private System.Windows.Forms.ToolStripStatusLabel logLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

