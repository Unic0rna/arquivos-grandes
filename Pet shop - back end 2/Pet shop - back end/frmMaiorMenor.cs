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
    public partial class frmMaiorMenor : Form
    {
        int[] lista = new int[20];
        int numeros = 0, comparador;

        public frmMaiorMenor()
        {
            InitializeComponent();
           
        }

        private void txtNumeros_KeyUp(object sender, KeyEventArgs e)
        {
            int maior = -999999999, menor = 999999999, comparador;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                
                if (numeros < 20)
                {
                    
                    lblNum.Text = $"Digite o {numeros + 1}º número:";
                    bool converteu = int.TryParse(txtNumeros.Text, out comparador);
                    if (converteu == false)
                    {
                        lblErro.Visible = true;
                        lblErro.Text = "Dígito inválido, por favor digite um número";
                        return;

                    }
                    lblErro.Visible = false;

                    lista[numeros] = comparador;
                    numeros++;
                    txtNumeros.Clear();
                }

                for (int i = 0; i < numeros; i++)
                {
                    if (lista[i] < menor)
                    {
                        menor = lista[i];
                    }

                    if (lista[i] > maior)
                    {
                        maior = lista[i];
                    }

                    if (i == 19)
                    {
                        lblMenor.Visible = true;
                        lblMaior.Visible = true;
                        lblMaior.Text = "O maior número é " + maior;
                        lblMenor.Text = "O menor número é " + menor;

                        btVisu.Visible = true;
                        btLimpar.Visible = true;    
                        pictureBox3.Visible = true;
                    }
                }
                
               
            }

        }

        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            numeros = 0;
            lista = new int[20];
            lblNum.Text = "Digite o 1º número:";

            lblErro.Text = "";
            lblMaior.Visible = false;
            lblMenor.Visible = false;
            pictureBox3.Visible= false;
        }

        private void lblTeste_Click(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            btVoltar.Visible = false;
            lblTeste.Visible = false;
            lblTeste2.Visible = false;
            txtNumeros.Visible = true;
            btVisu.Visible = true;
            lblNum.Visible = true;
            btLimpar.Visible = true;
            lblMaior.Visible=true;
            lblMenor.Visible=true;
            lblTitu.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            if (numeros == 19)
            {
                lblMaior.Visible=true;
                lblMenor.Visible = true;
                btLimpar.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btVisu_Click(object sender, EventArgs e)
        {
            txtNumeros.Visible = false;
            btLimpar.Visible = false;
            lblTeste.Visible = true;
            lblTeste2.Visible = true;
            btVisu.Visible = false;
            lblNum.Visible = false;
            btVoltar.Visible = true;
            lblMaior.Visible = false;
            lblMenor.Visible=false;
            lblTitu.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;


            int i = 0;
            for (i = 0; i < numeros; i++)
            {
                if (i <=9)
                {
                    lblTeste.Text += $"{i+1}º número: " + lista[i] + "\n";
                }
                
                if (i > 9)
                {
                    lblTeste2.Text += $"{i+1}º número: " + lista[i] + "\n";
                }

            }


        }
    }
}
