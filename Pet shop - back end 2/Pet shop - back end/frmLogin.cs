using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_shop___back_end
{
    public partial class frmLogin : Form
    {
  
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
            string b = txtSenha.Text, a = senha.txtNova_Senha.Text, linha;
            List<Usuario> listaUsuarios = new List<Usuario>();

            ReadUsuario readUsuario = new ReadUsuario();
            listaUsuarios = readUsuario.BuscaUsuarios();

            var usuario = listaUsuarios.FirstOrDefault(usu => usu.Email == txtEmail.Text && usu.Senha == txtSenha.Text);

            
            if (usuario == null)
            {
                MessageBox.Show("usuário ou senha incorreta!", "Atenção!", MessageBoxButtons.OK);
                return;
                
            }

            if (usuario.TipoUsuario == "adm")
            {
                frmMenuAdm menuAdm = new frmMenuAdm();
                menuAdm.Show();
                this.Hide();
            }
            else
            {
                frmMenuCliente menuCliente = new frmMenuCliente();
                menuCliente.Show();
                this.Hide();
            }

            
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

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
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
                btnEntrar.Focus();
            }
        }
    }
}
