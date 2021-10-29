
namespace UI.Desktop
{
    partial class nuevoMaincs
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelImg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlu = new System.Windows.Forms.Button();
            this.panelAluSubMenu = new System.Windows.Forms.Panel();
            this.btnAluAlumnoInscripcion = new System.Windows.Forms.Button();
            this.btnAluComision = new System.Windows.Forms.Button();
            this.btnAluMateria = new System.Windows.Forms.Button();
            this.btnAluPlan = new System.Windows.Forms.Button();
            this.btnAluEspecialidad = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.panelDocSubMenu = new System.Windows.Forms.Panel();
            this.btnDocDocenteCurso = new System.Windows.Forms.Button();
            this.btnDocRegistrarNota = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnAdminUsuario = new System.Windows.Forms.Button();
            this.btnAdminComision = new System.Windows.Forms.Button();
            this.btnAdminPlan = new System.Windows.Forms.Button();
            this.btnAdminMateria = new System.Windows.Forms.Button();
            this.btnAdminEspecialidad = new System.Windows.Forms.Button();
            this.btnAdminDocenteCurso = new System.Windows.Forms.Button();
            this.btnAdminAlum_Insc = new System.Windows.Forms.Button();
            this.btnAdminPersona = new System.Windows.Forms.Button();
            this.btnAdminCurso = new System.Windows.Forms.Button();
            this.btnAdminRegistrarNota = new System.Windows.Forms.Button();
            this.btnAdminReporteAlu = new System.Windows.Forms.Button();
            this.btnAdminReporteCom = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelImg.SuspendLayout();
            this.panelAluSubMenu.SuspendLayout();
            this.panelDocSubMenu.SuspendLayout();
            this.panelAdminSubMenu.SuspendLayout();
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
            this.panelMain.Size = new System.Drawing.Size(224, 964);
            this.panelMain.TabIndex = 0;
            // 
            // panelImg
            // 
            this.panelImg.BackColor = System.Drawing.Color.Lavender;
            this.panelImg.Controls.Add(this.label1);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(207, 94);
            this.panelImg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academia";
            // 
            // btnAlu
            // 
            this.btnAlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlu.FlatAppearance.BorderSize = 0;
            this.btnAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlu.Location = new System.Drawing.Point(0, 94);
            this.btnAlu.Name = "btnAlu";
            this.btnAlu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAlu.Size = new System.Drawing.Size(207, 40);
            this.btnAlu.TabIndex = 1;
            this.btnAlu.Text = "Alumno";
            this.btnAlu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlu.UseVisualStyleBackColor = true;
            this.btnAlu.Click += new System.EventHandler(this.btnAlu_Click);
            // 
            // panelAluSubMenu
            // 
            this.panelAluSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAluSubMenu.Controls.Add(this.btnAluEspecialidad);
            this.panelAluSubMenu.Controls.Add(this.btnAluPlan);
            this.panelAluSubMenu.Controls.Add(this.btnAluMateria);
            this.panelAluSubMenu.Controls.Add(this.btnAluComision);
            this.panelAluSubMenu.Controls.Add(this.btnAluAlumnoInscripcion);
            this.panelAluSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAluSubMenu.Location = new System.Drawing.Point(0, 134);
            this.panelAluSubMenu.Name = "panelAluSubMenu";
            this.panelAluSubMenu.Size = new System.Drawing.Size(207, 196);
            this.panelAluSubMenu.TabIndex = 2;
            // 
            // btnAluAlumnoInscripcion
            // 
            this.btnAluAlumnoInscripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluAlumnoInscripcion.FlatAppearance.BorderSize = 0;
            this.btnAluAlumnoInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluAlumnoInscripcion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluAlumnoInscripcion.Location = new System.Drawing.Point(0, 0);
            this.btnAluAlumnoInscripcion.Name = "btnAluAlumnoInscripcion";
            this.btnAluAlumnoInscripcion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluAlumnoInscripcion.Size = new System.Drawing.Size(207, 40);
            this.btnAluAlumnoInscripcion.TabIndex = 2;
            this.btnAluAlumnoInscripcion.Text = "Alumno Inscripcion";
            this.btnAluAlumnoInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluAlumnoInscripcion.UseVisualStyleBackColor = true;
            // 
            // btnAluComision
            // 
            this.btnAluComision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluComision.FlatAppearance.BorderSize = 0;
            this.btnAluComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluComision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluComision.Location = new System.Drawing.Point(0, 40);
            this.btnAluComision.Name = "btnAluComision";
            this.btnAluComision.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluComision.Size = new System.Drawing.Size(207, 40);
            this.btnAluComision.TabIndex = 3;
            this.btnAluComision.Text = "Comision";
            this.btnAluComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluComision.UseVisualStyleBackColor = true;
            // 
            // btnAluMateria
            // 
            this.btnAluMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluMateria.FlatAppearance.BorderSize = 0;
            this.btnAluMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluMateria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluMateria.Location = new System.Drawing.Point(0, 80);
            this.btnAluMateria.Name = "btnAluMateria";
            this.btnAluMateria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluMateria.Size = new System.Drawing.Size(207, 40);
            this.btnAluMateria.TabIndex = 4;
            this.btnAluMateria.Text = "Materia";
            this.btnAluMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluMateria.UseVisualStyleBackColor = true;
            // 
            // btnAluPlan
            // 
            this.btnAluPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluPlan.FlatAppearance.BorderSize = 0;
            this.btnAluPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluPlan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluPlan.Location = new System.Drawing.Point(0, 120);
            this.btnAluPlan.Name = "btnAluPlan";
            this.btnAluPlan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluPlan.Size = new System.Drawing.Size(207, 40);
            this.btnAluPlan.TabIndex = 5;
            this.btnAluPlan.Text = "Plan";
            this.btnAluPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluPlan.UseVisualStyleBackColor = true;
            // 
            // btnAluEspecialidad
            // 
            this.btnAluEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAluEspecialidad.FlatAppearance.BorderSize = 0;
            this.btnAluEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluEspecialidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluEspecialidad.Location = new System.Drawing.Point(0, 160);
            this.btnAluEspecialidad.Name = "btnAluEspecialidad";
            this.btnAluEspecialidad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAluEspecialidad.Size = new System.Drawing.Size(207, 40);
            this.btnAluEspecialidad.TabIndex = 6;
            this.btnAluEspecialidad.Text = "Especialidad";
            this.btnAluEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnDoc
            // 
            this.btnDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoc.Location = new System.Drawing.Point(0, 330);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoc.Size = new System.Drawing.Size(207, 40);
            this.btnDoc.TabIndex = 3;
            this.btnDoc.Text = "Docente";
            this.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // panelDocSubMenu
            // 
            this.panelDocSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDocSubMenu.Controls.Add(this.btnDocRegistrarNota);
            this.panelDocSubMenu.Controls.Add(this.btnDocDocenteCurso);
            this.panelDocSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDocSubMenu.Location = new System.Drawing.Point(0, 370);
            this.panelDocSubMenu.Name = "panelDocSubMenu";
            this.panelDocSubMenu.Size = new System.Drawing.Size(207, 79);
            this.panelDocSubMenu.TabIndex = 4;
            // 
            // btnDocDocenteCurso
            // 
            this.btnDocDocenteCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocDocenteCurso.FlatAppearance.BorderSize = 0;
            this.btnDocDocenteCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocDocenteCurso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.btnDocDocenteCurso.Name = "btnDocDocenteCurso";
            this.btnDocDocenteCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDocDocenteCurso.Size = new System.Drawing.Size(207, 40);
            this.btnDocDocenteCurso.TabIndex = 3;
            this.btnDocDocenteCurso.Text = "Docente Curso";
            this.btnDocDocenteCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocDocenteCurso.UseVisualStyleBackColor = true;
            // 
            // btnDocRegistrarNota
            // 
            this.btnDocRegistrarNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocRegistrarNota.FlatAppearance.BorderSize = 0;
            this.btnDocRegistrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocRegistrarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocRegistrarNota.Location = new System.Drawing.Point(0, 40);
            this.btnDocRegistrarNota.Name = "btnDocRegistrarNota";
            this.btnDocRegistrarNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDocRegistrarNota.Size = new System.Drawing.Size(207, 40);
            this.btnDocRegistrarNota.TabIndex = 4;
            this.btnDocRegistrarNota.Text = "Registrar Nota\r\n";
            this.btnDocRegistrarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocRegistrarNota.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdmin.Location = new System.Drawing.Point(0, 449);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(207, 40);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelAdminSubMenu
            // 
            this.panelAdminSubMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelAdminSubMenu.Controls.Add(this.btnAdminReporteCom);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminReporteAlu);
            this.panelAdminSubMenu.Controls.Add(this.btnAdminRegistrarNota);
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
            this.panelAdminSubMenu.Location = new System.Drawing.Point(0, 489);
            this.panelAdminSubMenu.Name = "panelAdminSubMenu";
            this.panelAdminSubMenu.Size = new System.Drawing.Size(207, 483);
            this.panelAdminSubMenu.TabIndex = 6;
            // 
            // btnAdminUsuario
            // 
            this.btnAdminUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdminUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUsuario.Name = "btnAdminUsuario";
            this.btnAdminUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminUsuario.Size = new System.Drawing.Size(207, 40);
            this.btnAdminUsuario.TabIndex = 4;
            this.btnAdminUsuario.Text = "Usuario";
            this.btnAdminUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAdminComision
            // 
            this.btnAdminComision.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminComision.FlatAppearance.BorderSize = 0;
            this.btnAdminComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminComision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminComision.Location = new System.Drawing.Point(0, 40);
            this.btnAdminComision.Name = "btnAdminComision";
            this.btnAdminComision.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminComision.Size = new System.Drawing.Size(207, 40);
            this.btnAdminComision.TabIndex = 5;
            this.btnAdminComision.Text = "Comision";
            this.btnAdminComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminComision.UseVisualStyleBackColor = true;
            // 
            // btnAdminPlan
            // 
            this.btnAdminPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPlan.FlatAppearance.BorderSize = 0;
            this.btnAdminPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPlan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPlan.Location = new System.Drawing.Point(0, 80);
            this.btnAdminPlan.Name = "btnAdminPlan";
            this.btnAdminPlan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminPlan.Size = new System.Drawing.Size(207, 40);
            this.btnAdminPlan.TabIndex = 6;
            this.btnAdminPlan.Text = "Plan";
            this.btnAdminPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPlan.UseVisualStyleBackColor = true;
            // 
            // btnAdminMateria
            // 
            this.btnAdminMateria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminMateria.FlatAppearance.BorderSize = 0;
            this.btnAdminMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMateria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMateria.Location = new System.Drawing.Point(0, 120);
            this.btnAdminMateria.Name = "btnAdminMateria";
            this.btnAdminMateria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminMateria.Size = new System.Drawing.Size(207, 40);
            this.btnAdminMateria.TabIndex = 7;
            this.btnAdminMateria.Text = "Materia";
            this.btnAdminMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMateria.UseVisualStyleBackColor = true;
            // 
            // btnAdminEspecialidad
            // 
            this.btnAdminEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminEspecialidad.FlatAppearance.BorderSize = 0;
            this.btnAdminEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEspecialidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEspecialidad.Location = new System.Drawing.Point(0, 160);
            this.btnAdminEspecialidad.Name = "btnAdminEspecialidad";
            this.btnAdminEspecialidad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminEspecialidad.Size = new System.Drawing.Size(207, 40);
            this.btnAdminEspecialidad.TabIndex = 8;
            this.btnAdminEspecialidad.Text = "Especialidad";
            this.btnAdminEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnAdminDocenteCurso
            // 
            this.btnAdminDocenteCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminDocenteCurso.FlatAppearance.BorderSize = 0;
            this.btnAdminDocenteCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDocenteCurso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDocenteCurso.Location = new System.Drawing.Point(0, 240);
            this.btnAdminDocenteCurso.Name = "btnAdminDocenteCurso";
            this.btnAdminDocenteCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminDocenteCurso.Size = new System.Drawing.Size(207, 40);
            this.btnAdminDocenteCurso.TabIndex = 9;
            this.btnAdminDocenteCurso.Text = "Docente Curso";
            this.btnAdminDocenteCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminDocenteCurso.UseVisualStyleBackColor = true;
            // 
            // btnAdminAlum_Insc
            // 
            this.btnAdminAlum_Insc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminAlum_Insc.FlatAppearance.BorderSize = 0;
            this.btnAdminAlum_Insc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAlum_Insc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAlum_Insc.Location = new System.Drawing.Point(0, 280);
            this.btnAdminAlum_Insc.Name = "btnAdminAlum_Insc";
            this.btnAdminAlum_Insc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminAlum_Insc.Size = new System.Drawing.Size(207, 40);
            this.btnAdminAlum_Insc.TabIndex = 10;
            this.btnAdminAlum_Insc.Text = "Alumno Inscripcion";
            this.btnAdminAlum_Insc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminAlum_Insc.UseVisualStyleBackColor = true;
            // 
            // btnAdminPersona
            // 
            this.btnAdminPersona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPersona.FlatAppearance.BorderSize = 0;
            this.btnAdminPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPersona.Location = new System.Drawing.Point(0, 320);
            this.btnAdminPersona.Name = "btnAdminPersona";
            this.btnAdminPersona.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminPersona.Size = new System.Drawing.Size(207, 40);
            this.btnAdminPersona.TabIndex = 11;
            this.btnAdminPersona.Text = "Persona";
            this.btnAdminPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPersona.UseVisualStyleBackColor = true;
            // 
            // btnAdminCurso
            // 
            this.btnAdminCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminCurso.FlatAppearance.BorderSize = 0;
            this.btnAdminCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCurso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCurso.Location = new System.Drawing.Point(0, 200);
            this.btnAdminCurso.Name = "btnAdminCurso";
            this.btnAdminCurso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminCurso.Size = new System.Drawing.Size(207, 40);
            this.btnAdminCurso.TabIndex = 12;
            this.btnAdminCurso.Text = "Curso";
            this.btnAdminCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminCurso.UseVisualStyleBackColor = true;
            // 
            // btnAdminRegistrarNota
            // 
            this.btnAdminRegistrarNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminRegistrarNota.FlatAppearance.BorderSize = 0;
            this.btnAdminRegistrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminRegistrarNota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminRegistrarNota.Location = new System.Drawing.Point(0, 360);
            this.btnAdminRegistrarNota.Name = "btnAdminRegistrarNota";
            this.btnAdminRegistrarNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminRegistrarNota.Size = new System.Drawing.Size(207, 40);
            this.btnAdminRegistrarNota.TabIndex = 13;
            this.btnAdminRegistrarNota.Text = "Registrar Nota";
            this.btnAdminRegistrarNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminRegistrarNota.UseVisualStyleBackColor = true;
            // 
            // btnAdminReporteAlu
            // 
            this.btnAdminReporteAlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminReporteAlu.FlatAppearance.BorderSize = 0;
            this.btnAdminReporteAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReporteAlu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReporteAlu.Location = new System.Drawing.Point(0, 400);
            this.btnAdminReporteAlu.Name = "btnAdminReporteAlu";
            this.btnAdminReporteAlu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminReporteAlu.Size = new System.Drawing.Size(207, 40);
            this.btnAdminReporteAlu.TabIndex = 14;
            this.btnAdminReporteAlu.Text = "Reporte Alumno";
            this.btnAdminReporteAlu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReporteAlu.UseVisualStyleBackColor = true;
            // 
            // btnAdminReporteCom
            // 
            this.btnAdminReporteCom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminReporteCom.FlatAppearance.BorderSize = 0;
            this.btnAdminReporteCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReporteCom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminReporteCom.Location = new System.Drawing.Point(0, 440);
            this.btnAdminReporteCom.Name = "btnAdminReporteCom";
            this.btnAdminReporteCom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminReporteCom.Size = new System.Drawing.Size(207, 40);
            this.btnAdminReporteCom.TabIndex = 15;
            this.btnAdminReporteCom.Text = "Reporte Comision";
            this.btnAdminReporteCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminReporteCom.UseVisualStyleBackColor = true;
            // 
            // nuevoMaincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 964);
            this.Controls.Add(this.panelMain);
            this.Name = "nuevoMaincs";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "nuevoMaincs";
            this.panelMain.ResumeLayout(false);
            this.panelImg.ResumeLayout(false);
            this.panelImg.PerformLayout();
            this.panelAluSubMenu.ResumeLayout(false);
            this.panelDocSubMenu.ResumeLayout(false);
            this.panelAdminSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdminSubMenu;
        private System.Windows.Forms.Button btnAdminReporteCom;
        private System.Windows.Forms.Button btnAdminReporteAlu;
        private System.Windows.Forms.Button btnAdminRegistrarNota;
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
        private System.Windows.Forms.Button btnDocRegistrarNota;
        private System.Windows.Forms.Button btnDocDocenteCurso;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Panel panelAluSubMenu;
        private System.Windows.Forms.Button btnAluEspecialidad;
        private System.Windows.Forms.Button btnAluPlan;
        private System.Windows.Forms.Button btnAluMateria;
        private System.Windows.Forms.Button btnAluComision;
        private System.Windows.Forms.Button btnAluAlumnoInscripcion;
        private System.Windows.Forms.Button btnAlu;
    }
}