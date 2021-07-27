
namespace UI.Desktop
{
    partial class CursosDesktop
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
            this.lblID_Curso = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModo = new System.Windows.Forms.Button();
            this.txtAnioEsp_Cur = new System.Windows.Forms.TextBox();
            this.lblAnioEsp = new System.Windows.Forms.Label();
            this.lblIDCom = new System.Windows.Forms.Label();
            this.txtIDCom = new System.Windows.Forms.TextBox();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.txtIDMat = new System.Windows.Forms.TextBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.4375F));
            this.tableLayoutPanel1.Controls.Add(this.lblID_Curso, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCurso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAnioEsp_Cur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioEsp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIDCom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIDMateria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDMat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCupo, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblID_Curso
            // 
            this.lblID_Curso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID_Curso.AutoSize = true;
            this.lblID_Curso.Location = new System.Drawing.Point(3, 23);
            this.lblID_Curso.Name = "lblID_Curso";
            this.lblID_Curso.Size = new System.Drawing.Size(64, 13);
            this.lblID_Curso.TabIndex = 12;
            this.lblID_Curso.Text = "ID del curso";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCurso.Location = new System.Drawing.Point(215, 20);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.ReadOnly = true;
            this.txtIDCurso.Size = new System.Drawing.Size(256, 20);
            this.txtIDCurso.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(722, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModo
            // 
            this.btnModo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModo.Location = new System.Drawing.Point(3, 424);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 4;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // txtAnioEsp_Cur
            // 
            this.txtAnioEsp_Cur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioEsp_Cur.Location = new System.Drawing.Point(215, 197);
            this.txtAnioEsp_Cur.Name = "txtAnioEsp_Cur";
            this.txtAnioEsp_Cur.Size = new System.Drawing.Size(256, 20);
            this.txtAnioEsp_Cur.TabIndex = 3;
            // 
            // lblAnioEsp
            // 
            this.lblAnioEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioEsp.AutoSize = true;
            this.lblAnioEsp.Location = new System.Drawing.Point(3, 201);
            this.lblAnioEsp.Name = "lblAnioEsp";
            this.lblAnioEsp.Size = new System.Drawing.Size(89, 13);
            this.lblAnioEsp.TabIndex = 10;
            this.lblAnioEsp.Text = "Año Especialidad";
            // 
            // lblIDCom
            // 
            this.lblIDCom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDCom.AutoSize = true;
            this.lblIDCom.Location = new System.Drawing.Point(3, 143);
            this.lblIDCom.Name = "lblIDCom";
            this.lblIDCom.Size = new System.Drawing.Size(63, 13);
            this.lblIDCom.TabIndex = 11;
            this.lblIDCom.Text = "ID Comision";
            // 
            // txtIDCom
            // 
            this.txtIDCom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCom.Location = new System.Drawing.Point(215, 140);
            this.txtIDCom.Name = "txtIDCom";
            this.txtIDCom.Size = new System.Drawing.Size(256, 20);
            this.txtIDCom.TabIndex = 2;
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(3, 83);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(56, 13);
            this.lblIDMateria.TabIndex = 13;
            this.lblIDMateria.Text = "ID Materia";
            // 
            // txtIDMat
            // 
            this.txtIDMat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDMat.Location = new System.Drawing.Point(215, 80);
            this.txtIDMat.Name = "txtIDMat";
            this.txtIDMat.Size = new System.Drawing.Size(256, 20);
            this.txtIDMat.TabIndex = 1;
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(3, 252);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 14;
            this.lblCupo.Text = "Cupo";
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCupo.Location = new System.Drawing.Point(215, 248);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(256, 20);
            this.txtCupo.TabIndex = 15;
            // 
            // CursosDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CursosDesktop";
            this.Text = "Curso";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID_Curso;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.TextBox txtAnioEsp_Cur;
        private System.Windows.Forms.Label lblAnioEsp;
        private System.Windows.Forms.Label lblIDCom;
        private System.Windows.Forms.TextBox txtIDCom;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.TextBox txtIDMat;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtCupo;
    }
}
