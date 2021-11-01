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

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic loginUsuario = new UsuarioLogic();

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = this.txtUsuario.Text;
            usuario.Clave = this.txtPass.Text;

            usuario = loginUsuario.GetUsuario(usuario);            

            if (usuario != null)
            {
                int id_persona = loginUsuario.login(usuario);
                Session["usuario"] = usuario;
                Session["id_persona"] = id_persona;
                Response.Redirect("MenuPrincipal.aspx");
                
            }
            else
            {
                lblIncorrecto.Visible = true;
            }
           
        }
    }
}