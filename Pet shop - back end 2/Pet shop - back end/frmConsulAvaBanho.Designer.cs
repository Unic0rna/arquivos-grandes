namespace Pet_shop___back_end
{
    partial class frmConsulAvaBanho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulAvaBanho));
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConsul = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avaliações do atendimento em banho e tosa";
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.HorizontalScrollbar = true;
            this.lista.ItemHeight = 30;
            this.lista.Location = new System.Drawing.Point(65, 108);
            this.lista.MultiColumn = true;
            this.lista.Name = "lista";
            this.lista.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lista.Size = new System.Drawing.Size(647, 390);
            this.lista.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(617, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnConsul
            // 
            this.btnConsul.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.bot_ama;
            this.btnConsul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.btnConsul.FlatAppearance.BorderSize = 0;
            this.btnConsul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.btnConsul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsul.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsul.Location = new System.Drawing.Point(299, 540);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(182, 53);
            this.btnConsul.TabIndex = 0;
            this.btnConsul.Text = "Consultar";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            this.btnConsul.MouseEnter += new System.EventHandler(this.btnConsul_MouseEnter);
            this.btnConsul.MouseLeave += new System.EventHandler(this.btnConsul_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsulAvaBanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(777, 601);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnConsul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsulAvaBanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação ao atendimento de banho e tosa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}