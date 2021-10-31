using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Web
{
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        private Usuario usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public MenuPrincipal(int tipo, Usuario u)
        {
            usuario = u;

            //if (tipo == 1)          //alumno
            //{
            //    lblDocente.Enabled = false;
            //    btnDocenteCurso.Enabled = false;
            //    btnRegistrarNota.Enabled = false;
                
            //    lblReportes.Enabled = false;
            //    btnReporteAlumno.Enabled = false;
            //    btnReporteComision.Enabled = false;

            //}
            //else if (tipo == 2)     //docente
            //{
            //    //lblAlumno.Visible = false;
            //    btnComision.Enabled = false;
            //    btnEspecialidad.Enabled = false;
            //    btnCursoAlumno.Enabled = false;
            //    usuario = u;
            //}
            //else if (tipo == 4)
            //{
            //    //puede ver todo y acceder a todo
            //}
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginWeb.aspx");
        }

        protected void btnReporteAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/ReporteAlumno.aspx");
        }

        protected void btnReporteComision_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/ReporteComi.aspx");
        }

        protected void btnPersona_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/Persona.aspx");
        }

        protected void btnComision_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/Comision.aspx");
        }

        protected void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/Especialidad.aspx");
        }

        protected void btnCursoAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/Curso.aspx");
        }

        protected void btnProfesor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/DocenteCurso.aspx");
        }

        protected void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pag-Individuales/RegistrarNota.aspx");
        }       
    }
}