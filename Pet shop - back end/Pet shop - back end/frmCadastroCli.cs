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
    public partial class frmCadastroCli : Form
    {
        string caminho = @"C:\Users\Debora\OneDrive\Desktop\Pet shop - back end\Pet shop - back end\Cliente.txt";

        public frmCadastroCli()
        {
            InitializeComponent();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text, arroba = "@gmail.com";


            if (txtNome.Text == "" || txtSenha.Text == "" || maskedCelular.Text == "" || txtEmail.Text == "" || txtSenhaCon.Text == "")
            {
                MessageBox.Show("Para o cadastro ser concluído é preciso que seja preenchido todos os campos", "Preencha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true))
                {
                    if (txtSenhaCon.Text == txtSenha.Text)
                    {

                        if (radFeminino.Checked == false && radMasculino.Checked == false && radNB.Checked == false
                            && radOutro.Checked == false && radPriv.Checked == false)
                        {
                            MessageBox.Show("Por favor selecione seu sexo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            sw.WriteLine("");
                            sw.Write(txtNome.Text + "   ");

                            if(email.Contains(arroba))
                            {
                                sw.Write("   "+ txtEmail.Text + "   ");
                            }

                            else
                            {
                                sw.Write("   " + txtEmail.Text + "@gmail.com   ");
                            }
                            
                            sw.Write("   " + maskedCelular.Text + "   ");

                            if (radFeminino.Checked == true)
                            {
                                sw.Write("   Feminino   ");
                            }

                            else if (radMasculino.Checked == true)
                            {
                                sw.Write("   Masculino   ");
                            }

                            else if (radNB.Checked == true)
                            {
                                sw.Write("   Não-Binário   ");
                            }

                            else if (radOutro.Checked == true)
                            {
                                sw.Write("   Outro   ");
                            }

                            else if (radPriv.Checked == true)
                            {
                                sw.Write("   Preferiu não dizer   ");
                            }

                            sw.Write("   " + txtSenha.Text + "   ");
                           
                            sw.Close();
                        }

                        txtEmail.Clear();
                        txtNome.Clear();
                        txtSenha.Clear();
                        txtSenhaCon.Clear();
                        maskedCelular.Clear();
                        radFeminino.Checked = false;
                        radMasculino.Checked = false;
                        radOutro.Checked = false;
                        radPriv.Checked = false;

                        MessageBox.Show("Cadastro feito com sucesso!","Sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("A senha não está igual em SENHA e CONFIRMAR SENHA, por favor escreva a senha igual em ambos campos", "Atenção!", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void maskedEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedCelular.Focus();
            }
        }

        private void maskedCelular_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenhaCon.Focus();
            }
        }

        private void txtSenhaCon_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                btnCadastrar.Focus();
            }
        }

        private void radOutro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
