using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            usuario.NombreUsuario = this.txtUsuario.Text;
            usuario.Clave = this.txtPass.Text;

            UsuarioLogic loginUsuario = new UsuarioLogic();

            tipo = loginUsuario.login(usuario);

            if (tipo != -1)       
            {
                MessageBox.Show("Usted ingreso al sistema.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;    
                
                formMain main = new formMain();
                main.tipoPersona(tipo);

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
