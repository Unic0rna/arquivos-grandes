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
    public partial class frmMes : Form
    {
        int mes, data; string texto = "";
        public frmMes()
        {
            InitializeComponent();
        }

        private void btMes_Click(object sender, EventArgs e)
        {
            

            calendario.MinDate = new DateTime(2024, 1, 1);
            calendario.MaxDate = new DateTime(2024, 12, 31);

            bool converteu = int.TryParse(txtDigi.Text, out mes);
            if (converteu == false || mes > 12 || mes <= 0)
            {
                lblErro.Visible = true;
                lblErro.Text = "Dígito inválido, por favor digite de 1 a 12";
                return;
            }

            calendario.Visible = true;
            lblMes.Visible = true;
            lblMes.Text = "O mês correspondente ao número "+mes+" é: ";

            var dataMin = new System.DateTime(2024, mes, 1);

            calendario.MinDate = dataMin;
            calendario.MaxDate = dataMin.AddMonths(1).AddDays(-1);
            texto = dataMin.ToString("MMMM");

            lblMes.Text = lblMes.Text + texto;
            btLimpar.Visible = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtDigi.Clear();
            lblMes.Text = "";
            calendario.Visible = false;
        }

        private void txtDigi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calendario.MinDate = new DateTime(2024, 1, 1);
                calendario.MaxDate = new DateTime(2024, 12, 31);

                bool converteu = int.TryParse(txtDigi.Text, out mes);
                if (converteu == false || mes > 12 || mes <= 0)
                {
                    lblErro.Visible = true;
                    lblErro.Text = "Dígito inválido, por favor digite de 1 a 12";
                    return;
                }

                calendario.Visible = true;
                lblMes.Visible = true;
                lblMes.Text = "O mês correspondente ao número " + mes + " é: ";

                var dataMin = new System.DateTime(2024, mes, 1);

                calendario.MinDate = dataMin;
                calendario.MaxDate = dataMin.AddMonths(1).AddDays(-1);
                texto = dataMin.ToString("MMMM");

                lblMes.Text = lblMes.Text + texto;
                btLimpar.Visible = true;
                btLimpar.Focus();
            }
            
        }
    }
}
