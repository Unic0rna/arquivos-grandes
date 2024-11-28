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
    public partial class frmFutebol : Form
    {
       
        public frmFutebol()
        {
            InitializeComponent();
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtIdade_KeyUp(object sender, KeyEventArgs e)
        {
            int idade;

            aba mostrar = new aba();

            if (e.KeyCode == Keys.Enter /*|| e.KeyCode == Keys.Tab*/)
            {
                
                

                bool converteu = int.TryParse(txtIdade.Text, out idade);
                if (converteu == false)
                {
                    lblErro.Visible = true;
                    lblErro.Text = "Dígito inválido, por favor digite a idade do atleta";
                    return;
                }

                lblErro.Visible=false;

                if (idade > 4 && idade < 26)
                {
                    if (idade >= 5 && idade <= 10)
                    {
                       
                        mostrar.resultado = "O atleta é da categoria infantil.";
                    }

                    else if (idade >= 11 && idade <= 15)
                    {
                        
                        mostrar.resultado = "O atleta é da categoria juvenil.";
                    }

                    else if (idade >= 16 && idade <= 20)
                    {
                        
                        mostrar.resultado = "O atleta é da categoria júnior.";
                    }

                    else
                    {
                        
                        mostrar.resultado = "O atleta é da categoria profissional.";
                    }
                }

                else
                {
 
                    mostrar.resultado = "O atleta nâo está na faixa etária permitida.";
                }

                btLimpar.Visible = true;
                
                e.Handled = true;
                mostrar.Show(this);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            
            btLimpar.Visible=false;
        }

        private void btLimpar_MouseEnter(object sender, EventArgs e)
        {
            btLimpar.ForeColor = Color.White;
        }

        private void btLimpar_MouseLeave(object sender, EventArgs e)
        {
            btLimpar.ForeColor = Color.FromArgb (56, 168, 90);
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFutebol_Load(object sender, EventArgs e)
        {

        }
    }
}
