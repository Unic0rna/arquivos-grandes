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
    public partial class frmCadastroProd : Form
    {
        string caminho = @"C:\Users\Debora\Downloads\Pet shop - back end\Pet shop - back end\Produtos.txt";

        public frmCadastroProd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeProd.Text == "" || txtMarca.Text == "" || txtPeso.Text == "" || maskPreco.Text == "," || Opcao.SelectedItem == null)
            {
                MessageBox.Show("Para realizar o cadastro do produto é necessário que todos os campos estejam preenchidos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true))
                {
                    sw.WriteLine(" ");
                    sw.WriteLine("Nome: " + txtNomeProd.Text);
                    sw.WriteLine("Preço unitário: " + maskPreco.Text);
                    sw.WriteLine("Peso: " + txtPeso.Text);
                    sw.WriteLine("Marca: " + txtMarca.Text);

                    if (Opcao.SelectedItem == "Brinquedo")
                    {
                        sw.WriteLine("Categoria: Brinquedo");
                    }

                    else if (Opcao.SelectedItem == "Ração")
                    {
                        sw.WriteLine("Categoria: Ração");
                    }

                    else if (Opcao.SelectedItem == "Petisco")
                    {
                        sw.WriteLine("Categoria: Petisco");
                    }

                    else
                    {
                        sw.WriteLine("Categoria: Estrutura");
                    }

                    sw.WriteLine("________");
                }
                txtMarca.Clear();
                txtPeso.Clear();
                txtNomeProd.Clear();
                maskPreco.Clear();
                Opcao.SelectedItem = null;

                MessageBox.Show("Você foi cadastrado com sucesso!", "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
        }

        private void btnCadastrar_MouseHover(object sender, EventArgs e)
        {
            btnCadastrar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__3_;
        }

        private void btnCadastrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCadastrar.BackgroundImage = Pet_shop___back_end.Properties.Resources.Rectangle_2__4_;
        }

        private void frmCadastroProd_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeProd_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                maskPreco.Focus();
            }
        }

        private void maskPreco_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPeso.Focus();
            }
        }

        private void txtPeso_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
            }
        }

        private void txtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Opcao.Focus();
            }
        }

        private void Opcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
