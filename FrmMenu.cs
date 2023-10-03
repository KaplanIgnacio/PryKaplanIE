using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryKaplanTrabajo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
           
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMostrar v4 = new FrmMostrar();
            v4.Show();
        }

        private void menúProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
