﻿using System;
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
    public partial class frmAgenVet : Form
    {
        public string caminho = @"C:\Pet shop - back end 2\Pet shop - back end\Veterinario.txt";

        public frmAgenVet()
        {
            InitializeComponent();
        }

        private void frmAgenVet_Load(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (txtPet.Text != null && txtTutor.Text != null && cbAnimal != null && cbConsulta != null &&
                maskHora != null && maskTel != null)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho, true))
                {
                    sw.WriteLine(" ");
                    sw.Write(txtTutor.Text + ";");
                    sw.Write(txtPet.Text + ";");
                    sw.Write(maskTel.Text + ";");
                    sw.Write(cbAnimal.Text + ";");
                    sw.Write(cbConsulta.Text + ";");
                    sw.Write(dateTimePicker1.Text + ";");
                    sw.Write(maskHora.Text);
                    sw.Close();
                }

                txtPet.Clear();
                txtTutor.Clear();
                maskHora.Clear();
                maskTel.Clear();
                dateTimePicker1.Text = "";
                cbConsulta.SelectedItem = null;
                cbAnimal.SelectedItem = null;

                MessageBox.Show("Consulta agendada com sucesso!","Agendamento bem sucedido",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Para concluir o agendamento é necessário que todos os campos sejam preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}