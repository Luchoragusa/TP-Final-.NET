using System;
using System.Collections.Generic;
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

namespace UI.Web
{
    public partial class ReporteComi : System.Web.UI.Page
    {
        public CursoLogic clogic { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            clogic = new CursoLogic();
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.clogic.GetAll();
            this.gridView.DataBind();
        }

        protected void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            crearPDF();            
        }

        public void crearPDF()
        {
            CursoLogic cl = new CursoLogic();
            List<Business.Entities.Curso> cursos = cl.GetAll();

            PdfWriter pdfWriter = new PdfWriter("ReportePlanes.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);

            var parrafo = new Paragraph("Cursos de la Academia");
            documento.Add(parrafo);
            documento.Close();

            //PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            //PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            //string[] columnas = { "ID de Curso", "ID de Comision", "Año Calendario", "Cupo" };

            //float[] tamanios = { 3, 3, 3, 3 };
            //Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            //tabla.SetWidth(UnitValue.CreatePercentValue(100));

            //foreach (string columna in columnas)
            //{
            //    tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            //}

            //foreach (Business.Entities.Curso cur in cursos)
            //{
            //    tabla.AddCell(new Cell().Add(new Paragraph(cur.ID.ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(cur.IDComision.ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(cur.AnioCalendario.ToString()).SetFont(fontContenido)));
            //    tabla.AddCell(new Cell().Add(new Paragraph(cur.Cupo.ToString()).SetFont(fontContenido)));
            //}

            //documento.Add(tabla);
            //documento.Close();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuPrincipal.aspx");
        }
    }
}