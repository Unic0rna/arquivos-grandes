namespace Pet_shop___back_end
{
    partial class aba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aba));
            this.lblMostrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMostrar
            // 
            this.lblMostrar.BackColor = System.Drawing.Color.Transparent;
            this.lblMostrar.Font = new System.Drawing.Font("Courier New", 23.25F, System.Drawing.FontStyle.Bold);
            this.lblMostrar.ForeColor = System.Drawing.Color.White;
            this.lblMostrar.Location = new System.Drawing.Point(23, 131);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(678, 163);
            this.lblMostrar.TabIndex = 0;
            this.lblMostrar.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 23.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clique no X para fechar";
            // 
            // aba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.aba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label label1;
    }
}