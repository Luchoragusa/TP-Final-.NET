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

            int tipo_persona = (int)Session["tipo_persona"];
            switch (tipo_persona)
            {
                case 1:     //alumno
                    lblDocente.Visible = false;
                    btnDocenteCurso.Visible = false;
                    btnRegistrarNota.Visible = false;
                    lblAdmin.Visible = false;
                    btnEspecialidad.Visible = false;
                    lblAdmin.Visible = false;
                    lblReportes.Visible = false;
                    btnReporteAlumno.Visible = false;
                    btnReporteComision.Visible = false;
                    break;
                case 2:     //docente
                    lblAdmin.Visible = false;
                    btnEspecialidad.Visible = false;
                    lblAlumno.Visible = false;
                    btnComision.Visible = false;
                    btnInscribirseACursado.Visible = false;
                    btnInscripciones.Visible = false;
                    btnComision.Visible = false;
                    btnMateria.Visible = false;
                    btnEspecialidad.Visible = false;
                    lblReportes.Visible = false;
                    btnReporteAlumno.Visible = false;
                    btnReporteComision.Visible = false;
                    break;
                case 3:
                    btnInscribirseACursado.Visible = false;
                    btnRegistrarNota.Visible = false;
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
            Response.Redirect("ReportePersonas.aspx");
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

        protected void btnProfesor_Click(object sender, EventArgs e)
        {
            Response.Redirect("DocenteCurso.aspx");
        }

        protected void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarNota.aspx");
        }

        protected void btnInscribirseACursado_Click(object sender, EventArgs e)
        {
            Response.Redirect("InscribirseACursado.aspx");
        }

        protected void btnInscripciones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alum_Inscrip.aspx");
        }

        protected void btnMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("Materia.aspx");
        }

        protected void btnCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("Curso.aspx");
        }
    }
}