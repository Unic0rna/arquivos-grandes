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
    public partial class frmAvaBanho : Form
    {
        string nota;
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\AvaBanho.txt";

        public frmAvaBanho()
        {
            InitializeComponent();
        }

        private void estrela1_Click(object sender, EventArgs e)
        {
            nota = "1";

            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela2_Click(object sender, EventArgs e)
        {
            nota = "2";

            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela3_Click(object sender, EventArgs e)
        {
            nota = "3";

            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.icons8_estrela_50;
        }

        private void estrela4_Click(object sender, EventArgs e)
        {
            nota = "4";

            estrela1.Image = Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela5.Image = Properties.Resources.icons8_estrela_50;
        }

        private void estrela5_Click(object sender, EventArgs e)
        {
            nota = "5";

            estrela1.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela2.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela3.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela4.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
            estrela5.Image = Pet_shop___back_end.Properties.Resources.estrela_preenchida;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho,true))
            {
                sw.WriteLine(" ");

                 if (txtAva.Text == "" && estrela1.Image == Properties.Resources.icons8_estrela_50)
                 {
                    MessageBox.Show("Erro ao enviar a sua avaliação, por favor digite seu comentário e selecione sua nota","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

                 else
                 {
                    if (nota == "1")
                    {
                        sw.WriteLine("Nota: 1.0");
                    }

                    else if (nota == "2")
                    {
                        sw.WriteLine("Nota: 2.0");
                    }

                    else if (nota == "3")
                    {
                        sw.WriteLine("Nota: 3.0");
                    }

                    else if (nota == "4")
                    {
                        sw.WriteLine("Nota: 4.0");
                    }

                    else
                    {
                        sw.WriteLine("Nota: 5.0");
                    }

                    sw.WriteLine("Comentário: " + txtAva.Text);
                    sw.WriteLine("__________");
                    sw.Close();

                    MessageBox.Show("Enviado com sucesso! Agradecemos por enviar sua avaliação","Enviado",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                 }
            }
        }
    }
}
