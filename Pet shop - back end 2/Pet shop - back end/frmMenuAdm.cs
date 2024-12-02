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
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void futebolToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void CadasCliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCli CadasCli = new frmCadastroCli();
            CadasCli.MdiParent = this;
            CadasCli.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProd CadasProd = new frmCadastroProd();
            CadasProd.MdiParent = this;
            CadasProd.Show();
        }

        private void produtosCadastradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulProds ConsulProds = new frmConsulProds();
            ConsulProds.MdiParent = this;
            ConsulProds.Show();
        }

        private void maiorEMenor_Click(object sender, EventArgs e)
        {
            frmMaiorMenor MaiorMenor = new frmMaiorMenor();
            MaiorMenor.MdiParent = this;
            MaiorMenor.Show();
        }

        private void mes_Click(object sender, EventArgs e)
        {
            frmMes mes = new frmMes();
            mes.MdiParent = this;
            mes.Show();
        }

        private void futebol_Click(object sender, EventArgs e)
        {
            frmFutebol futebol = new frmFutebol();
            futebol.MdiParent = this;
            futebol.Show();
        }

        private void fibonacci_Click(object sender, EventArgs e)
        {
            frmFibonacci fibonacci = new frmFibonacci();
            fibonacci.MdiParent = this;
            fibonacci.Show();
        }

        private void fatorial_Click(object sender, EventArgs e)
        {
            frmFatorial fatorial = new frmFatorial();
            fatorial.MdiParent = this;
            fatorial.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //produtosToolStripMenuItem.ImageScaling = new Size(60, 60);
        }

        private void agendarConsultaVeterináriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRedesSociais veterinario = new frmRedesSociais();
            veterinario.MdiParent = this;
            veterinario.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulCli clientes = new frmConsulCli();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmRede_Senha senha = new frmRede_Senha();

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
            btnSair.ForeColor = Color.Black;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
            btnSair.ForeColor = Color.White;
        }

        private void ptbPerfil_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;
                ptbPer_Selecionado.Visible = true;
                ptbPerfil.Visible = false;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_1;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Pet_shop___back_end.Properties.Resources.retangulo_escuro;
        }

        private void ptbPer_Selecionado_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            ptbPer_Selecionado.Visible = false;
            ptbPerfil.Visible = true;
        }

        private void veterináToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulAgenVet agenVet = new frmConsulAgenVet();
            agenVet.MdiParent = this;
            agenVet.Show();
        }

        private void atendimentoVeterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulAvaVet avaVet = new frmConsulAvaVet();
            avaVet.MdiParent = this;
            avaVet.Show();
        }

        private void banhoETosaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsulAgenBanho banho = new frmConsulAgenBanho();
            banho.MdiParent = this;
            banho.Show();
        }

        private void atendimentoBanhoETosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulAvaBanho avaBanho = new frmConsulAvaBanho();
            avaBanho.MdiParent = this;
            avaBanho.Show();
        }
    }
}
