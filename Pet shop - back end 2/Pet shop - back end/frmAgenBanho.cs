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
    public partial class frmAgenBanho : Form
    {
        string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Banho.txt";

        public frmAgenBanho()
        {
            InitializeComponent();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            txtObservacoes.Text = "";
            txtObservacoes.ForeColor = Color.Black;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnAgendar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__6_;
            btnAgendar.ForeColor = Color.White;
        }

        private void btnAgendar_MouseLeave(object sender, EventArgs e)
        {
            btnAgendar.BackgroundImage = Pet_shop___back_end.Properties.Resources.bot_sombra;
            btnAgendar.ForeColor = Color.Black;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (txtBanho.Text == "" || txtPet.Text == "" || cbPeso.Text == "" ||
                cbServico.Text == "" || maskHora.Text == "")
            {
                MessageBox.Show("Erro, por favor preencha os espaços obrigatórios", "Falta de informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho,true))
                {
                    sw.WriteLine(" ");
                    sw.Write(txtPet.Text + ";");
                    sw.Write(cbPeso.Text + ";");
                    sw.Write(txtBanho.Text + ";");
                    sw.Write(cbServico.Text + ";");
                    sw.Write(dateTimePicker1.Text + ";");
                    sw.Write(maskHora.Text);

                    txtPet.Clear();
                    txtBanho.Text = "";
                    cbPeso.Text = null;
                    cbServico.Text = null;

                    MessageBox.Show("Agendamento feito com sucesso!", "Serviço agendado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
