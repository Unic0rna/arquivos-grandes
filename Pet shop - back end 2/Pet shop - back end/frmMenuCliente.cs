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
    public partial class frmMenuCliente : Form
    {
        public string teste { get; set; }

        public frmMenuCliente()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuCliente_Load(object sender, EventArgs e)
        {
            teste = avaliartim.Text;

            ToolTip a = new ToolTip();
            a.Active = true;
            a.AutoPopDelay = 4000;
            a.InitialDelay = 600;
            a.IsBalloon = true;
            a.ToolTipIcon = ToolTipIcon.Info;
            
            //a.SetToolTip(teste, "teste");
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenVet veterinario = new frmAgenVet();
            veterinario.MdiParent = this;
            veterinario.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_ver_;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
        }

        private void redesSociaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRedesSociais redesSociais = new frmRedesSociais();
            redesSociais.MdiParent = this;
            redesSociais.Show();

        }

        private void avaliartim_Click(object sender, EventArgs e)
        {
            frmAvaliacaoVet avaliVet = new frmAvaliacaoVet();
            avaliVet.MdiParent = this;
            avaliVet.Show();
        }

        private void agendarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgenBanho agenBanho = new frmAgenBanho();
            agenBanho.MdiParent = this;
            agenBanho.Show();
        }

        private void avaliarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAvaBanho banho = new frmAvaBanho();
            banho.MdiParent = this;
            banho.Show();
        }

        private void informaçõesPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfil perfil = new frmPerfil();
            perfil.MdiParent = this;
            perfil.Show();
        }

        private void naoSelecionado_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Selecionado.Visible = true;
            naoSelecionado.Visible = false;
        }

        private void Selecionado_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Selecionado.Visible = false;
            naoSelecionado.Visible = true;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.retangulo_escuro;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.Rectangle_1;
        }
    }
}
