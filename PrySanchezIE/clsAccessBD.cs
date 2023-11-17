using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySanchezIE
{
    public class clsAccessBD
    {
        public string EstadoConexion;
        public string Errores;
        public string DatosExtraidos; //string//

        OleDbConnection conexionBD; // se crea objeto para hacer la conexion//
        public string rutaArchivo;
        OleDbCommand comandoBD; //  se crea objeto que indica tareas para hacer dentro de la base de datos//
        OleDbDataReader lectorBD;// lee de inicio a fin registros de datos//

        OleDbDataAdapter adaptadorDS;// carga informacion a un DataSet////ejecuta lo que esta en el comnado, ej tae una tabla//
        DataSet objDataSet = new DataSet();// contiene varias bases de  datos o tablas de base de datos////graba, actualiza y borra// // se crea global para utilizar dentro del proyecto//
        public void ConectarBaseDatos()
        {
            try
            {
                if (rutaArchivo == null)
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../BaseDatos/Usuarios.accdb";
                }
                else
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
                }


                conexionBD = new OleDbConnection();

                conexionBD.ConnectionString = rutaArchivo;

                conexionBD.Open();

                EstadoConexion = "Conectado a la base " + conexionBD.DataSource;
            }
            catch (Exception exepcion)
            {
                MessageBox.Show("Error en la conexión." + exepcion.Message);
            }

        }
        public void TraerDatos(TextBox Usuario, TextBox Contraseña)
        {
            //optimiza el código//
            try
            {
                //trae la tabla//
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Users";

                //lo carga en el lector//
                lectorBD = comandoBD.ExecuteReader();

                while (lectorBD.Read())
                {
                    if (lectorBD[1] == Usuario.Text)
                    {
                        if (lectorBD[2] == Contraseña.Text)
                        {
                            MessageBox.Show("Encontrado");
                        }
                    }

                }
            }
            // hace que no se detenga el proyecto y siga funcionando//
            catch (Exception ex)
            {
                // si hay error, me lo muestra en error//
                MessageBox.Show(ex.Message);
            }

        }
    }
}
