using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbUno_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
        }

        private void rbDos_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
        }

        private void cmbElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Eligio: " + cmbElementos.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form2 cambio = new Form2();
            cambio.lblNom.Text = txtNom.Text;
            cambio.lblAp.Text = txtApe.Text;
            cambio.lblTell.Text = txtTel.Text;
            cambio.ShowDialog();
        }
    }
}
