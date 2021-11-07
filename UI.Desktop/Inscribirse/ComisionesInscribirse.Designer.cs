
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComisionesInscribirse));
            this.tcPlanes = new System.Windows.Forms.ToolStripContainer();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvComInscribirse = new System.Windows.Forms.DataGridView();
            this.Anio_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInscribirse = new System.Windows.Forms.ToolStripButton();
            this.tcPlanes.ContentPanel.SuspendLayout();
            this.tcPlanes.TopToolStripPanel.SuspendLayout();
            this.tcPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComInscribirse)).BeginInit();
            this.tlPlanes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPlanes
            // 
            // 
            // tcPlanes.ContentPanel
            // 
            this.tcPlanes.ContentPanel.Controls.Add(this.tlPlanes);
            this.tcPlanes.ContentPanel.Size = new System.Drawing.Size(800, 453);
            this.tcPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlanes.Location = new System.Drawing.Point(0, 0);
            this.tcPlanes.Name = "tcPlanes";
            this.tcPlanes.Size = new System.Drawing.Size(800, 478);
            this.tcPlanes.TabIndex = 2;
            this.tcPlanes.Text = "toolStripContainer1";
            // 
            // tcPlanes.TopToolStripPanel
            // 
            this.tcPlanes.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 427);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(722, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvComInscribirse
            // 
            this.dgvComInscribirse.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComInscribirse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComInscribirse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComInscribirse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDComision,
            this.Descripcion,
            this.IDPlan,
            this.Anio_Especialidad});
            this.tlPlanes.SetColumnSpan(this.dgvComInscribirse, 2);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComInscribirse.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComInscribirse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComInscribirse.Location = new System.Drawing.Point(3, 3);
            this.dgvComInscribirse.MultiSelect = false;
            this.dgvComInscribirse.Name = "dgvComInscribirse";
            this.dgvComInscribirse.Size = new System.Drawing.Size(794, 410);
            this.dgvComInscribirse.TabIndex = 0;
            // 
            // Anio_Especialidad
            // 
            this.Anio_Especialidad.DataPropertyName = "AnioEspecialidad";
            this.Anio_Especialidad.HeaderText = "Año Especialidad";
            this.Anio_Especialidad.Name = "Anio_Especialidad";
            this.Anio_Especialidad.Width = 160;
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "Id Plan";
            this.IDPlan.Name = "IDPlan";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "DescComision";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // IDComision
            // 
            this.IDComision.DataPropertyName = "ID";
            this.IDComision.HeaderText = "Id Comision";
            this.IDComision.Name = "IDComision";
            this.IDComision.ReadOnly = true;
            this.IDComision.Width = 150;
            // 
            // tlPlanes
            // 
            this.tlPlanes.ColumnCount = 2;
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlanes.Controls.Add(this.dgvComInscribirse, 0, 0);
            this.tlPlanes.Controls.Add(this.btnSalir, 1, 2);
            this.tlPlanes.Controls.Add(this.btnActualizar, 0, 2);
            this.tlPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlPlanes.Name = "tlPlanes";
            this.tlPlanes.RowCount = 3;
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanes.Size = new System.Drawing.Size(800, 453);
            this.tlPlanes.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInscribirse});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(76, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInscribirse.Image = ((System.Drawing.Image)(resources.GetObject("btnInscribirse.Image")));
            this.btnInscribirse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(64, 22);
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // ComisionesInscribirse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tcPlanes);
            this.Name = "ComisionesInscribirse";
            this.Text = "Inscribirse a Cursado";
            this.Load += new System.EventHandler(this.ComisionesInscribirse_Load);
            this.tcPlanes.ContentPanel.ResumeLayout(false);
            this.tcPlanes.TopToolStripPanel.ResumeLayout(false);
            this.tcPlanes.TopToolStripPanel.PerformLayout();
            this.tcPlanes.ResumeLayout(false);
            this.tcPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComInscribirse)).EndInit();
            this.tlPlanes.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInscribirse;
    }
}