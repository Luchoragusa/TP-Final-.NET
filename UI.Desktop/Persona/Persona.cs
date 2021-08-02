﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Logic;
using Business.Logic.EntidadesLogic;
using Business.Entities;
using Business.Entities.Entidades;


namespace UI.Desktop.Persona
{
    public partial class Persona : UI.Desktop.ApplicationForm
    {
        public Persona()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
            this.dgvPersonas.ReadOnly = true;
        }
        public void Listar()
        {/*
            PersonaLogic pl = new PersonaLogic();
            try
            {
                this.dgvPersonas.DataSource = pl.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error: ", "Ha habido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
        private void Personas_Load(object sender, EventArgs e)
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

        private void tsbEliminar_Click(object sender, EventArgs e)
        {/*

            if (this.dgvPersonas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Acción invalida", "Seleccione una fila.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;

            PersonaDescktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Baja);
            try
            {
                formPersona.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error: ", "Ha habido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {/*
            PersonaDesktop formPDesktop = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            try
            {
                formPDesktop.ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error: ", "Ha habido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Accion Invalida", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = ((Business.Entities.Entidades.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;

            UsuarioDesktop formUsuario = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            try
            {
                formUsuario.ShowDialog();
                this.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error: ", "Ha habido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}