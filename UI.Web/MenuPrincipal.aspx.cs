using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario us = (Usuario)Session["usuario"];
            Business.Entities.Entidades.Personas per = new Business.Entities.Entidades.Personas();
            per.ID = (int)Session["id_persona"];
            lblNombre.Text = us.Nombre;
            lblApellido.Text = us.Apellido;
            switch (per.ID)
            {
                case 1:     //alumno
                    lblDocente.Visible = false;
                    btnDocenteCurso.Visible = false;
                    btnRegistrarNota.Visible = false;
                    break;
                case 2:     //docente
                    lblAlumno.Visible = false;
                    btnComision.Visible = false;
                    btnEspecialidad.Visible = false;
                    btnCursoAlumno.Visible = false;
                    break;
                default:
                    break;
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginWeb.aspx");
        }

        protected void btnReporteAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReporteAlumno.aspx");
        }

        protected void btnReporteComision_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReporteComi.aspx");
        }

        protected void btnPersona_Click(object sender, EventArgs e)
        {
            Response.Redirect("Persona.aspx");
        }

        protected void btnComision_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comision.aspx");
        }

        protected void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("Especialidad.aspx");
        }

        protected void btnCursoAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("Curso.aspx");
        }

        protected void btnProfesor_Click(object sender, EventArgs e)
        {
            Response.Redirect("DocenteCurso.aspx");
        }

        protected void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNota.aspx");
        }       
    }
}