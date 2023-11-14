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
    public partial class FrmClientes : Form
    {
        ClaseBaseDeDatosClientes objBaseDatos;

        int poc;

        public FrmClientes()
        {
            InitializeComponent();
        }

        int id = 0;
        Int32 a = 0;

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            objBaseDatos = new ClaseBaseDeDatosClientes();

            objBaseDatos.ConectarBD();

            lblEstadoConexion.Text = objBaseDatos.estadoConexion;

            lblEstadoConexion.BackColor = Color.Green;

            objBaseDatos.TraerDatos(dgvDatosClientes);


        }

        //Me permite editar la grilla a través del txt
        private void btnCambiarEstadoCliente_Click(object sender, EventArgs e)
        {
            dgvDatosClientes[7, poc].Value = txtCambiarEstadoCliente.Text;
        }

        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtBusquedaCliente.Text);
            
            if (a <=10)
            {
                MessageBox.Show("Cliente Existente");
                txtBusquedaCliente.Text = "";
            }
            else
            {
                MessageBox.Show("Cliente no Encontrado");
                txtBusquedaCliente.Text = "";
            }

        }

        private void dgvDatosClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //Cuando toco la celda de la grilla, la misma me aparce en el txt para editar
        private void dgvDatosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvDatosClientes.CurrentRow.Index;

            txtCambiarEstadoCliente.Text = dgvDatosClientes[7, poc].Value.ToString();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
