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
    public partial class frmVeterinario : Form
    {
        public frmVeterinario()
        {
            InitializeComponent();
        }

        private void linkWhat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void frmVeterinario_Load(object sender, EventArgs e)
        {
            linkWhat.Links.Add(0, 20, "https://wa.me/5511975345659");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
