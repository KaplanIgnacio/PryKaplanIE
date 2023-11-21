using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Reflection.Emit;
using System.ComponentModel.Design;

namespace PryKaplanTrabajo
{
    internal class ClaseBaseDeDatosClientes
    {
        //Objetos
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string estadoConexion = "";
        public string datosTabla;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }
        }

        public void TraerDatos(DataGridView grilla)
        {
            //Instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            //Conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("CODIGO_SOCIO", "CODIGO_SOCIO");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Sexo", "Sexo");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");
            grilla.Columns.Add("Actividad", "Actividad");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    string actividad = (bool)lectorBD["Actividad"] ? "Activo" : "Inactivo";

                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], actividad);
                }
            }

        }
        public void BuscarPorID(int codigo)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";  //Que tabla traigo

            //Abre la tabla y muestra por renglón
            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows) 
            {
                bool Find = false; // Bandera
                while (lectorBD.Read())
                {
                    if (int.Parse(lectorBD[0].ToString()) == codigo)
                    {

                        MessageBox.Show("Cliente Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Find = true; // Bandera
                        break;
                    }

                }
                if (Find == false)
                {
                    MessageBox.Show("NO Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void actividadCliente(int codigo)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            adaptadorBD.Fill(objDataSet, "CLIENTES");

            DataTable dt = objDataSet.Tables["CLIENTES"];

            foreach (DataRow dr in dt.Rows)
            {

                if ((int)dr["CODIGO_SOCIO"] == codigo)
                {
                    if ((bool)dr["ACTIVIDAD"] == false)
                    {
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = true;
                        dr.EndEdit();
                        break;
                    }
                    else if ((bool)dr["ACTIVIDAD"] == true)
                    {
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = false;
                        dr.EndEdit();
                        break;
                    }
                }
            }
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);

            adaptadorBD.Update(objDataSet, "CLIENTES");
        }

        public void BuscarPorApellido(string ApellidoCliente)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";//Que tabla traigo

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows) //Si tiene filas
            {
                bool Existe = false;
                while (lectorBD.Read())
                {
                    if (lectorBD[2].ToString() == ApellidoCliente)
                    {
                        MessageBox.Show("El cliente se encuentra registrado", "consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Existe = true;
                        break;
                    }

                }


                if (Existe == false)
                {
                    MessageBox.Show("El cliente no existe",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        public void BuscarPorCodigo(int IDCliente)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "CLIENTES";//Que tabla traigo

            lectorBD = comandoBD.ExecuteReader();

            if (lectorBD.HasRows) //Si tiene filas
            {
                bool Existe = false;
                while (lectorBD.Read())
                {
                    if (int.Parse(lectorBD[0].ToString()) == IDCliente)
                    {
                        MessageBox.Show("El cliente se encuentra registrado", "consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Existe = true;
                        break;
                    }

                }

                if (Existe == false)
                {
                    MessageBox.Show("El cliente no existe",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
