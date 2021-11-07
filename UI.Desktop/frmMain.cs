using System;
using System.Windows.Forms;
using Business.Entities;
using UI.Desktop.DocenteCurso;
using UI.Desktop.RegistrarNotas;
using UI.Desktop.RegitrarDocenteCurso;

namespace UI.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        private Usuario us;

        public frmMain(int tipo, Usuario u)
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
            }
            else if (tipo == 3)     //admin
            {
                btnAlu.Visible = false;
                btnDoc.Visible = false;
                btnAdmin.Visible = true;
                panelAluSubMenu.Visible = false;
                panelDocSubMenu.Visible = false;
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

        private void abrirFormHijo(object formHija)
        {
            if (this.panelCont.Controls.Count > 0)
                this.panelCont.Controls.RemoveAt(0);
            Form fh = formHija as Form;
                fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAluSubMenu); 
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelDocSubMenu);
        }
        private void btnRegistroNotas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new DocenteMateria(us));
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelAdminSubMenu);
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Alum_Inscrip.Alum_Inscrip(us));
        }

        private void btnAluComision_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Comisiones(us));
        }

        private void btnAluMateria_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Materia(us));
        }
        private void btnInscripcionCurso_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Cursos_Docente(us));
        }

        private void btnAdminUsuario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Usuarios());
        }

        private void btnAdminPersona_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Persona.Persona());
        }

        private void btnAdminRegistrarNota_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Docente_Alumnos());
        }

        private void btnAdminComision_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Comisiones());
        }

        private void btnAdminPlan_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Plan());
        }

        private void btnAdminMateria_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Materia());
        }

        private void btnAdminEspecialidad_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Especialidad());
        }

        private void btnAdminCurso_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Cursos());
        }

        private void btnAdminDocenteCurso_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Cursos_Docente());
        }

        private void btnAdminAlum_Insc_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Alum_Inscrip.Alum_Inscrip());
        }

        private void btnAdminReporteCom_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ReporteComi());
        }

        private void btnAdminReportePer_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ReporteDePersonas());
        }
        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new InscribirseACursado(us));
        }
    }
}
