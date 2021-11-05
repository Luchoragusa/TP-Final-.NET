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
    public partial class ReportePersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PersonaLogic pl = new PersonaLogic();
                try
                {
                    ReportDataSource rds = new ReportDataSource("DataSet1", pl.GetAll());
                    this.rvwrPersonass.LocalReport.ReportEmbeddedResource = "UI.Web.ReportPersonasWeb.rdlc";
                    this.rvwrPersonass.LocalReport.DataSources.Clear();
                    this.rvwrPersonass.LocalReport.DataSources.Add(rds);
                    this.rvwrPersonass.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("Error al recuperar lista de personas." + ex);
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}