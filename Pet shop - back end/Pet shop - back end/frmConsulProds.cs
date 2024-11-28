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
            string palavra = Convert.ToString(lista.SelectedItem);
            var linhasVelhas = System.IO.File.ReadAllLines(caminho);
            var novasLinhas = linhasVelhas.Where(line => !line.Contains(palavra));
            System.IO.File.WriteAllLines(caminho, novasLinhas);
            FileStream obj = new FileStream(caminho, FileMode.Append);
            obj.Close();

            FileInfo fi = new FileInfo(@"C:\Users\Debora\Downloads\Pet shop - back end\Pet shop - back end\Produtos.txt");
            using (StreamReader sr = fi.OpenText())
            {
                string vazio = "";
                while ((vazio = sr.ReadLine()) != null)
                {
                    lista.Text = vazio;
                }
                sr.Close();
            }
            FileStream obj1 = new FileStream(caminho, FileMode.Append);
            obj1.Close();

            //var linhas = File.ReadAllLines(caminho);
            //var novas = linhas.Where(line => !line.Contains(teste));
            //FileInfo arquivo = new FileInfo(caminho);
            //using (StreamReader sr = arquivo.OpenText())
            //{

            //}



            //if(caminho.Contains(teste))
            //{
            //    caminho.Replace(teste, string.Empty);
            //}


        }
    }
}
