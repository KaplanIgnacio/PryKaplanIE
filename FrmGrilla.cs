using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryKaplanTrabajo
{
    public partial class FrmGrilla : Form
    {
        //Declaro la variable posición
        int posicion;

        public FrmGrilla()
        {
            InitializeComponent();
        }

        //Declaro objeto para llamar a la clase 
        ClaseGrillaProveedores x = new ClaseGrillaProveedores();

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVerGrilla_Click(object sender, EventArgs e)
        {
            //Simplemente llamo el procedimiento de la clase
            x.MostrarDatos(DgvProveedores);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmABM v5 = new FrmABM();
            v5.Show();

        }

        private void BtnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            //Borro la fila
            DgvProveedores.Rows.RemoveAt(posicion);
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Posiciono la fila que deseo borrar
            posicion = DgvProveedores.CurrentRow.Index;
        }
    }
}
