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
    public partial class ReporteComi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CursoLogic cl = new CursoLogic();
                try
                {
                    ReportDataSource rds = new ReportDataSource("dsReporteCurso", cl.GetAll());
                    this.ReportViewerCurso.LocalReport.ReportEmbeddedResource = "UI.Web.ReportComi.rdlc";
                    this.ReportViewerCurso.LocalReport.DataSources.Clear();
                    this.ReportViewerCurso.LocalReport.DataSources.Add(rds);
                    this.ReportViewerCurso.DataBind();
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