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

    public partial class frmRede_Senha : Form
    {
        public string codigo = "706de";
        public string Novo {get;set;}

        public frmRede_Senha()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfi_Senha_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            
            if (txtCaptcha.Text == codigo && pcbCaixa_Checada.Visible == true && login.email == txtEmail.Text 
                && txtNova_Senha.Text == txtConfi_Senha.Text)
            {
                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                login.VeSenha = txtNova_Senha.Text;
                login.Show();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Captchas não preenchidos com sucesso ou Não foi preenchido todos os campos","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void pcbCaixa_Vazia_Click(object sender, EventArgs e)
        {
            pcbCaixa_Vazia.Visible = false;
            pcbCaixa_Checada.Visible = true;
        }

        private void pcbCaixa_Checada_Click(object sender, EventArgs e)
        {
            pcbCaixa_Checada.Visible = false;
            pcbCaixa_Vazia.Visible = true;
        }

        private void btnConfi_Senha_MouseEnter(object sender, EventArgs e)
        {
            btnConfi_Senha.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_21;
        }

        private void btnConfi_Senha_MouseLeave(object sender, EventArgs e)
        {
            btnConfi_Senha.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_ama;
        }

        private void frmRede_Senha_Load(object sender, EventArgs e)
        {
           string Nova_Senha = txtNova_Senha.Text;
        }
    }
}
