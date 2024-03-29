﻿using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.ReadOnly = true;
        }
        public void Listar()
        {
            Business.Logic.EntidadesLogic.CursoLogic cl = new Business.Logic.EntidadesLogic.CursoLogic();
            try
            {
                this.dgvCursos.DataSource = cl.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected ", "Ha habido un error interno:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursosDesktop formCDesktop = new CursosDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;

            CursosDesktop formCDesktop = new CursosDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected ", "Ha habido un error interno: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;

            CursosDesktop formCDesktop = new CursosDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
