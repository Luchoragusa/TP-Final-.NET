
namespace UI.Desktop
{
    partial class InscribirseACursado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirseACursado));
            this.tcInscribirse = new System.Windows.Forms.ToolStripContainer();
            this.tlInscribirse = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInscribirse = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsPlanes = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcInscribirse.ContentPanel.SuspendLayout();
            this.tcInscribirse.TopToolStripPanel.SuspendLayout();
            this.tcInscribirse.SuspendLayout();
            this.tlInscribirse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscribirse)).BeginInit();
            this.tsPlanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInscribirse
            // 
            // 
            // tcInscribirse.ContentPanel
            // 
            this.tcInscribirse.ContentPanel.Controls.Add(this.tlInscribirse);
            this.tcInscribirse.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInscribirse.Location = new System.Drawing.Point(0, 0);
            this.tcInscribirse.Name = "tcInscribirse";
            this.tcInscribirse.Size = new System.Drawing.Size(800, 450);
            this.tcInscribirse.TabIndex = 2;
            this.tcInscribirse.Text = "toolStripContainer1";
            // 
            // tcInscribirse.TopToolStripPanel
            // 
            this.tcInscribirse.TopToolStripPanel.Controls.Add(this.tsPlanes);
            // 
            // tlInscribirse
            // 
            this.tlInscribirse.ColumnCount = 2;
            this.tlInscribirse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInscribirse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlInscribirse.Controls.Add(this.dgvInscribirse, 0, 0);
            this.tlInscribirse.Controls.Add(this.btnSalir, 1, 1);
            this.tlInscribirse.Controls.Add(this.btnActualizar, 0, 1);
            this.tlInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInscribirse.Location = new System.Drawing.Point(0, 0);
            this.tlInscribirse.Name = "tlInscribirse";
            this.tlInscribirse.RowCount = 2;
            this.tlInscribirse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInscribirse.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlInscribirse.Size = new System.Drawing.Size(800, 425);
            this.tlInscribirse.TabIndex = 0;
            // 
            // dgvInscribirse
            // 
            this.dgvInscribirse.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInscribirse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInscribirse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscribirse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDCurso,
            this.IdDocente,
            this.Cargo,
            this.IDPlan});
            this.tlInscribirse.SetColumnSpan(this.dgvInscribirse, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInscribirse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscribirse.Location = new System.Drawing.Point(3, 3);
            this.dgvInscribirse.MultiSelect = false;
            this.dgvInscribirse.Name = "dgvInscribirse";
            this.dgvInscribirse.Size = new System.Drawing.Size(794, 390);
            this.dgvInscribirse.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID Materias";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDCurso
            // 
            this.IDCurso.DataPropertyName = "Descripcion";
            this.IDCurso.HeaderText = "Descripcion";
            this.IDCurso.Name = "IDCurso";
            // 
            // IdDocente
            // 
            this.IdDocente.DataPropertyName = "HSSSemanales";
            this.IdDocente.HeaderText = "Horas semanales";
            this.IdDocente.Name = "IdDocente";
            this.IdDocente.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "HSTotales";
            this.Cargo.HeaderText = "Horas Totales";
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 120;
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "ID Plan";
            this.IDPlan.Name = "IDPlan";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
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
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tsPlanes
            // 
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsPlanes.Location = new System.Drawing.Point(3, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(81, 25);
            this.tsPlanes.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // InscribirseACursado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcInscribirse);
            this.Name = "InscribirseACursado";
            this.Text = "Inscribirse A Cursado";
            this.Load += new System.EventHandler(this.InscribirseACursado_Load);
            this.tcInscribirse.ContentPanel.ResumeLayout(false);
            this.tcInscribirse.TopToolStripPanel.ResumeLayout(false);
            this.tcInscribirse.TopToolStripPanel.PerformLayout();
            this.tcInscribirse.ResumeLayout(false);
            this.tcInscribirse.PerformLayout();
            this.tlInscribirse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscribirse)).EndInit();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcInscribirse;
        private System.Windows.Forms.TableLayoutPanel tlInscribirse;
        private System.Windows.Forms.DataGridView dgvInscribirse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlan;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStrip tsPlanes;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}