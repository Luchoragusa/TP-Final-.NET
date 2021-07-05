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


namespace UI.Desktop
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ReadOnly = true;
            //this.dgvUsuarios.ColumnAdded = false;
            //this.dgvUsuarios.ColumnRemoved = false;
        }

        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.dgvUsuarios.DataSource = ul.GetAll();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
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
            UsuarioDesktop formUDesktop = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUDesktop.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion); // nosotros deberiamos haber creado el ModoForm en ApplicationForm
            formUsuario.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID = ((Business.Entities.Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Baja);
            formUsuario.ShowDialog();
            this.Listar();
        }
    }
}