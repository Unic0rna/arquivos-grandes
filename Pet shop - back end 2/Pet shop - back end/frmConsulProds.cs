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
    public partial class frmConsulProds : Form
    {
        string caminho = @"C:\Users\Debora\Downloads\Pet shop - back end\Pet shop - back end\Produtos.txt";
        List<string> linhas = new List<string>();
        string linha;

        public frmConsulProds()
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

                lista.DataSource = (linhas);
            }
        }

        private void btnConsult_MouseHover(object sender, EventArgs e)
        {
            btnConsult.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }

        private void btnConsult_MouseMove(object sender, MouseEventArgs e)
        {
            btnConsult.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }

        private void btnConsult_MouseLeave(object sender, EventArgs e)
        {
            btnConsult.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_1;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminho))
            {
                var linhas = File.ReadAllLines(caminho);
                File.WriteAllText (caminho,string.Empty);
            }

        }
    }
}
