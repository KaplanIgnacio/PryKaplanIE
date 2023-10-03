using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace PryKaplanTrabajo
{
    public class ClaseGrillaProveedores
    {
        //Me posiciono en el archivo de los proveedores
        public string ArchivoProveedores = @"../../Resources/Proveedores/datosProveedor.csv";

        public void GuardarDatos(string num, string ent, string aper, string expe, string juzg, string jurisd, string direc, string liqui)
        {
            //Abro el archivo
            StreamWriter Archivo = new StreamWriter(ArchivoProveedores, true); 

            //El punto y coma le indica a mi grilla que los registros van en distintas columnas
            Archivo.Write(num);
            Archivo.Write(";");
            Archivo.Write(ent);
            Archivo.Write(";");
            Archivo.Write(aper);
            Archivo.Write(";");
            Archivo.Write(expe);
            Archivo.Write(";");
            Archivo.Write(juzg);
            Archivo.Write(";");
            Archivo.Write(jurisd);
            Archivo.Write(";");
            Archivo.Write(direc);
            Archivo.Write(";");
            //El Writeline permite pasar a la fila de abajo
            Archivo.WriteLine(liqui);
            //Cierro el archivo
            Archivo.Close();
            //Libero la memoria
            Archivo.Dispose(); 
        }

        public void MostrarDatos(DataGridView Grilla)
        {
            //creo vector para poder vizualisar correctamente los datos en la grilla 
            string[] datos = new string[8];
            string DatosLeidos = "";
            
            //Limpio la grilla
            Grilla.Rows.Clear();

            //Leo el archivo 
            StreamReader Archivo = new StreamReader(ArchivoProveedores);

            //Leo el archivo linea por linea
            DatosLeidos = Archivo.ReadLine();

            while (DatosLeidos != null)
            {
                //Cargo los datos en el vector
                datos =DatosLeidos.Split(';');
                
                //Cargo los datos en la grilla
                Grilla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);
                
                //Vuelvo a leer el archivo
                DatosLeidos = Archivo.ReadLine();
            }
            Archivo.Close(); 
            Archivo.Dispose(); 
        }
    }
}
