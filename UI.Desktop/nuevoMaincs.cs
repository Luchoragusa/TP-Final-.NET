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
    public partial class nuevoMaincs : Form
    {
        public nuevoMaincs()
        {
            InitializeComponent();
            customizeDesign();
        }

        private Usuario us;

        public nuevoMaincs(int tipo, Usuario u)
        {
            frmLogin appLogin = new frmLogin();
            appLogin.Close();

            us = u;

            InitializeComponent();


            if (tipo == 1)          //alumno
            {
                btnAdmin.Visible = false;
                btnDoc.Visible = false;
                panelDocSubMenu.Visible = false;
                panelAdminSubMenu.Visible = false;
            }
            else if (tipo == 2)     //docente
            {
                btnAlu.Visible = false;
                btnAdmin.Visible = false;
                panelAluSubMenu.Visible = false;
                panelAdminSubMenu.Visible = false;
                us = u;
            }
            else if (tipo == 3)     //admin
            {
                btnAlu.Visible = true;
                btnDoc.Visible = true;
                btnAdmin.Visible = true;
                panelAluSubMenu.Visible = true;
                panelDocSubMenu.Visible = true;
                panelAdminSubMenu.Visible = true;
            }
        }

        private void customizeDesign()
        {
            panelAluSubMenu.Visible = false;
            panelDocSubMenu.Visible = false;
            panelAdminSubMenu.Visible = false;
        }


        private void esconderSubMenu()
        {
            if (panelAluSubMenu.Visible == true)        
                panelAluSubMenu.Visible = false;

            if (panelDocSubMenu.Visible == true)
                panelDocSubMenu.Visible = false;

            if (panelAdminSubMenu.Visible == true)
                panelAdminSubMenu.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAluSubMenu); //falta conceder permisos para que solo se vea el menu de alumno si inicio secion alumno, lo mismo con los otros dos
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelDocSubMenu);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }

        private void btnAluAlumnoInscripcion_Click(object sender, EventArgs e)
        {
            Alum_Inscrip.Alum_Inscrip a_i = new Alum_Inscrip.Alum_Inscrip();
            a_i.ShowDialog();
        }

        private void btnAluComision_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones();
            com.ShowDialog();
        }

        private void btnAluMateria_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.ShowDialog();
        }

        private void btnAluPlan_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.ShowDialog();
        }

        private void btnAluEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad esp = new Especialidad();
            esp.ShowDialog();
        }

        private void btnDocDocenteCurso_Click(object sender, EventArgs e)
        {
            DocenteCurso.DocenteCurso dc = new DocenteCurso.DocenteCurso();
            dc.ShowDialog();
        }

        private void btnDocRegistrarNota_Click(object sender, EventArgs e)
        {
            UI.Desktop.Curso.CursosNotas cursoAresgistrarNota = new UI.Desktop.Curso.CursosNotas(us);
            cursoAresgistrarNota.ShowDialog();
        }

        private void btnAdminUsuario_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
        }

        private void btnAdminPersona_Click(object sender, EventArgs e)
        {
            Persona.Persona per = new Persona.Persona();
            per.ShowDialog();
        }

        private void btnAdminRegistrarNota_Click(object sender, EventArgs e)
        {
            UI.Desktop.Curso.CursosNotas cursoAresgistrarNota = new UI.Desktop.Curso.CursosNotas(us);
            cursoAresgistrarNota.ShowDialog();
        }

        private void btnAdminComision_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones();
            com.ShowDialog();
        }

        private void btnAdminPlan_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            plan.ShowDialog();
        }

        private void btnAdminMateria_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            mat.ShowDialog();
        }

        private void btnAdminEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad esp = new Especialidad();
            esp.ShowDialog();
        }

        private void btnAdminCurso_Click(object sender, EventArgs e)
        {
            Cursos curso = new UI.Desktop.Cursos();
            curso.ShowDialog();
        }

        private void btnAdminDocenteCurso_Click(object sender, EventArgs e)
        {
            DocenteCurso.DocenteCurso dc = new DocenteCurso.DocenteCurso();
            dc.ShowDialog();
        }

        private void btnAdminAlum_Insc_Click(object sender, EventArgs e)
        {
            Alum_Inscrip.Alum_Inscrip a_i = new Alum_Inscrip.Alum_Inscrip();
            a_i.ShowDialog();
        }

        private void btnAdminReporteAlu_Click(object sender, EventArgs e)
        {
            UI.Desktop.ReporteAlumno reporteAlu = new UI.Desktop.ReporteAlumno();
            reporteAlu.ShowDialog();
        }

        private void btnAdminReporteCom_Click(object sender, EventArgs e)
        {
            UI.Desktop.ReporteComi reporteC = new UI.Desktop.ReporteComi();
            reporteC.ShowDialog();
        }
    }
}
