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
    public partial class frmLogin : Form
    {
        public string email = "a";
        public string VeSenha { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            OlhoAberto.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            frmRede_Senha senha = new frmRede_Senha();
            string b = txtSenha.Text, a = senha.txtNova_Senha.Text;

            if (txtEmail.Text == "a" && txtSenha.Text == "a")
            {
                frmMenuAdm menu = new frmMenuAdm();
                menu.Show();
                this.Hide();
            }

            else if (txtEmail.Text == "a" && txtSenha.Text == VeSenha)
            {
                frmMenuAdm menu = new frmMenuAdm();
                menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("usuário ou senha incorreta!", "Atenção!", MessageBoxButtons.OK);
            }

            //if (b.Contains(senha.txtNova_Senha.Text))
            //{
            //    MessageBox.Show("teste");
            //}
        }

        private void OlhoFechado_Click(object sender, EventArgs e)
        {
            OlhoAberto.Visible = true;
            OlhoFechado.Visible = false;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void OlhoAberto_Click(object sender, EventArgs e)
        {
            OlhoFechado.Visible = true;
            OlhoAberto.Visible = false;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__1_1;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_ver_;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            frmRede_Senha senha = new frmRede_Senha();
            senha.Show();
            this.Hide();

            lblSenha.ForeColor = Color.Violet;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
