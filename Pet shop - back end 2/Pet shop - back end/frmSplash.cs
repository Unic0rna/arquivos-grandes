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
