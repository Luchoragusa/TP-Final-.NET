using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities.Entidades;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop.Alum_Inscrip
{
    public partial class Alum_Inscrip : Form
    {
        public Alum_Inscrip()
        {
            InitializeComponent();
            this.dgvAlum_Incrip.AutoGenerateColumns = false;
            this.dgvAlum_Incrip.ReadOnly = true;
        }

        public void Listar()
        {
            Alumno_InscripcionLogic mat = new Alumno_InscripcionLogic();
            try
            {
                this.dgvAlum_Incrip.DataSource = mat.GetAll();
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            Alum_InscripDesktop formMDesktop = new Alum_InscripDesktop(ApplicationForm.ModoForm.Alta);
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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlum_Incrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Alumnos_Inscripciones)this.dgvAlum_Incrip.SelectedRows[0].DataBoundItem).ID;

            Alum_InscripDesktop formAlum_Inscrip = new Alum_InscripDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formAlum_Inscrip.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error al editar ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlum_Incrip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Alumnos_Inscripciones)this.dgvAlum_Incrip.SelectedRows[0].DataBoundItem).ID;

            Alum_InscripDesktop formAlum_Inscrip = new Alum_InscripDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formAlum_Inscrip.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alum_Inscrip_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
