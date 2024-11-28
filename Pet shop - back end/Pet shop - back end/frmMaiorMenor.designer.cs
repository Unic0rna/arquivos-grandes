namespace Pet_shop___back_end
{
    partial class frmMaiorMenor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaiorMenor));
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btVisu = new System.Windows.Forms.Button();
            this.lblMaior = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblTeste = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lblTeste2 = new System.Windows.Forms.Label();
            this.lblTitu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(111, 120);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(251, 31);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite o 1º número:";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeros.Location = new System.Drawing.Point(383, 120);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(270, 30);
            this.txtNumeros.TabIndex = 1;
            this.txtNumeros.TextChanged += new System.EventHandler(this.txtNumeros_TextChanged);
            this.txtNumeros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumeros_KeyUp);
            // 
            // btVisu
            // 
            this.btVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.btVisu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVisu.FlatAppearance.BorderSize = 0;
            this.btVisu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.btVisu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btVisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisu.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVisu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVisu.Location = new System.Drawing.Point(554, 404);
            this.btVisu.Name = "btVisu";
            this.btVisu.Size = new System.Drawing.Size(234, 43);
            this.btVisu.TabIndex = 2;
            this.btVisu.Text = "Visualizar números";
            this.btVisu.UseVisualStyleBackColor = false;
            this.btVisu.Visible = false;
            this.btVisu.Click += new System.EventHandler(this.btVisu_Click);
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.BackColor = System.Drawing.Color.Transparent;
            this.lblMaior.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaior.Location = new System.Drawing.Point(38, 295);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(0, 31);
            this.lblMaior.TabIndex = 3;
            this.lblMaior.Visible = false;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.BackColor = System.Drawing.Color.Transparent;
            this.lblMenor.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(38, 338);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(0, 31);
            this.lblMenor.TabIndex = 4;
            this.lblMenor.Visible = false;
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(383, 153);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(244, 59);
            this.lblErro.TabIndex = 5;
            this.lblErro.Visible = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpar.Location = new System.Drawing.Point(657, 334);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(131, 43);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Visible = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblTeste
            // 
            this.lblTeste.BackColor = System.Drawing.Color.Transparent;
            this.lblTeste.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.Location = new System.Drawing.Point(56, 28);
            this.lblTeste.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(359, 410);
            this.lblTeste.TabIndex = 7;
            this.lblTeste.Visible = false;
            this.lblTeste.Click += new System.EventHandler(this.lblTeste_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumVioletRed;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltar.Location = new System.Drawing.Point(330, 395);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(92, 43);
            this.btVoltar.TabIndex = 8;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Visible = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lblTeste2
            // 
            this.lblTeste2.BackColor = System.Drawing.Color.Transparent;
            this.lblTeste2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste2.Location = new System.Drawing.Point(538, 28);
            this.lblTeste2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.lblTeste2.Name = "lblTeste2";
            this.lblTeste2.Size = new System.Drawing.Size(359, 410);
            this.lblTeste2.TabIndex = 9;
            this.lblTeste2.Visible = false;
            // 
            // lblTitu
            // 
            this.lblTitu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitu.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitu.ForeColor = System.Drawing.Color.White;
            this.lblTitu.Location = new System.Drawing.Point(162, -1);
            this.lblTitu.Name = "lblTitu";
            this.lblTitu.Size = new System.Drawing.Size(441, 105);
            this.lblTitu.TabIndex = 10;
            this.lblTitu.Text = "Digite 20 números e identificamos o maior e menor";
            this.lblTitu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aperte Enter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "2.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(599, 86);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-30, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmMaiorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitu);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.btVisu);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.lblTeste2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaiorMenor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maior e menor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btVisu;
        private System.Windows.Forms.Label lblMaior;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lblTeste2;
        private System.Windows.Forms.Label lblTitu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

