
namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblHSTotales = new System.Windows.Forms.Label();
            this.txtHSSemanales = new System.Windows.Forms.TextBox();
            this.txtHSTotales = new System.Windows.Forms.TextBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblHSSemanales = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.62645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.37355F));
            this.tableLayoutPanel1.Controls.Add(this.lblHSTotales, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHSSemanales, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHSTotales, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblHSSemanales, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIDMateria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDPlan, 1, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 338);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(131, 80);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(256, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc.Location = new System.Drawing.Point(131, 140);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(256, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDPlan.Location = new System.Drawing.Point(131, 20);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(256, 20);
            this.txtIDPlan.TabIndex = 2;
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(3, 83);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(71, 13);
            this.lblIDMateria.TabIndex = 10;
            this.lblIDMateria.Text = "ID de Materia";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 143);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(116, 13);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripcion de Materia";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(3, 23);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(57, 13);
            this.lblPlan.TabIndex = 12;
            this.lblPlan.Text = "ID de Plan";
            // 
            // lblHSTotales
            // 
            this.lblHSTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHSTotales.AutoSize = true;
            this.lblHSTotales.Location = new System.Drawing.Point(3, 263);
            this.lblHSTotales.Name = "lblHSTotales";
            this.lblHSTotales.Size = new System.Drawing.Size(73, 13);
            this.lblHSTotales.TabIndex = 14;
            this.lblHSTotales.Text = "Horas Totales";
            // 
            // txtHSSemanales
            // 
            this.txtHSSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHSSemanales.Location = new System.Drawing.Point(131, 200);
            this.txtHSSemanales.Name = "txtHSSemanales";
            this.txtHSSemanales.Size = new System.Drawing.Size(256, 20);
            this.txtHSSemanales.TabIndex = 15;
            // 
            // txtHSTotales
            // 
            this.txtHSTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHSTotales.Location = new System.Drawing.Point(131, 260);
            this.txtHSTotales.Name = "txtHSTotales";
            this.txtHSTotales.Size = new System.Drawing.Size(256, 20);
            this.txtHSTotales.TabIndex = 16;
            // 
            // btnModo
            // 
            this.btnModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModo.Location = new System.Drawing.Point(50, 307);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 7;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Location = new System.Drawing.Point(342, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblHSSemanales
            // 
            this.lblHSSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHSSemanales.AutoSize = true;
            this.lblHSSemanales.Location = new System.Drawing.Point(3, 203);
            this.lblHSSemanales.Name = "lblHSSemanales";
            this.lblHSSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHSSemanales.TabIndex = 13;
            this.lblHSSemanales.Text = "Horas Semanales";
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(420, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "Materia";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Label lblHSSemanales;
        private System.Windows.Forms.Label lblHSTotales;
        private System.Windows.Forms.TextBox txtHSSemanales;
        private System.Windows.Forms.TextBox txtHSTotales;
    }
}
