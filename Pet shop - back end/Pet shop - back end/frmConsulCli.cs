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
    public partial class frmConsulCli : Form
    {
        string caminho = @"C:\Users\Debora\OneDrive\Desktop\Pet shop - back end\Pet shop - back end\Cliente.txt";
        List<string> lista = new List<string>();
        string linha;

        public frmConsulCli()
        {
            InitializeComponent();
        }

        private void frmConsulCli_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
            {
                while ((linha = sr.ReadLine()) != null)
                {
                    lista.Add(linha);
                }

                listaCli.DataSource = lista;
            }

        }
    }
}
