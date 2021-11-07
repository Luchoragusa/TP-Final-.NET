
namespace UI.Desktop.Inscribirse
{
    partial class ComisionesInscribirse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPlanes = new System.Windows.Forms.ToolStripContainer();
            this.tlPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComInscribirse = new System.Windows.Forms.DataGridView();
            this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.tcPlanes.ContentPanel.SuspendLayout();
            this.tcPlanes.SuspendLayout();
            this.tlPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComInscribirse)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPlanes
            // 
            // 
            // tcPlanes.ContentPanel
            // 
            this.tcPlanes.ContentPanel.Controls.Add(this.tlPlanes);
            this.tcPlanes.ContentPanel.Size = new System.Drawing.Size(800, 478);
            this.tcPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlanes.Location = new System.Drawing.Point(0, 0);
            this.tcPlanes.Name = "tcPlanes";
            this.tcPlanes.Size = new System.Drawing.Size(800, 478);
            this.tcPlanes.TabIndex = 2;
            this.tcPlanes.Text = "toolStripContainer1";
            // 
            // tlPlanes
            // 
            this.tlPlanes.ColumnCount = 2;
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlanes.Controls.Add(this.dgvComInscribirse, 0, 0);
            this.tlPlanes.Controls.Add(this.btnSalir, 1, 2);
            this.tlPlanes.Controls.Add(this.btnActualizar, 0, 2);
            this.tlPlanes.Controls.Add(this.btnInscribirse, 1, 1);
            this.tlPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlPlanes.Name = "tlPlanes";
            this.tlPlanes.RowCount = 3;
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanes.Size = new System.Drawing.Size(800, 478);
            this.tlPlanes.TabIndex = 0;
            // 
            // dgvComInscribirse
            // 
            this.dgvComInscribirse.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComInscribirse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComInscribirse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComInscribirse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDComision,
            this.Descripcion,
            this.IDPlan,
            this.Anio_Especialidad});
            this.tlPlanes.SetColumnSpan(this.dgvComInscribirse, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComInscribirse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComInscribirse.Location = new System.Drawing.Point(3, 3);
            this.dgvComInscribirse.MultiSelect = false;
            this.dgvComInscribirse.Name = "dgvComInscribirse";
            this.dgvComInscribirse.Size = new System.Drawing.Size(794, 412);
            this.dgvComInscribirse.TabIndex = 0;
            // 
            // IDComision
            // 
            this.IDComision.DataPropertyName = "ID";
            this.IDComision.HeaderText = "Id Comision";
            this.IDComision.Name = "IDComision";
            this.IDComision.ReadOnly = true;
            this.IDComision.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DescComision";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "Id Plan";
            this.IDPlan.Name = "IDPlan";
            // 
            // Anio_Especialidad
            // 
            this.Anio_Especialidad.DataPropertyName = "AnioEspecialidad";
            this.Anio_Especialidad.HeaderText = "Año Especialidad";
            this.Anio_Especialidad.Name = "Anio_Especialidad";
            this.Anio_Especialidad.Width = 160;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(722, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(617, 452);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribirse.Location = new System.Drawing.Point(698, 421);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(99, 23);
            this.btnInscribirse.TabIndex = 3;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = false;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // ComisionesInscribirse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tcPlanes);
            this.Name = "ComisionesInscribirse";
            this.Text = "ComisionesInscribirse";
            this.Load += new System.EventHandler(this.ComisionesInscribirse_Load);
            this.tcPlanes.ContentPanel.ResumeLayout(false);
            this.tcPlanes.ResumeLayout(false);
            this.tcPlanes.PerformLayout();
            this.tlPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComInscribirse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcPlanes;
        private System.Windows.Forms.TableLayoutPanel tlPlanes;
        private System.Windows.Forms.DataGridView dgvComInscribirse;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_Especialidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInscribirse;
    }
}