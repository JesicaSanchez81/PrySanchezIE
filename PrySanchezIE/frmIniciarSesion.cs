﻿using System;
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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            clsAccessBD conexion = new clsAccessBD();
            conexion.ConectarBaseDatos();
            conexion.TraerDatos(txtUsuario, txtContraseña);
        }
    }
}
