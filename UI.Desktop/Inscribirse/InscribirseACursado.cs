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

namespace UI.Desktop
{
    public partial class InscribirseACursado : Form
    {
        Business.Entities.Materia materia = new Business.Entities.Materia();
        Business.Entities.Usuario alumno = new Business.Entities.Usuario();
        public InscribirseACursado(Usuario us)
        {
            InitializeComponent(); 
            this.dgvInscribirse.AutoGenerateColumns = true;
            this.dgvInscribirse.ReadOnly = true;
            alumno = us;
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            try
            {
                this.dgvInscribirse.DataSource = ml.GetAll();
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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void InscribirseACursado_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dgvInscribirse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // int ID = ((Business.Entities.Materia)this.dgvInscribirse.SelectedRows[0].DataBoundItem).ID;

            materia = (Business.Entities.Materia)this.dgvInscribirse.SelectedRows[0].DataBoundItem;

            UI.Desktop.Inscribirse.ComisionesInscribirse comisiones_insc = new UI.Desktop.Inscribirse.ComisionesInscribirse(materia, alumno);

            try
            {
                comisiones_insc.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error detected: ", "Ha habido un error interno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
