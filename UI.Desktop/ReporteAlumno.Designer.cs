
namespace UI.Desktop
{
    partial class ReporteAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetAlumno = new UI.Desktop.DataSetAlumno();
            this.alumnos_inscripcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnos_inscripcionesTableAdapter = new UI.Desktop.DataSetAlumnoTableAdapters.alumnos_inscripcionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnos_inscripcionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.alumnos_inscripcionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetAlumno
            // 
            this.DataSetAlumno.DataSetName = "DataSetAlumno";
            this.DataSetAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnos_inscripcionesBindingSource
            // 
            this.alumnos_inscripcionesBindingSource.DataMember = "alumnos_inscripciones";
            this.alumnos_inscripcionesBindingSource.DataSource = this.DataSetAlumno;
            // 
            // alumnos_inscripcionesTableAdapter
            // 
            this.alumnos_inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlumno";
            this.Text = "ReporteAlumno";
            this.Load += new System.EventHandler(this.ReporteAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnos_inscripcionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource alumnos_inscripcionesBindingSource;
        private DataSetAlumno DataSetAlumno;
        private DataSetAlumnoTableAdapters.alumnos_inscripcionesTableAdapter alumnos_inscripcionesTableAdapter;
    }
}