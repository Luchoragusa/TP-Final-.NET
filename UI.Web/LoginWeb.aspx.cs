﻿using System;
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
                int tipo_persona = loginUsuario.login(usuario);
                Session["usuario"] = usuario;
                Session["tipo_persona"] = tipo_persona;
                if (tipo_persona == 0)
                {
                    Response.Redirect("LoginWeb.aspx");
                }
                else if (tipo_persona == 4)
                {
                    Response.Redirect("Persona.aspx");
                }
                Response.Redirect("probando.aspx");
                
            }
            else
            {
                lblIncorrecto.Visible = true;
            }
           
        }
    }
}