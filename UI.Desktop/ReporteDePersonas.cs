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
    public partial class ReporteDePersonas : Form
    {
        public ReporteDePersonas()
        {
            InitializeComponent();
        }

        private void ReporteDePersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPersonas.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.DataSetPersonas.personas);

            this.reportViewer1.RefreshReport();
        }
    }
}
