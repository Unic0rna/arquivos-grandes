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
    public partial class aba : Form
    {
        public string resultado { get; set; }
        public aba()
        {
            InitializeComponent();
        }

        private void aba_Load(object sender, EventArgs e)
        {
            lblMostrar.Text = resultado;
        }
    }
}
