
namespace UI.Desktop
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Usuario = new System.Windows.Forms.Button();
            this.btnComision = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnAlum_Inscrip = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnRegistrarNota = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(167, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(96, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Usuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnComision, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPlan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMateria, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidad, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCurso, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDC, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAlum_Inscrip, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnPersona, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrarNota, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 297);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Usuario
            // 
            this.btn_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Usuario.Location = new System.Drawing.Point(42, 3);
            this.btn_Usuario.Name = "btn_Usuario";
            this.btn_Usuario.Size = new System.Drawing.Size(82, 23);
            this.btn_Usuario.TabIndex = 0;
            this.btn_Usuario.Text = "Usuario";
            this.btn_Usuario.UseVisualStyleBackColor = true;
            this.btn_Usuario.Click += new System.EventHandler(this.btn_Usuario_Click);
            // 
            // btnComision
            // 
            this.btnComision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComision.Location = new System.Drawing.Point(42, 32);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(82, 23);
            this.btnComision.TabIndex = 1;
            this.btnComision.Text = "Comision";
            this.btnComision.UseVisualStyleBackColor = true;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlan.Location = new System.Drawing.Point(42, 61);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(82, 23);
            this.btnPlan.TabIndex = 2;
            this.btnPlan.Text = "Plan";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMateria.Location = new System.Drawing.Point(42, 90);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(82, 23);
            this.btnMateria.TabIndex = 3;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEspecialidad.Location = new System.Drawing.Point(41, 119);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(84, 23);
            this.btnEspecialidad.TabIndex = 4;
            this.btnEspecialidad.Text = "Especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCurso.Location = new System.Drawing.Point(41, 148);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(85, 23);
            this.btnCurso.TabIndex = 5;
            this.btnCurso.Text = "Curso";
            this.btnCurso.UseVisualStyleBackColor = true;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnDC
            // 
            this.btnDC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDC.Location = new System.Drawing.Point(39, 177);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(88, 23);
            this.btnDC.TabIndex = 6;
            this.btnDC.Text = "DocenteCurso";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // btnAlum_Inscrip
            // 
            this.btnAlum_Inscrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlum_Inscrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAlum_Inscrip.Location = new System.Drawing.Point(40, 206);
            this.btnAlum_Inscrip.Name = "btnAlum_Inscrip";
            this.btnAlum_Inscrip.Size = new System.Drawing.Size(86, 25);
            this.btnAlum_Inscrip.TabIndex = 7;
            this.btnAlum_Inscrip.Text = "Alum_Inscrip";
            this.btnAlum_Inscrip.UseVisualStyleBackColor = false;
            this.btnAlum_Inscrip.Click += new System.EventHandler(this.Alum_Inscrip_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersona.Location = new System.Drawing.Point(41, 237);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(84, 22);
            this.btnPersona.TabIndex = 8;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarNota.Location = new System.Drawing.Point(42, 265);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(82, 29);
            this.btnRegistrarNota.TabIndex = 9;
            this.btnRegistrarNota.Text = "RegistrarNota";
            this.btnRegistrarNota.UseVisualStyleBackColor = true;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(167, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Academia";
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Usuario;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Button btnComision;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnAlum_Inscrip;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnRegistrarNota;
    }
}