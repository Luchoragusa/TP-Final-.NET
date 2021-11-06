
namespace UI.Desktop
{
    partial class DICDesktop
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
            this.txtIDDictado = new System.Windows.Forms.TextBox();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.txtIDDocente = new System.Windows.Forms.TextBox();
            this.lblIDDictado = new System.Windows.Forms.Label();
            this.lblDCurso = new System.Windows.Forms.Label();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel1.Controls.Add(this.txtIDDictado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCurso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDDocente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIDDictado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDCurso, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDDocente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCargo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 286);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtIDDictado
            // 
            this.txtIDDictado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDDictado.Location = new System.Drawing.Point(106, 20);
            this.txtIDDictado.Name = "txtIDDictado";
            this.txtIDDictado.ReadOnly = true;
            this.txtIDDictado.Size = new System.Drawing.Size(229, 20);
            this.txtIDDictado.TabIndex = 0;
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCurso.Location = new System.Drawing.Point(106, 80);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(229, 20);
            this.txtIDCurso.TabIndex = 1;
            // 
            // txtIDDocente
            // 
            this.txtIDDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDDocente.Location = new System.Drawing.Point(106, 140);
            this.txtIDDocente.Name = "txtIDDocente";
            this.txtIDDocente.Size = new System.Drawing.Size(229, 20);
            this.txtIDDocente.TabIndex = 2;
            // 
            // lblIDDictado
            // 
            this.lblIDDictado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDDictado.AutoSize = true;
            this.lblIDDictado.Location = new System.Drawing.Point(3, 23);
            this.lblIDDictado.Name = "lblIDDictado";
            this.lblIDDictado.Size = new System.Drawing.Size(73, 13);
            this.lblIDDictado.TabIndex = 10;
            this.lblIDDictado.Text = "ID del dictado";
            // 
            // lblDCurso
            // 
            this.lblDCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDCurso.AutoSize = true;
            this.lblDCurso.Location = new System.Drawing.Point(3, 83);
            this.lblDCurso.Name = "lblDCurso";
            this.lblDCurso.Size = new System.Drawing.Size(64, 13);
            this.lblDCurso.TabIndex = 11;
            this.lblDCurso.Text = "ID del curso";
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDDocente.AutoSize = true;
            this.lblIDDocente.Location = new System.Drawing.Point(3, 143);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(77, 13);
            this.lblIDDocente.TabIndex = 12;
            this.lblIDDocente.Text = "ID del docente";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(3, 203);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCargo.Location = new System.Drawing.Point(106, 200);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(229, 20);
            this.txtCargo.TabIndex = 14;
            // 
            // btnModo
            // 
            this.btnModo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModo.Location = new System.Drawing.Point(15, 251);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(73, 23);
            this.btnModo.TabIndex = 7;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(106, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DICDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(338, 286);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DICDesktop";
            this.Text = "Insrcipcion a curso";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtIDDictado;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.TextBox txtIDDocente;
        private System.Windows.Forms.Label lblIDDictado;
        private System.Windows.Forms.Label lblDCurso;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
    }
}
