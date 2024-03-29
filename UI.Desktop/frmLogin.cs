﻿using System;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            US = new UsuarioLogic();
        }
        public UsuarioLogic US
        {
            get; set;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            int tipo = 0;

            frmMain nm = null;

            usuario.NombreUsuario = this.txtUsuario.Text;
            usuario.Clave = this.txtPass.Text;

            UsuarioLogic loginUsuario = new UsuarioLogic();

            tipo = loginUsuario.login(usuario);

            if (tipo != -1)
            {
                if (tipo == 0)      //Cuenta no habilitada
                {
                    MessageBox.Show("Su cuenta se encuenta desabilitada", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else if (tipo == 1)      //alumno
                {
                    MessageBox.Show("Bienvenido al sistema, usted ingreso como > ALUMNO.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else if (tipo == 2) //docente
                {
                    MessageBox.Show("Bienvenido al sistema, usted ingreso como > DOCENTE.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else if (tipo == 3) //admin
                {
                    MessageBox.Show("Bienvenido al sistema, usted ingreso como > ADMINISTRADOR.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else if (tipo == 4) //nuevo
                {
                    MessageBox.Show("Bienvenido por primera vez al sistema.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    usuario = loginUsuario.GetUsuario(usuario);
                    PersonaDesktop pd = new PersonaDesktop(usuario);
                    pd.ShowDialog();
                }
                if (tipo == 1 || tipo == 2 || tipo == 3)
                {
                    usuario = loginUsuario.GetUsuario(usuario);

                    nm = new frmMain(tipo, usuario); 
                    nm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
