namespace Pet_shop___back_end
{
    partial class frmFibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtDigitado = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btResp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(146, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(25, 280);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(693, 156);
            this.lblResult.TabIndex = 1;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDigitado
            // 
            this.txtDigitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitado.Location = new System.Drawing.Point(426, 146);
            this.txtDigitado.Name = "txtDigitado";
            this.txtDigitado.Size = new System.Drawing.Size(202, 30);
            this.txtDigitado.TabIndex = 0;
            this.txtDigitado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDigitado_KeyUp);
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(422, 179);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(236, 65);
            this.lblErro.TabIndex = 3;
            this.lblErro.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(717, 109);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite um número para aparecer a quantidade de dígitos da sequência Fibonacci";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Pet_shop___back_end.Properties.Resources.icons8_cat_footprint_100__1_;
            this.pictureBox5.Location = new System.Drawing.Point(18, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Pet_shop___back_end.Properties.Resources.icons8_cat_footprint_100__1_;
            this.pictureBox4.Location = new System.Drawing.Point(-8, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Pet_shop___back_end.Properties.Resources.icons8_cat_footprint_100__1_;
            this.pictureBox3.Location = new System.Drawing.Point(31, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.Rectangle_2;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(207, 461);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(142, 61);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Visible = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            this.btLimpar.MouseEnter += new System.EventHandler(this.btLimpar_MouseEnter);
            this.btLimpar.MouseLeave += new System.EventHandler(this.btLimpar_MouseLeave);
            this.btLimpar.MouseHover += new System.EventHandler(this.btLimpar_MouseHover);
            // 
            // btResp
            // 
            this.btResp.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.Rectangle_2;
            this.btResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btResp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btResp.FlatAppearance.BorderSize = 0;
            this.btResp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btResp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResp.ForeColor = System.Drawing.Color.White;
            this.btResp.Location = new System.Drawing.Point(6, 461);
            this.btResp.Name = "btResp";
            this.btResp.Size = new System.Drawing.Size(141, 61);
            this.btResp.TabIndex = 1;
            this.btResp.Text = "Confirmar";
            this.btResp.UseVisualStyleBackColor = false;
            this.btResp.Click += new System.EventHandler(this.btResp_Click);
            this.btResp.MouseEnter += new System.EventHandler(this.btResp_MouseEnter);
            this.btResp.MouseLeave += new System.EventHandler(this.btResp_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Pet_shop___back_end.Properties.Resources.icons8_cat_footprint_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(133, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(745, 536);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btResp);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtDigitado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtDigitado;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btResp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

