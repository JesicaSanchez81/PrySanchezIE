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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {

        }
    }
}
