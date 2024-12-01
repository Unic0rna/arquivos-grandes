using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_shop___back_end
{
    public partial class frmFatorial : Form
    {
        public frmFatorial()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int fat, total=0;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab )
            {
                btnLimpar.Focus();
                e.Handled = true;

                lblErro.Visible = false;

                bool convert = int.TryParse(txtFatorial.Text, out fat);
                if (convert == false)
                {
                    lblErro.Visible = true;
                    lblErro.Text = "Digíto inválido, por favor digite um número inteiro";
                    return;
                }
                lblErro.Visible=false;

                if (fat == 0)
                {
                    btnLimpar.Visible = true;
                    lblResult.Visible = true;
                    lblResult.BackColor = Color.SteelBlue;

                    lblResult.Text = "O fatorial de 0 é 1";
                    return;
                }

                if (fat < 0)
                {
                    btnLimpar.Visible=true;
                    lblResult.Visible = true;
                    lblResult.BackColor = Color.SteelBlue;

                    lblResult.Text = "O fatorial só pode ser calculado com número positivo";
                    return;
                }

                    for (int i = fat; i > 1; i--)
                    {
                        if (total == 0)
                        {
                            total = i * (i - 1);
                        }

                        else
                        {
                            total = total * (i - 1);

                        }

                    }
                
                btnLimpar.Visible = true;
                lblResult.Visible = true;
                pictureBox3.Visible = true;
                lblResult.BackColor = Color.SteelBlue;
                lblResult.Text = "O fatorial de "+ fat +" é " + total;

            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtFatorial.Clear();
            lblResult.Visible = false;
            lblErro.Visible = false;
            btnLimpar.Visible = false;
            pictureBox3.Visible = false;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
        }

        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_ver_;
        }
    }
}
