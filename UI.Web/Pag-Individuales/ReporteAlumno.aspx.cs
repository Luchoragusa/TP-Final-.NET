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

namespace UI.Web.Pag_Individuales
{
    public partial class ReporteAlumno : System.Web.UI.Page
    {
        public Business.Logic.EntidadesLogic.Alumno_InscripcionLogic al { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            al = new Business.Logic.EntidadesLogic.Alumno_InscripcionLogic();
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.al.GetAll();
            this.gridView.DataBind();
        }

        protected void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            crearPDF();
        }

        public void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter(@"C:\Program Files (x86)\IIS Express\Escritorio\ReportePlanes.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            Business.Logic.EntidadesLogic.Alumno_InscripcionLogic al = new Business.Logic.EntidadesLogic.Alumno_InscripcionLogic();
            List<Business.Entities.Entidades.Alumnos_Inscripciones> alumnosinscrip = al.GetAll();

            documento.SetMargins(60, 20, 55, 20);

            var parrafo = new Paragraph("Cursos de la Academia");
            documento.Add(parrafo);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);

            string[] columnas = { "ID de Curso", "ID de Comision", "Año Calendario", "Cupo" };

            float[] tamanios = { 3, 3, 3, 3 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            foreach (Business.Entities.Entidades.Alumnos_Inscripciones alu in alumnosinscrip)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(alu.IDAlumno.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(alu.IDCurso.ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(alu.Nota.ToString()).SetFont(fontContenido)));
            }

            documento.Add(tabla);
            documento.Close();
        }
    }
}