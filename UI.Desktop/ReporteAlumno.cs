using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ReporteAlumno : Form
    {
        public ReporteAlumno()
        {
            InitializeComponent();
        }

        private void ReporteAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetAlumno.alumnos_inscripciones' Puede moverla o quitarla según sea necesario.
            this.alumnos_inscripcionesTableAdapter.Fill(this.DataSetAlumno.alumnos_inscripciones);

            this.reportViewer1.RefreshReport();
        }
    }
}
