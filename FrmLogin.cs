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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //LLamo a la clase
        ClaseBaseDeDatos objAcceso = new ClaseBaseDeDatos();

        //Contador de intentos fallidos
        Int32 Cont = 0;

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(TxtUsuario.Text, TxtClave.Text) == true)
            {
                this.Hide();
                FrmMenu fm = new FrmMenu();
                fm.Show();
                Cont = 0;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                TxtUsuario.Text = "";
                TxtClave.Text = "";
                Cont++;
            }

            //Contador que cierra el programa a los 3 errores
            if (Cont == 3)
            {
                MessageBox.Show("Límite de intentos alcanzado");

                Application.Exit();
            }
            
        }

        //Es el botón registrar que lleva al otro Form
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario fr = new FrmRegistrarUsuario();
            fr.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
            TxtClave.PasswordChar = '*';
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
