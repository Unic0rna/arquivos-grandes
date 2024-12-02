using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_shop___back_end
{
    public partial class frmRedesSociais : Form
    {
        public frmRedesSociais()
        {
            InitializeComponent();
        }


        private void frmVeterinario_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnWhats_MouseEnter(object sender, EventArgs e)
        {
            btnWhats.Size = new Size (253, 87);
            btnWhats.Location = new Point (206, 132);
            btnWhats.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_ama;
        }

        private void btnWhats_Click(object sender, EventArgs e)
        {
            Process.Start("https://wa.me/5511975345659");
        }

        private void btnWhats_MouseLeave(object sender, EventArgs e)
        {
            btnWhats.Size = new Size(219, 72);
            btnWhats.Location = new Point (220, 134);
            btnWhats.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_sombra;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnInstagram.Size = new Size(253, 87);
            btnInstagram.Location = new Point(205, 231);
            btnInstagram.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_ama;
        }

        private void btnInstagram_MouseLeave(object sender, EventArgs e)
        {
            btnInstagram.Size = new Size(219, 72);
            btnInstagram.Location = new Point(220, 241);
            btnInstagram.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_sombra;
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/petpatinhas_sp/?igsh=bG4zdnI4N3VmZ2M3#");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnSite.Size = new Size(219, 72);
            btnSite.Location = new Point(220, 392);
            btnSite.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_sombra;
        }

        private void btnSite_MouseEnter(object sender, EventArgs e)
        {
            btnSite.Size = new Size(253, 87);
            btnSite.Location = new Point(204, 390);
            btnSite.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_ama;
        }
    }
}
