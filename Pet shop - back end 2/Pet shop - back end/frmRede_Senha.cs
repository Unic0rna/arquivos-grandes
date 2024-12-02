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

    public partial class frmRede_Senha : Form
    {
        public string codigo = "706de";
        public string Novo {get;set;}

        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Login.txt";

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
            
            if (txtCaptcha.Text == codigo && pcbCaixa_Checada.Visible == true && 
                txtNova_Senha.Text == txtConfi_Senha.Text)
            {
                
                ReadUsuario readUsuario = new ReadUsuario();
                List<Usuario> listaUsuarios = readUsuario.BuscaUsuarios();

                var usuario = listaUsuarios.FirstOrDefault(usu => usu.Email == txtEmail.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário inválido", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (txtNova_Senha.Text != txtConfi_Senha.Text)
                {
                    MessageBox.Show("Por favor digite a mesma senha em NOVA SENHA e CONFIRMAR SENHA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int indexLinha = listaUsuarios.IndexOf(usuario);

                string[] arrLine = File.ReadAllLines(caminho);
                arrLine[indexLinha] = usuario.Email + ";" + txtNova_Senha.Text + ";" + usuario.TipoUsuario;
                File.WriteAllLines(caminho, arrLine);

                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                login.Show();
                this.Close();
                
            }

            else
            {
                MessageBox.Show("Captchas não preenchidos corretamente ou não foi preenchido todos os campos","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNova_Senha.Focus();
            }
        }

        private void txtNova_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfi_Senha.Focus();
            }
        }

        private void txtConfi_Senha_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtCaptcha.Focus();
            }
        }

        private void txtCaptcha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfi_Senha.Focus();
            }
        }
    }
}
