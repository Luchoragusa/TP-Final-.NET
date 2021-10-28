using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        private Usuario us;
        public formMain()
        {
            InitializeComponent();
        }

        public formMain(int tipo, Usuario u)
        {
            frmLogin appLogin = new frmLogin();
            appLogin.Close();

            us = u;

            InitializeComponent();

            btn_Usuario.Enabled = false;
            btnComision.Enabled = false;
            btnPlan.Enabled = false;
            btnMateria.Enabled = false;
            btnEspecialidad.Enabled = false;
            btnCurso.Enabled = false;
            btnDC.Enabled = false;
            btnAlum_Inscrip.Enabled = false;
            btnPersona.Enabled = false;
            btnRegistrarNota.Enabled = false;

            // debajo se esconden los botones que queremos que no se muestren
            // acorde a que tipo de persona ingresa

            if (tipo == 1)          //alumno
            {
                btnAlum_Inscrip.Enabled = true;
            }
            else if (tipo == 2)     //docente
            {
                btnDC.Enabled = true;
                btnRegistrarNota.Enabled = true;
                us = u;
            }
            else if (tipo == 3)
            {
                btn_Usuario.Enabled = true;
                btnComision.Enabled = true;
                btnPlan.Enabled = true;
                btnMateria.Enabled = true;
                btnEspecialidad.Enabled = true;
                btnCurso.Enabled = true;
                btnDC.Enabled = true;
                btnAlum_Inscrip.Enabled = true;
                btnPersona.Enabled = true;
                btnRegistrarNota.Enabled = true;
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            frmLogin appLogin = new frmLogin();
            //appLogin.Dispose(); // esto deberia cerrar la ventana de Login pero nose porque no lo hace
        }


        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.ShowDialog();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones();
            com.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.ShowDialog();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad esp = new Especialidad();
            esp.ShowDialog();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Cursos curso = new UI.Desktop.Cursos();
            curso.ShowDialog();            
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            DocenteCurso.DocenteCurso dc = new DocenteCurso.DocenteCurso();
            dc.ShowDialog();
        }

        private void Alum_Inscrip_Click(object sender, EventArgs e)
        {
            Alum_Inscrip.Alum_Inscrip a_i = new Alum_Inscrip.Alum_Inscrip();
            a_i.ShowDialog();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona.Persona per = new Persona.Persona();
            per.ShowDialog();
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            UI.Desktop.Curso.CursosNotas cursoAresgistrarNota = new UI.Desktop.Curso.CursosNotas(us);
            cursoAresgistrarNota.ShowDialog();
        }

        private void btnReporteAlumno_Click(object sender, EventArgs e)
        {
            UI.Desktop.ReporteAlumno reporteAlu = new UI.Desktop.ReporteAlumno();
            reporteAlu.ShowDialog();
        }

        private void btnReporteCom_Click(object sender, EventArgs e)
        {
            UI.Desktop.ReporteComi reporteC = new UI.Desktop.ReporteComi();
            reporteC.ShowDialog();
        }
    }
}
