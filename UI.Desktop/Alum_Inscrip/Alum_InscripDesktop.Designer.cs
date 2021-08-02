
namespace UI.Desktop.Alum_Inscrip
{
    partial class Alum_InscripDesktop
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.txtIDAlumno = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.62645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.37355F));
            this.tableLayoutPanel1.Controls.Add(this.lblNota, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCondicion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNota, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCondicion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCurso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIDAlumno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInscripcion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDAlumno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 333);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(3, 263);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 14;
            this.lblNota.Text = "Nota";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCondicion.Location = new System.Drawing.Point(124, 200);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(256, 20);
            this.txtCondicion.TabIndex = 3;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNota.Location = new System.Drawing.Point(124, 260);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(256, 20);
            this.txtNota.TabIndex = 4;
            // 
            // btnModo
            // 
            this.btnModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModo.Location = new System.Drawing.Point(43, 305);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 5;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Location = new System.Drawing.Point(319, 305);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCondicion
            // 
            this.lblCondicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(3, 203);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 13;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(3, 143);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(65, 13);
            this.lblCurso.TabIndex = 11;
            this.lblCurso.Text = "ID del Curso";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCurso.Location = new System.Drawing.Point(124, 140);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(256, 20);
            this.txtIDCurso.TabIndex = 2;
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(3, 83);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(73, 13);
            this.lblIDAlumno.TabIndex = 10;
            this.lblIDAlumno.Text = "ID del Alumno";
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Location = new System.Drawing.Point(3, 23);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(87, 13);
            this.lblInscripcion.TabIndex = 12;
            this.lblInscripcion.Text = "ID de Inscripcion";
            // 
            // txtIDAlumno
            // 
            this.txtIDAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDAlumno.Location = new System.Drawing.Point(124, 80);
            this.txtIDAlumno.Name = "txtIDAlumno";
            this.txtIDAlumno.Size = new System.Drawing.Size(256, 20);
            this.txtIDAlumno.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(124, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(256, 20);
            this.txtID.TabIndex = 1;
            // 
            // Alum_InscripDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Alum_InscripDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.TextBox txtIDAlumno;
    }
}
