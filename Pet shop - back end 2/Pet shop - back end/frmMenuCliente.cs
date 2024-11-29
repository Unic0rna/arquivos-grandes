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
            frmVeterinario veterinario = new frmVeterinario();
            veterinario.MdiParent = this;
            veterinario.Show();

        }
    }
}
