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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        ClaseBaseDeDatos objAcceso = new ClaseBaseDeDatos();

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            objAcceso.RegistroUsuarios(TxtRegistrarUsuario.Text, TxtRegistrarClave.Text);
            MessageBox.Show("Usuario registrado exitosamente");
            this.Close();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
        }
    }
}
