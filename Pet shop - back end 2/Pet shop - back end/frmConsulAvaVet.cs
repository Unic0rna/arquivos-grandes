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
    public partial class frmConsulAvaVet : Form
    {
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\AvaVet.txt";
        List<string> linhas = new List<string>(); 
        string linha;

        public frmConsulAvaVet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
            {
                while ((linha = sr.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                
                lista.DataSource = linhas;
            }
        }

        private void btnConsul_MouseEnter(object sender, EventArgs e)
        {
            btnConsul.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_21;
        }

        private void btnConsul_MouseLeave(object sender, EventArgs e)
        {
            btnConsul.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_ama;
        }
    }
}
