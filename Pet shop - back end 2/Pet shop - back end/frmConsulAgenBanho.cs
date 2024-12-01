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
    public partial class frmConsulAgenBanho : Form
    {
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Banho.txt";
        List<string> lista = new List<string>();
        string linha;

        public frmConsulAgenBanho()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
            {
                while ((linha = sr.ReadLine()) != null)
                {
                    lista.Add(linha);
                }

                string[] cabecalho = lista[0].Split(';');
                DataTable dt = new DataTable();

                foreach (string coluna in cabecalho)
                {
                    dt.Columns.Add(coluna);
                }

                lista.RemoveAt(0);

                foreach(var registro in lista)
                {
                    DataRow dr = dt.NewRow();
                    string[] campos = registro.Split(';');

                    for (int i = 0; i < campos.Length; i++)
                    {
                        dr[i] = campos[i];
                    }

                    dt.Rows.Add(dr);
                }

                sr.Close();
                dgvDados.DataSource = dt;

                dgvDados = new DataGridView();
                dgvDados.Update();

            }
        }
    }
}
