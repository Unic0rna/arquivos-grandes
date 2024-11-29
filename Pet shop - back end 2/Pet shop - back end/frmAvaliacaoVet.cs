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
    public partial class frmAvaliacaoVet : Form
    {
        string vazio { get; set; }

        public frmAvaliacaoVet()
        {
            InitializeComponent();
        }

        private void estrela1_Click(object sender, EventArgs e)
        {
            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela2_Click(object sender, EventArgs e)
        {
            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela3_Click(object sender, EventArgs e)
        {
            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela4_Click(object sender, EventArgs e)
        {
            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela5_Click(object sender, EventArgs e)
        {
            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
        }


        private void frmAvaliacaoVet_Load(object sender, EventArgs e)
        {
            vazio = "Pet_shop___back_end.Properties.Resources.icons8_estrela_50";

            if (estrela1.Image == Pet_shop___back_end.Properties.Resources.estrela_preenchida)
            {
                 
            }
        }


    }
}
