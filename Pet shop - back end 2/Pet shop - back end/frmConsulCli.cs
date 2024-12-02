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
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Cliente.txt";
        List<string> lista = new List<string>();
        string linha;

        public frmConsulCli()
        {
            InitializeComponent();
        }

        private void frmConsulCli_Load(object sender, EventArgs e)
        {
            dgvDados.EnableHeadersVisualStyles = false;
            dgvDados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 204, 0);
        }

        private void button2_Click(object sender, EventArgs e)
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
                foreach (var registro in lista)
                {
                    DataRow dr = dt.NewRow();
                    string[] campos = registro.Split(';');

                    for (int i = 0; i < campos.Length; i ++)
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

        private void dgvDados_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!e.Row.IsNewRow)
            {
                DialogResult res = MessageBox.Show("Você tem certeza que quer excluir essa linha?", "Deletar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnConsul_MouseEnter(object sender, EventArgs e)
        {
            btnConsul.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }

        private void btnConsul_MouseLeave(object sender, EventArgs e)
        {
            btnConsul.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_1;
        }
    }
}
