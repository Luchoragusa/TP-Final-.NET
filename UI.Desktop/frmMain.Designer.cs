﻿
namespace UI.Desktop
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnAdminReporteCom = new System.Windows.Forms.Button();
            this.btnAdminReporteAlu = new System.Windows.Forms.Button();
            this.btnAdminPersona = new System.Windows.Forms.Button();
            this.btnAdminAlum_Insc = new System.Windows.Forms.Button();
            this.btnAdminDocenteCurso = new System.Windows.Forms.Button();
            this.btnAdminCurso = new System.Windows.Forms.Button();
            this.btnAdminEspecialidad = new System.Windows.Forms.Button();
            this.btnAdminMateria = new System.Windows.Forms.Button();
            this.btnAdminPlan = new System.Windows.Forms.Button();
            this.btnAdminComision = new System.Windows.Forms.Button();
            this.btnAdminUsuario = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelDocSubMenu = new System.Windows.Forms.Panel();
            this.btnInscripcionCurso = new System.Windows.Forms.Button();
            this.btnRegistroNotas = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.panelAluSubMenu = new System.Windows.Forms.Panel();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.btnAluMateria = new System.Windows.Forms.Button();
            this.btnAluComision = new System.Windows.Forms.Button();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.btnAlu = new System.Windows.Forms.Button();
            this.panelImg = new System.Windows.Forms.Panel();
            this.pboxAcademia = new System.Windows.Forms.PictureBox();
            this.panelCont = new System.Windows.Forms.Panel();
            this.pboxUTN = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
            this.panelDocSubMenu.SuspendLayout();
            this.panelAluSubMenu.SuspendLayout();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAcademia)).BeginInit();
            this.panelCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMain.Controls.Add(this.panelAdminSubMenu);
            this.panelMain.Controls.Add(this.btnAdmin);
            this.panelMain.Controls.Add(this.panelDocSubMenu);
            this.panelMain.Controls.Add(this.btnDoc);
            this.panelMain.Controls.Add(this.panelAluSubMenu);
            this.panelMain.Controls.Add(this.btnAlu);
            this.panelMain.Controls.Add(this.panelImg);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(10, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(259, 626);
            this.panelMain.TabIndex = 0;
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAdminSubMenu.Controls.Add(this.btnAdminReporteCom);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminReporteAlu);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminPersona);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminAlum_Insc);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminDocenteCurso);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminCurso);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminEspecialidad);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminMateria);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminPlan);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminComision);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminUsuario);
            this.panelAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminSubMenu.Location = new System.Drawing.Point(0, 452);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(242, 443);
            this.panelAdminSubMenu.TabIndex = 6;
            // 
            // btnAdminReporteCom
            // 
            this.btnAdminReporteCom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminReporteCom.FlatAppearance.BorderSize = 0;
            this.btnAdminReporteCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReporteCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReporteCom.Location = new System.Drawing.Point(0, 400);
            this.btnAdminReporteCom.Name = "btnAdminReporteCom";
            this.btnAdminReporteCom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminReporteCom.Size = new System.Drawing.Size(242, 40);
            this.btnAdminReporteCom.TabIndex = 12;
            this.btnAdminReporteCom.Text = "Reporte Cursos";
            this.btnAdminReporteCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReporteCom.UseVisualStyleBackColor = true;
            this.btnAdminReporteCom.Click += new System.EventHandler(this.btnAdminReporteCom_Click);
            // 
            // btnAdminReporteAlu
            // 
            this.btnAdminReporteAlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminReporteAlu.FlatAppearance.BorderSize = 0;
            this.btnAdminReporteAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReporteAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReporteAlu.Location = new System.Drawing.Point(0, 360);
            this.btnAdminReporteAlu.Name = "btnAdminReporteAlu";
            this.btnAdminReporteAlu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminReporteAlu.Size = new System.Drawing.Size(242, 40);
            this.btnAdminReporteAlu.TabIndex = 11;
            this.btnAdminReporteAlu.Text = "Reporte de Personas";
            this.btnAdminReporteAlu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReporteAlu.UseVisualStyleBackColor = true;
            this.btnAdminReporteAlu.Click += new System.EventHandler(this.btnAdminReportePer_Click);
            // 
            // btnAdminPersona
            // 
            this.btnAdminPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPersona.FlatAppearance.BorderSize = 0;
            this.btnAdminPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPersona.Location = new System.Drawing.Point(0, 320);
            this.btnAdminPersona.Name = "btnAdminPersona";
            this.btnAdminPersona.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminPersona.Size = new System.Drawing.Size(242, 40);
            this.btnAdminPersona.TabIndex = 9;
            this.btnAdminPersona.Text = "Persona";
            this.btnAdminPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPersona.UseVisualStyleBackColor = true;
            this.btnAdminPersona.Click += new System.EventHandler(this.btnAdminPersona_Click);
            // 
            // btnAdminAlum_Insc
            // 
            this.btnAdminAlum_Insc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminAlum_Insc.FlatAppearance.BorderSize = 0;
            this.btnAdminAlum_Insc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAlum_Insc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAlum_Insc.Location = new System.Drawing.Point(0, 280);
            this.btnAdminAlum_Insc.Name = "btnAdminAlum_Insc";
            this.btnAdminAlum_Insc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminAlum_Insc.Size = new System.Drawing.Size(242, 40);
            this.btnAdminAlum_Insc.TabIndex = 8;
            this.btnAdminAlum_Insc.Text = "Alumno Inscripcion";
            this.btnAdminAlum_Insc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminAlum_Insc.UseVisualStyleBackColor = true;
            this.btnAdminAlum_Insc.Click += new System.EventHandler(this.btnAdminAlum_Insc_Click);
            // 
            // btnAdminDocenteCurso
            // 
            this.btnAdminDocenteCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminDocenteCurso.FlatAppearance.BorderSize = 0;
            this.btnAdminDocenteCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDocenteCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDocenteCurso.Location = new System.Drawing.Point(0, 240);
            this.btnAdminDocenteCurso.Name = "btnAdminDocenteCurso";
            this.btnAdminDocenteCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminDocenteCurso.Size = new System.Drawing.Size(242, 40);
            this.btnAdminDocenteCurso.TabIndex = 7;
            this.btnAdminDocenteCurso.Text = "Docente Curso";
            this.btnAdminDocenteCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDocenteCurso.UseVisualStyleBackColor = true;
            this.btnAdminDocenteCurso.Click += new System.EventHandler(this.btnAdminDocenteCurso_Click);
            // 
            // btnAdminCurso
            // 
            this.btnAdminCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminCurso.FlatAppearance.BorderSize = 0;
            this.btnAdminCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCurso.Location = new System.Drawing.Point(0, 200);
            this.btnAdminCurso.Name = "btnAdminCurso";
            this.btnAdminCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminCurso.Size = new System.Drawing.Size(242, 40);
            this.btnAdminCurso.TabIndex = 6;
            this.btnAdminCurso.Text = "Curso";
            this.btnAdminCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminCurso.UseVisualStyleBackColor = true;
            this.btnAdminCurso.Click += new System.EventHandler(this.btnAdminCurso_Click);
            // 
            // btnAdminEspecialidad
            // 
            this.btnAdminEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminEspecialidad.FlatAppearance.BorderSize = 0;
            this.btnAdminEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEspecialidad.Location = new System.Drawing.Point(0, 160);
            this.btnAdminEspecialidad.Name = "btnAdminEspecialidad";
            this.btnAdminEspecialidad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminEspecialidad.Size = new System.Drawing.Size(242, 40);
            this.btnAdminEspecialidad.TabIndex = 5;
            this.btnAdminEspecialidad.Text = "Especialidad";
            this.btnAdminEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEspecialidad.UseVisualStyleBackColor = true;
            this.btnAdminEspecialidad.Click += new System.EventHandler(this.btnAdminEspecialidad_Click);
            // 
            // btnAdminMateria
            // 
            this.btnAdminMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminMateria.FlatAppearance.BorderSize = 0;
            this.btnAdminMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMateria.Location = new System.Drawing.Point(0, 120);
            this.btnAdminMateria.Name = "btnAdminMateria";
            this.btnAdminMateria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminMateria.Size = new System.Drawing.Size(242, 40);
            this.btnAdminMateria.TabIndex = 4;
            this.btnAdminMateria.Text = "Materia";
            this.btnAdminMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMateria.UseVisualStyleBackColor = true;
            this.btnAdminMateria.Click += new System.EventHandler(this.btnAdminMateria_Click);
            // 
            // btnAdminPlan
            // 
            this.btnAdminPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPlan.FlatAppearance.BorderSize = 0;
            this.btnAdminPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPlan.Location = new System.Drawing.Point(0, 80);
            this.btnAdminPlan.Name = "btnAdminPlan";
            this.btnAdminPlan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminPlan.Size = new System.Drawing.Size(242, 40);
            this.btnAdminPlan.TabIndex = 3;
            this.btnAdminPlan.Text = "Plan";
            this.btnAdminPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPlan.UseVisualStyleBackColor = true;
            this.btnAdminPlan.Click += new System.EventHandler(this.btnAdminPlan_Click);
            // 
            // btnAdminComision
            // 
            this.btnAdminComision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminComision.FlatAppearance.BorderSize = 0;
            this.btnAdminComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminComision.Location = new System.Drawing.Point(0, 40);
            this.btnAdminComision.Name = "btnAdminComision";
            this.btnAdminComision.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminComision.Size = new System.Drawing.Size(242, 40);
            this.btnAdminComision.TabIndex = 2;
            this.btnAdminComision.Text = "Comision";
            this.btnAdminComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminComision.UseVisualStyleBackColor = true;
            this.btnAdminComision.Click += new System.EventHandler(this.btnAdminComision_Click);
            // 
            // btnAdminUsuario
            // 
            this.btnAdminUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdminUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUsuario.Name = "btnAdminUsuario";
            this.btnAdminUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminUsuario.Size = new System.Drawing.Size(242, 40);
            this.btnAdminUsuario.TabIndex = 1;
            this.btnAdminUsuario.Text = "Usuario";
            this.btnAdminUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuario.UseVisualStyleBackColor = true;
            this.btnAdminUsuario.Click += new System.EventHandler(this.btnAdminUsuario_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.Location = new System.Drawing.Point(0, 412);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(242, 40);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelDocSubMenu
            // 
            this.panelDocSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDocSubMenu.Controls.Add(this.btnInscripcionCurso);
            this.panelDocSubMenu.Controls.Add(this.btnRegistroNotas);
            this.panelDocSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDocSubMenu.Location = new System.Drawing.Point(0, 333);
            this.panelDocSubMenu.Name = "panelDocSubMenu";
            this.panelDocSubMenu.Size = new System.Drawing.Size(242, 79);
            this.panelDocSubMenu.TabIndex = 4;
            // 
            // btnInscripcionCurso
            // 
            this.btnInscripcionCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripcionCurso.FlatAppearance.BorderSize = 0;
            this.btnInscripcionCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcionCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripcionCurso.Location = new System.Drawing.Point(0, 40);
            this.btnInscripcionCurso.Name = "btnInscripcionCurso";
            this.btnInscripcionCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInscripcionCurso.Size = new System.Drawing.Size(242, 40);
            this.btnInscripcionCurso.TabIndex = 2;
            this.btnInscripcionCurso.Text = "Cursos del docente";
            this.btnInscripcionCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcionCurso.UseVisualStyleBackColor = true;
            this.btnInscripcionCurso.Click += new System.EventHandler(this.btnInscripcionCurso_Click);
            // 
            // btnRegistroNotas
            // 
            this.btnRegistroNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroNotas.FlatAppearance.BorderSize = 0;
            this.btnRegistroNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNotas.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroNotas.Name = "btnRegistroNotas";
            this.btnRegistroNotas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegistroNotas.Size = new System.Drawing.Size(242, 40);
            this.btnRegistroNotas.TabIndex = 1;
            this.btnRegistroNotas.Text = "Registrar Notas";
            this.btnRegistroNotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroNotas.UseVisualStyleBackColor = true;
            this.btnRegistroNotas.Click += new System.EventHandler(this.btnRegistroNotas_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoc.Location = new System.Drawing.Point(0, 293);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoc.Size = new System.Drawing.Size(242, 40);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Docente";
            this.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // panelAluSubMenu
            // 
            this.panelAluSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAluSubMenu.Controls.Add(this.btnInscribirse);
            this.panelAluSubMenu.Controls.Add(this.btnAluMateria);
            this.panelAluSubMenu.Controls.Add(this.btnAluComision);
            this.panelAluSubMenu.Controls.Add(this.btnInscripciones);
            this.panelAluSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAluSubMenu.Location = new System.Drawing.Point(0, 130);
            this.panelAluSubMenu.Name = "panelAluSubMenu";
            this.panelAluSubMenu.Size = new System.Drawing.Size(242, 163);
            this.panelAluSubMenu.TabIndex = 2;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscribirse.FlatAppearance.BorderSize = 0;
            this.btnInscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirse.Location = new System.Drawing.Point(0, 120);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInscribirse.Size = new System.Drawing.Size(242, 44);
            this.btnInscribirse.TabIndex = 4;
            this.btnInscribirse.Text = "Inscribirse a Cursado";
            this.btnInscribirse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // btnAluMateria
            // 
            this.btnAluMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluMateria.FlatAppearance.BorderSize = 0;
            this.btnAluMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluMateria.Location = new System.Drawing.Point(0, 80);
            this.btnAluMateria.Name = "btnAluMateria";
            this.btnAluMateria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluMateria.Size = new System.Drawing.Size(242, 40);
            this.btnAluMateria.TabIndex = 3;
            this.btnAluMateria.Text = "Materia";
            this.btnAluMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluMateria.UseVisualStyleBackColor = true;
            this.btnAluMateria.Click += new System.EventHandler(this.btnAluMateria_Click);
            // 
            // btnAluComision
            // 
            this.btnAluComision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluComision.FlatAppearance.BorderSize = 0;
            this.btnAluComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluComision.Location = new System.Drawing.Point(0, 40);
            this.btnAluComision.Name = "btnAluComision";
            this.btnAluComision.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluComision.Size = new System.Drawing.Size(242, 40);
            this.btnAluComision.TabIndex = 2;
            this.btnAluComision.Text = "Comision";
            this.btnAluComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluComision.UseVisualStyleBackColor = true;
            this.btnAluComision.Click += new System.EventHandler(this.btnAluComision_Click);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInscripciones.FlatAppearance.BorderSize = 0;
            this.btnInscripciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripciones.Location = new System.Drawing.Point(0, 0);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInscripciones.Size = new System.Drawing.Size(242, 40);
            this.btnInscripciones.TabIndex = 1;
            this.btnInscripciones.Text = "Inscripciones";
            this.btnInscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnAlu
            // 
            this.btnAlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlu.FlatAppearance.BorderSize = 0;
            this.btnAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlu.Location = new System.Drawing.Point(0, 88);
            this.btnAlu.Name = "btnAlu";
            this.btnAlu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlu.Size = new System.Drawing.Size(242, 42);
            this.btnAlu.TabIndex = 1;
            this.btnAlu.Text = "Alumno";
            this.btnAlu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlu.UseVisualStyleBackColor = true;
            this.btnAlu.Click += new System.EventHandler(this.btnAlu_Click);
            // 
            // panelImg
            // 
            this.panelImg.BackColor = System.Drawing.Color.Lavender;
            this.panelImg.Controls.Add(this.pboxAcademia);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(242, 88);
            this.panelImg.TabIndex = 0;
            // 
            // pboxAcademia
            // 
            this.pboxAcademia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxAcademia.Image = ((System.Drawing.Image)(resources.GetObject("pboxAcademia.Image")));
            this.pboxAcademia.Location = new System.Drawing.Point(14, 17);
            this.pboxAcademia.Name = "pboxAcademia";
            this.pboxAcademia.Size = new System.Drawing.Size(211, 55);
            this.pboxAcademia.TabIndex = 0;
            this.pboxAcademia.TabStop = false;
            // 
            // panelCont
            // 
            this.panelCont.Controls.Add(this.pboxUTN);
            this.panelCont.Location = new System.Drawing.Point(275, 0);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(847, 626);
            this.panelCont.TabIndex = 1;
            // 
            // pboxUTN
            // 
            this.pboxUTN.Image = ((System.Drawing.Image)(resources.GetObject("pboxUTN.Image")));
            this.pboxUTN.Location = new System.Drawing.Point(139, 210);
            this.pboxUTN.Name = "pboxUTN";
            this.pboxUTN.Size = new System.Drawing.Size(556, 204);
            this.pboxUTN.TabIndex = 0;
            this.pboxUTN.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 626);
            this.Controls.Add(this.panelCont);
            this.Controls.Add(this.panelMain);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Menu";
            this.panelMain.ResumeLayout(false);
            this.panelAdminSubMenu.ResumeLayout(false);
            this.panelDocSubMenu.ResumeLayout(false);
            this.panelAluSubMenu.ResumeLayout(false);
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAcademia)).EndInit();
            this.panelCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxUTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Button btnAdminReporteCom;
        private System.Windows.Forms.Button btnAdminReporteAlu;
        private System.Windows.Forms.Button btnAdminCurso;
        private System.Windows.Forms.Button btnAdminPersona;
        private System.Windows.Forms.Button btnAdminAlum_Insc;
        private System.Windows.Forms.Button btnAdminDocenteCurso;
        private System.Windows.Forms.Button btnAdminEspecialidad;
        private System.Windows.Forms.Button btnAdminMateria;
        private System.Windows.Forms.Button btnAdminPlan;
        private System.Windows.Forms.Button btnAdminComision;
        private System.Windows.Forms.Button btnAdminUsuario;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelDocSubMenu;
        private System.Windows.Forms.Button btnInscripcionCurso;
        private System.Windows.Forms.Button btnRegistroNotas;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Panel panelAluSubMenu;
        private System.Windows.Forms.Button btnAluMateria;
        private System.Windows.Forms.Button btnAluComision;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Button btnAlu;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.PictureBox pboxAcademia;
        private System.Windows.Forms.PictureBox pboxUTN;
        private System.Windows.Forms.Button btnInscribirse;
    }
}