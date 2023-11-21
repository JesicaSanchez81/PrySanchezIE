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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
            txtContraseña.PasswordChar = '*';
        }

        clsBasedeDatos objAcceso = new clsBasedeDatos();
        Int32 IntentosFallidos = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmLogo fb = new frmLogo();
                fb.ShowDialog();
                frmIniciarSesion fin = new frmIniciarSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresada es incorrecta");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if (IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzó el límite máximo de intentos");
                }
            }
        }

        public void btnRegistarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmLogo fb = new frmLogo();
                fb.ShowDialog();
                frmIniciarSesion fin = new frmIniciarSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresada es incorrecta");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if (IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzó el límite máximo de intentos");
                }
            }


        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmLogo fb = new frmLogo();
                fb.ShowDialog();
                frmIniciarSesion fin = new frmIniciarSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresada es incorrecta");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if (IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzó el límite máximo de intentos");
                }
            }
        }

        private void btnRegistarse_Click_1(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }
    }
}
