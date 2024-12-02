namespace Pet_shop___back_end
{
    partial class frmCadastroCli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskedCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaCon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radNB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radPriv = new System.Windows.Forms.RadioButton();
            this.radOutro = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 66);
            this.panel1.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(313, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 30);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.maskedCelular);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSenhaCon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(43, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 433);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(598, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "@gmail.com";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(313, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 30);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedEmail_KeyUp);
            // 
            // maskedCelular
            // 
            this.maskedCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedCelular.Location = new System.Drawing.Point(313, 113);
            this.maskedCelular.Mask = "(00)00000-0000";
            this.maskedCelular.Name = "maskedCelular";
            this.maskedCelular.Size = new System.Drawing.Size(289, 30);
            this.maskedCelular.TabIndex = 2;
            this.maskedCelular.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedCelular_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label5.Location = new System.Drawing.Point(125, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar senha";
            // 
            // txtSenhaCon
            // 
            this.txtSenhaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCon.Location = new System.Drawing.Point(313, 201);
            this.txtSenhaCon.MaxLength = 20;
            this.txtSenhaCon.Name = "txtSenhaCon";
            this.txtSenhaCon.Size = new System.Drawing.Size(289, 30);
            this.txtSenhaCon.TabIndex = 4;
            this.txtSenhaCon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenhaCon_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label4.Location = new System.Drawing.Point(233, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(313, 155);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(289, 30);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label3.Location = new System.Drawing.Point(211, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label2.Location = new System.Drawing.Point(247, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.panel3.Controls.Add(this.radNB);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.radMasculino);
            this.panel3.Controls.Add(this.radFeminino);
            this.panel3.Controls.Add(this.radPriv);
            this.panel3.Controls.Add(this.radOutro);
            this.panel3.Location = new System.Drawing.Point(23, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 98);
            this.panel3.TabIndex = 19;
            // 
            // radNB
            // 
            this.radNB.AutoSize = true;
            this.radNB.BackColor = System.Drawing.Color.Transparent;
            this.radNB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNB.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.radNB.Location = new System.Drawing.Point(301, 51);
            this.radNB.Name = "radNB";
            this.radNB.Size = new System.Drawing.Size(157, 39);
            this.radNB.TabIndex = 14;
            this.radNB.Text = "Não-Binário";
            this.radNB.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(375, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMasculino.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.radMasculino.Location = new System.Drawing.Point(144, 51);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(137, 39);
            this.radMasculino.TabIndex = 13;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFeminino.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.radFeminino.Location = new System.Drawing.Point(7, 51);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(125, 39);
            this.radFeminino.TabIndex = 11;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // radPriv
            // 
            this.radPriv.AutoSize = true;
            this.radPriv.BackColor = System.Drawing.Color.Transparent;
            this.radPriv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPriv.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.radPriv.Location = new System.Drawing.Point(592, 51);
            this.radPriv.Name = "radPriv";
            this.radPriv.Size = new System.Drawing.Size(196, 39);
            this.radPriv.TabIndex = 15;
            this.radPriv.Text = "Prefiro não dizer";
            this.radPriv.UseVisualStyleBackColor = false;
            // 
            // radOutro
            // 
            this.radOutro.AutoSize = true;
            this.radOutro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radOutro.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.radOutro.Location = new System.Drawing.Point(484, 51);
            this.radOutro.Name = "radOutro";
            this.radOutro.Size = new System.Drawing.Size(90, 39);
            this.radOutro.TabIndex = 12;
            this.radOutro.Text = "Outro";
            this.radOutro.UseVisualStyleBackColor = true;
            this.radOutro.CheckedChanged += new System.EventHandler(this.radOutro_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.label6.Location = new System.Drawing.Point(400, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 48);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadastro";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Pet_shop___back_end.Properties.Resources.PETPATINHAS;
            this.pictureBox5.Location = new System.Drawing.Point(392, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(201, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pet_shop___back_end.Properties.Resources.pet_shop___logo;
            this.pictureBox1.Location = new System.Drawing.Point(300, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btnCadastrar.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.bot_ama;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Poppins Medium", 15F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(336, 362);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 59);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // frmCadastroCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaCon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radPriv;
        private System.Windows.Forms.RadioButton radOutro;
        private System.Windows.Forms.RadioButton radNB;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
    }
}

