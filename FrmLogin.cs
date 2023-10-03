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
        //Contador de intentos fallidos
        Int32 Cont = 0;

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Definimos las variables para validar
            string VarUsuario = "igna";
            string VarClave = "12";
            string ValidarUsuario;
            string ValidarClave;

            //Lo que ingrese por texto será el valor de mi variable
            ValidarUsuario = TxtUsuario.Text;
            ValidarClave = TxtClave.Text;

            //Comparo las variables, si son iguales paso de Form sino tira error
            if (ValidarUsuario == VarUsuario && ValidarClave == VarClave)
            {
                this.Hide();
                FrmMenu v3 = new FrmMenu();
                v3.Show();

            }
            else
            {
                MessageBox.Show("Usuario o clave inválida");
                TxtUsuario.Clear();
                TxtClave.Clear();
                Cont = Cont + 1;
            }

            //Contador que cierra el programa a los 3 errores
            if (Cont == 3)
            {
                MessageBox.Show("Límite de intentos alcanzado");

                Application.Exit();
            }
            
        }
    }
}
