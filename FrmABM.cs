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
    public partial class FrmABM : Form
    {
        public FrmABM()
        {
            InitializeComponent();
        }

        //Declaro un objeto para llamar a la clase
        ClaseGrillaProveedores x = new ClaseGrillaProveedores();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //LLamo al procedimiento que se encarga de guardar los datos en la grilla
            x.GuardarDatos(txtNumero.Text, txtEntidad.Text, txtApertura.Text, txtNumExpe.Text, txtJuzgado.Text, txtJuridis.Text, txtDireccion.Text, txtLiquidador.Text);

            MessageBox.Show("Datos guardados correctamente");

            //Limpio los campos
            txtNumero.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtNumExpe.Text = "";
            txtJuzgado.Text = "";
            txtJuridis.Text = "";
            txtDireccion.Text = "";
            txtLiquidador.Text = "";
        }

        private void btnSalir4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrilla v6 = new FrmGrilla();
            v6.Show();
        }
    }
}
