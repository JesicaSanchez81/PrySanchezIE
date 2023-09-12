using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //usar stream

namespace PrySanchezIE
{
    public partial class frmListarProveedor : Form
    {
        public frmListarProveedor()
        {
            InitializeComponent();
        }

        string leerLinea;
        string[] separarTexto;

        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            // = new es instanciar un objeto de una clase
            StreamReader leerArchivo = new StreamReader("datosproveedores.txt");

            while (!leerArchivo.EndOfStream)
            {
               lblMostrar.Text += leerArchivo.ReadLine();
            }

            leerArchivo.Close();

            ProcedimientoCargarGrilla();

        }

        private void ProcedimientoCargarGrilla()
        {
            grilla.Rows.Clear();

            //CARGAR LA GRILLA CON LOS DATOS
            StreamReader leerArchivoGrilla = new StreamReader("baseproveedores.csv");

            while (!leerArchivoGrilla.EndOfStream)
            {                
                leerLinea = leerArchivoGrilla.ReadLine();
             
                separarTexto = leerLinea.Split(';');

                grilla.Rows.Add(separarTexto);

            }

            leerArchivoGrilla.Close();

        }

        private void BuscarCodigoDuplicado()
        {
            StreamReader leerArchivo = new StreamReader("baseproveedores.csv");

            leerLinea = "";
            separarTexto = null;

            while (!leerArchivo.EndOfStream)
            {
                leerLinea = leerArchivo.ReadLine();
                separarTexto = leerLinea.Split(';');

                if (separarTexto[0] == txtNumero.Text)
                {
                    MessageBox.Show("Código duplicado");
                }

            }

            leerArchivo.Close();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //antes de escribir tengo que chequear el còdigo no se repita
            //mientras el codigo no exista en el archivo
            BuscarCodigoDuplicado();

            //que hay que verificar que el codigo no sea duplicado
            StreamWriter escribirArchivo = new StreamWriter("baseproveedores.csv", true);

            escribirArchivo.WriteLine(txtNumero.Text);
            //cargar las otras columnas

            escribirArchivo.Close();

            MessageBox.Show("Registro...");
            txtNumero.Text = "";
            txtNumero.Focus();

            ProcedimientoCargarGrilla();
        }
    }
}
