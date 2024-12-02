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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progresso.Value == 1)
            {
                patinha1.Visible = true;
            }

            if (progresso.Value == 30)
            {
                patinha2.Visible = true;
            }

            if (progresso.Value == 50)
            {
                patinha3.Visible = true;
            }

            if (progresso.Value == 70)
            {
                patinha4.Visible = true;
            }

            if (progresso.Value == 90)
            {
                patinha5.Visible = true;
            }

            if (progresso.Value == 100)
            {
                patinha6.Visible = true;
            }

            if (progresso.Value < 100)
            {
                progresso.Value++;
                lblPorcentagem.Text = "Carregando... " + progresso.Value.ToString();
            }

            else
            {
                timer.Enabled = false;
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void progresso_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            
        }
    }
}
