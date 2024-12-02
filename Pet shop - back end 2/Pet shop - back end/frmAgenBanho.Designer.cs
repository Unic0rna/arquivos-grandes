namespace Pet_shop___back_end
{
    partial class frmAgenBanho
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPet = new System.Windows.Forms.TextBox();
            this.txtBanho = new System.Windows.Forms.ComboBox();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.cbPeso = new System.Windows.Forms.ComboBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskHora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(177)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(168, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agendamento de banho e tosa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome do Pet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 35);
            this.label6.TabIndex = 6;
            this.label6.Text = "Serviço adicional:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de banho e tosa:";
            // 
            // txtPet
            // 
            this.txtPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPet.Location = new System.Drawing.Point(220, 110);
            this.txtPet.Name = "txtPet";
            this.txtPet.Size = new System.Drawing.Size(157, 30);
            this.txtPet.TabIndex = 0;
            // 
            // txtBanho
            // 
            this.txtBanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanho.FormattingEnabled = true;
            this.txtBanho.Items.AddRange(new object[] {
            "Banho (R$50,00)",
            "Banho e tosa na máquina (R$80,00)",
            "Banho e tosa na tesoura (R$100,00)"});
            this.txtBanho.Location = new System.Drawing.Point(432, 228);
            this.txtBanho.Name = "txtBanho";
            this.txtBanho.Size = new System.Drawing.Size(254, 33);
            this.txtBanho.TabIndex = 3;
            // 
            // cbServico
            // 
            this.cbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Escovação de dente (R$5,00)",
            "Rostinho na tesoura (R$25,00)",
            "Hidratação (R$25,00)"});
            this.cbServico.Location = new System.Drawing.Point(432, 170);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(254, 33);
            this.cbServico.TabIndex = 2;
            // 
            // cbPeso
            // 
            this.cbPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeso.FormattingEnabled = true;
            this.cbPeso.Items.AddRange(new object[] {
            "Tamanho P - até 10kg",
            "Tamanho M - 10,1kg até 20kg",
            "Tamanho G - 20,1kg até 30kg",
            "Tamanho GG - 30,1kg até 40kg"});
            this.cbPeso.Location = new System.Drawing.Point(472, 108);
            this.cbPeso.Name = "cbPeso";
            this.cbPeso.Size = new System.Drawing.Size(247, 33);
            this.cbPeso.TabIndex = 1;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(142)))), ((int)(((byte)(152)))));
            this.txtObservacoes.Location = new System.Drawing.Point(144, 357);
            this.txtObservacoes.MaxLength = 100;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(542, 146);
            this.txtObservacoes.TabIndex = 6;
            this.txtObservacoes.Text = "Observações sobre seu pet...(opcional)";
            this.txtObservacoes.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 35);
            this.label8.TabIndex = 20;
            this.label8.Text = "Horário:";
            // 
            // maskHora
            // 
            this.maskHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskHora.Location = new System.Drawing.Point(500, 295);
            this.maskHora.Mask = "00:00";
            this.maskHora.Name = "maskHora";
            this.maskHora.Size = new System.Drawing.Size(154, 30);
            this.maskHora.TabIndex = 4;
            this.maskHora.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Poppins Medium", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "mm/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 293);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 30);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 20, 23, 59, 0, 0);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pet_shop___back_end.Properties.Resources.icons8_pegada_de_gato_100__1_;
            this.pictureBox4.Location = new System.Drawing.Point(40, 495);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pet_shop___back_end.Properties.Resources.icons8_pegada_de_gato_100__1_;
            this.pictureBox3.Location = new System.Drawing.Point(12, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pet_shop___back_end.Properties.Resources.icons8_pegada_de_gato_100__1_;
            this.pictureBox2.Location = new System.Drawing.Point(46, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackgroundImage = global::Pet_shop___back_end.Properties.Resources.bot_sombra;
            this.btnAgendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.btnAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(270, 516);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(288, 69);
            this.btnAgendar.TabIndex = 7;
            this.btnAgendar.Text = "Confirmar agendamento";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            this.btnAgendar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnAgendar.MouseLeave += new System.EventHandler(this.btnAgendar_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pet_shop___back_end.Properties.Resources.calopsita;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgenBanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(804, 597);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.cbPeso);
            this.Controls.Add(this.cbServico);
            this.Controls.Add(this.txtBanho);
            this.Controls.Add(this.txtPet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgenBanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgenBanho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPet;
        private System.Windows.Forms.ComboBox txtBanho;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.ComboBox cbPeso;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}