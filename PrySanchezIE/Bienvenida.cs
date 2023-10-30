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
            //prendo el reloj para armar el progress bar
            reloj.Enabled = true;
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            if (barraDeCarga.Value ==100)
            {
                //apago el reloj
                reloj.Enabled = false;
                this.Hide();
                frmPrincipal ventana = new frmPrincipal();
                ventana.ShowDialog();

            }
            else
            {
                barraDeCarga.Value += 5;
            }
        }

        private void barraDeCarga_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
