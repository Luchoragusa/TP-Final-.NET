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


namespace UI.Web
{
    public partial class LoginWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            US = new UsuarioLogic();
        }

        public UsuarioLogic US
        {
            get; set;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = this.txtUsuario.Text;
            usuario.Clave = this.txtPass.Text;

            UsuarioLogic loginUsuario = new UsuarioLogic();

            int tipo = loginUsuario.login(usuario);

            if (tipo != -1)
            {
                // tipo == 1     alumno
                // tipo == 2     docente
                // tipo == 4     administrador

                Response.Redirect("MenuPrincipal.aspx");
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}