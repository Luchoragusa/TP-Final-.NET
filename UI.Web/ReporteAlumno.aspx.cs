using System;
using System.Collections.Generic;
using System.Data;
using Business.Entities;
using Business.Logic;
using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using Microsoft.Reporting.WebForms;
using System.Web.UI.WebControls;
using Table = iText.Layout.Element.Table;

namespace UI.Web
{
    public partial class ReporteAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Alumno_InscripcionLogic alumnoLogic = new Alumno_InscripcionLogic();
                try
                {                    
                    ReportDataSource rds = new ReportDataSource("dsReporteAlumnoss", alumnoLogic.GetAll());
                    this.rvwrAlumnos.LocalReport.ReportEmbeddedResource = "UI.Web.ReportAlumno.rdlc";
                    this.rvwrAlumnos.LocalReport.DataSources.Clear();
                    this.rvwrAlumnos.LocalReport.DataSources.Add(rds);
                    this.rvwrAlumnos.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("Error al recuperar lista de curso " + ex);
                }
            }
        }
        
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}