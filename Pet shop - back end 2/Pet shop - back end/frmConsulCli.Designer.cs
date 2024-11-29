namespace Pet_shop___back_end
{
    partial class frmConsulCli
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
            this.listaCli = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConsul = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaCli
            // 
            this.listaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCli.FormattingEnabled = true;
            this.listaCli.ItemHeight = 16;
            this.listaCli.Location = new System.Drawing.Point(77, 90);
            this.listaCli.Name = "listaCli";
            this.listaCli.Size = new System.Drawing.Size(648, 276);
            this.listaCli.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // btnConsul
            // 
            this.btnConsul.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.Rectangle_1;
            this.btnConsul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsul.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsul.ForeColor = System.Drawing.Color.White;
            this.btnConsul.Location = new System.Drawing.Point(590, 386);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(170, 52);
            this.btnConsul.TabIndex = 2;
            this.btnConsul.Text = "Consultar";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.Rectangle_1;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::Pet_shop___back_end.Properties.Resources.icons8_lixo_48;
            this.btnLimpar.Location = new System.Drawing.Point(39, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(179, 52);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.Rectangle_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(333, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmConsulCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConsul);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listaCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsulCli";
            this.Text = "frmConsulCli";
            this.Load += new System.EventHandler(this.frmConsulCli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaCli;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}