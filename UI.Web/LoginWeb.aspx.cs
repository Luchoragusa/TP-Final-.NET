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
            
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic loginUsuario = new UsuarioLogic();

            Usuario usuario = loginUsuario.GetUsuario(this.txtUsuario.Text, this.txtPass.Text);
            int id_persona = loginUsuario.login(usuario);

            if (usuario != null)
            {
                Session["usuario"] = usuario;
                Session["id_persona"] = id_persona;
                Response.Redirect("MenuPrincipal.aspx");
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}