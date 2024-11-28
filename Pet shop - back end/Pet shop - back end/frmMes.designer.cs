namespace Pet_shop___back_end
{
    partial class frmMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDigi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btMes = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número de 1 a 12:";
            // 
            // txtDigi
            // 
            this.txtDigi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigi.Location = new System.Drawing.Point(433, 81);
            this.txtDigi.Name = "txtDigi";
            this.txtDigi.Size = new System.Drawing.Size(156, 30);
            this.txtDigi.TabIndex = 0;
            this.txtDigi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDigi_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(118, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite um número para identificarmos o mês";
            // 
            // calendario
            // 
            this.calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendario.Location = new System.Drawing.Point(245, 261);
            this.calendario.Name = "calendario";
            this.calendario.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2024, 10, 20, 0, 0, 0, 0), new System.DateTime(2024, 10, 26, 0, 0, 0, 0));
            this.calendario.TabIndex = 3;
            this.calendario.Visible = false;
            // 
            // btMes
            // 
            this.btMes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMes.Location = new System.Drawing.Point(12, 486);
            this.btMes.Name = "btMes";
            this.btMes.Size = new System.Drawing.Size(132, 44);
            this.btMes.TabIndex = 1;
            this.btMes.Text = "Confirmar";
            this.btMes.UseVisualStyleBackColor = false;
            this.btMes.Click += new System.EventHandler(this.btMes_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(101, 191);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(0, 33);
            this.lblMes.TabIndex = 6;
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMes.Visible = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btLimpar.Location = new System.Drawing.Point(611, 486);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(132, 44);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Visible = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(427, 114);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 20);
            this.lblErro.TabIndex = 8;
            this.lblErro.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pet_shop___back_end.Properties.Resources.icons8_pegada_de_gato_100__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pet_shop___back_end.Properties.Resources.icons8_pegada_de_gato_100__2_;
            this.pictureBox2.Location = new System.Drawing.Point(53, 395);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // frmMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btMes);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDigi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificador de mês";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDigi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

