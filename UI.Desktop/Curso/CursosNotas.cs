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
using Business.Logic;
using Business.Logic.EntidadesLogic;

namespace UI.Desktop.Curso
{
    public partial class CursosNotas : Form
    {
        Usuario docente;
        public CursosNotas(Usuario us)
        {
            InitializeComponent();
            docente = us;
        }


        public void Listar()
        {
            Business.Logic.EntidadesLogic.CursoLogic cl = new Business.Logic.EntidadesLogic.CursoLogic();
            try
            {
                this.dgvCursos.DataSource = cl.GetAllDocente(docente);
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
             
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Comision)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;

            ComisionesDesktop formCDesktop = new ComisionesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
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
              
        private void CursosNotas_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
