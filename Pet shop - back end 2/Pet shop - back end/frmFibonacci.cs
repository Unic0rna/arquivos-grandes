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
    public partial class frmFibonacci : Form
    {
        int[] lista = new int[20];

        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void txtDigitado_KeyUp(object sender, KeyEventArgs e)
        {
            int x;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                bool converteu = int.TryParse(txtDigitado.Text, out x);
                if (converteu == false)
                {
                    lblErro.Visible = true;
                    lblErro.Text = "Dígito inválido, por favor digite um número inteiro";
                    txtDigitado.Clear();
                    return;
                }

                if (x < 0)
                {
                    lblErro.Visible= true;
                    lblErro.Text = "Não é possível calcular com número negativo. Por favor digite um número positivo";
                    return;
                }
                btResp.Focus();
               
            }
        }

        private void btResp_Click(object sender, EventArgs e)
        {
            int anterior = 0, atual = 1, proximo;
            int x;

            bool converteu = int.TryParse(txtDigitado.Text, out x);
            if (converteu == false || x < 0)
            {
                lblErro.Visible = true;
                lblErro.Text = "Dígito inválido, por favor digite um número inteiro";
                return;
            }
            lblErro.Visible = false;

                lblResult.Text = "Os primeiros " + x + " dígitos são: \n" +
                   anterior + ", " + atual;

                for (int i = 2; i < x; i++)
                {
                    proximo = anterior + atual;

                    lblResult.Text = lblResult.Text + ", " + proximo;

                    anterior = atual;
                    atual = proximo;

                }

               btLimpar.Visible = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            btLimpar.Visible = false;
            txtDigitado.Clear();
            lblResult.Text = "";
            txtDigitado.Focus();
        }

        private void btResp_MouseHover(object sender, EventArgs e)
        {
            btResp.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__1_;
        }

        private void btResp_MouseEnter(object sender, EventArgs e)
        {
            btResp.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__1_;
        }

        private void btResp_MouseLeave(object sender, EventArgs e)
        {
            btResp.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btLimpar_MouseEnter(object sender, EventArgs e)
        {
            btLimpar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_ver_;
        }

        private void btLimpar_MouseLeave(object sender, EventArgs e)
        {
            btLimpar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }
    }
}
