namespace Pet_shop___back_end
{
    partial class frmMenuCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCliente));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaVeterináriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarBanhotosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliartim = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Menu.GripMargin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(981, 58);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaVeterináriaToolStripMenuItem,
            this.agendarBanhotosaToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.agendamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(135, 54);
            this.agendamentoToolStripMenuItem.Text = "Serviços";
            // 
            // agendarConsultaVeterináriaToolStripMenuItem
            // 
            this.agendarConsultaVeterináriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaliartim,
            this.agendarToolStripMenuItem});
            this.agendarConsultaVeterináriaToolStripMenuItem.Name = "agendarConsultaVeterináriaToolStripMenuItem";
            this.agendarConsultaVeterináriaToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.agendarConsultaVeterináriaToolStripMenuItem.Text = "Consulta veterinária";
            // 
            // agendarBanhotosaToolStripMenuItem
            // 
            this.agendarBanhotosaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avaliarToolStripMenuItem1,
            this.agendarToolStripMenuItem1});
            this.agendarBanhotosaToolStripMenuItem.Name = "agendarBanhotosaToolStripMenuItem";
            this.agendarBanhotosaToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.agendarBanhotosaToolStripMenuItem.Text = "Banho e tosa";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesPessoaisToolStripMenuItem,
            this.agendamentosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold);
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(189, 54);
            this.ajudaToolStripMenuItem.Text = "Minha conta";
            // 
            // avaliartim
            // 
            this.avaliartim.Name = "avaliartim";
            this.avaliartim.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.avaliartim.Size = new System.Drawing.Size(303, 46);
            this.avaliartim.Text = "Avaliar";
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(303, 46);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.ToolTipText = "Agende a consulta veterinária para seu o Pet";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
            // 
            // avaliarToolStripMenuItem1
            // 
            this.avaliarToolStripMenuItem1.Name = "avaliarToolStripMenuItem1";
            this.avaliarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.avaliarToolStripMenuItem1.Size = new System.Drawing.Size(305, 46);
            this.avaliarToolStripMenuItem1.Text = "Avaliar";
            this.avaliarToolStripMenuItem1.ToolTipText = "Avalie nosso atendimento de banho e tosa";
            // 
            // agendarToolStripMenuItem1
            // 
            this.agendarToolStripMenuItem1.Name = "agendarToolStripMenuItem1";
            this.agendarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.agendarToolStripMenuItem1.Size = new System.Drawing.Size(305, 46);
            this.agendarToolStripMenuItem1.Text = "Agendar";
            this.agendarToolStripMenuItem1.ToolTipText = "Agende o serviço de banho e tosa para o seu Pet";
            // 
            // informaçõesPessoaisToolStripMenuItem
            // 
            this.informaçõesPessoaisToolStripMenuItem.Name = "informaçõesPessoaisToolStripMenuItem";
            this.informaçõesPessoaisToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.informaçõesPessoaisToolStripMenuItem.Text = "Informações pessoais";
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(374, 46);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Poppins Medium", 18F);
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(159, 54);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(763, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 229);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.retangulo_escuro;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(9, 46);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(191, 68);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Voltar a tela de login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.retangulo_escuro;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Poppins Medium", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(15, 141);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 54);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "frmMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuCliente_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaVeterináriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarBanhotosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliartim;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informaçõesPessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSair;
    }
}