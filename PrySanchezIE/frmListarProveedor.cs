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
            StreamReader leerArchivo = new StreamReader(@"../../BaseDatos/datosproveedores.txt");

            while (!leerArchivo.EndOfStream)
            {
               lblMostrar.Text += leerArchivo.ReadLine();

            }

            leerArchivo.Close();

            ProcedimientoCargarGrilla();

        }

        private void ProcedimientoCargarGrilla()
        {
            dgvDatos.Rows.Clear();

            //CARGAR LA GRILLA CON LOS DATOS
            StreamReader leerArchivoGrilla = new StreamReader(@"../../BaseDatos/Listado de aseguradores.csv");

            while (!leerArchivoGrilla.EndOfStream)
            {                
                leerLinea = leerArchivoGrilla.ReadLine();
             
                separarTexto = leerLinea.Split(';');

                dgvDatos.Rows.Add(separarTexto);

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

            escribirArchivo.WriteLine(txtNumero.Text + ";" + txtDireccion.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtExpendiente.Text + ";" + txtJurisdiccion.Text +";" + txtJuzgado.Text +";" + txtLiquidador.Text + ";");
            //cargar las otras columnas

            escribirArchivo.Close();

            MessageBox.Show("Registro...");
            txtNumero.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtDireccion.Text = "";
            txtJurisdiccion.Text = "";
            txtJuzgado.Text = "";
            txtLiquidador.Text = "";
            txtNumero.Focus();

            ProcedimientoCargarGrilla();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDatos.SelectedRows)
            {
                dgvDatos.Rows.Remove( row );
            }
        }
    }
}
