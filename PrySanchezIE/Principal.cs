using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySanchezIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verListasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProveedor ventanaListarProveedor = new frmListarProveedor();

            ventanaListarProveedor.ShowDialog();
        }
    }
}
