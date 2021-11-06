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
using Business.Entities.Entidades;
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop.DocenteCurso
{
    public partial class DocenteMaterias_Comision : Form
    {
        Usuario docente;
        private int IDDocente;

        public DocenteMaterias_Comision(int id)
        {
            this.IDDocente = id;
        }

        public DocenteMaterias_Comision(Usuario us)
        {
            us.ID = IDDocente;
            InitializeComponent();
            this.dgvDocenteMateriasCom.AutoGenerateColumns = false;
            this.dgvDocenteMateriasCom.ReadOnly = true;
            docente = us;
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            try
            {
                this.dgvDocenteMateriasCom.DataSource = dcl.GetAllComisionesDeLasMateriasDelDocente(docente);
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
            DCDesktop formDCDesktop = new DCDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formDCDesktop.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (this.dgvDocenteMateriasCom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int ID = ((Business.Entities.Entidades.DocenteCurso)this.dgvDocenteMateriasCom.SelectedRows[0].DataBoundItem).ID;

            DCDesktop formDC = new DCDesktop(ID, ApplicationForm.ModoForm.Modificacion);

            try
            {
                formDC.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteMateriasCom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.DocenteCurso)this.dgvDocenteMateriasCom.SelectedRows[0].DataBoundItem).ID;

            DCDesktop formDC = new DCDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formDC.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
