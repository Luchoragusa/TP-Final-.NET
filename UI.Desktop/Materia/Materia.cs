using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class Materia : Form
    {

        Usuario _us;
        Boolean _esAlumno = true;
        public Materia()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ReadOnly = true;
            _esAlumno = false;
        }
        public Materia(Usuario usuario)
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            this.dgvMaterias.ReadOnly = true;
            _us = usuario;
            tsbEditar.Enabled = false;
            tsbEliminar.Enabled = false;
            tsbNuevo.Enabled = false;
        }
        public void Listar()
        {
            MateriaLogic mat = new MateriaLogic();
            try
            {
                if(_esAlumno)
                    this.dgvMaterias.DataSource = mat.GetAllByAlumno(_us);
                else
                    this.dgvMaterias.DataSource = mat.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Materia_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            MateriaDesktop formMDesktop = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formMDesktop.ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formMateria.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al editar ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formMateria.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
