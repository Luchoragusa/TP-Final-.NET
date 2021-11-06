
namespace UI.Desktop.RegitrarDocenteCurso
{
    partial class Cursos_Docente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos_Docente));
            this.tcPlanes = new System.Windows.Forms.ToolStripContainer();
            this.tlPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsPlanes = new System.Windows.Forms.ToolStrip();
            this.tsbIngresar = new System.Windows.Forms.ToolStripButton();
            this.tcPlanes.ContentPanel.SuspendLayout();
            this.tcPlanes.TopToolStripPanel.SuspendLayout();
            this.tcPlanes.SuspendLayout();
            this.tlPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            this.tsPlanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPlanes
            // 
            // 
            // tcPlanes.ContentPanel
            // 
            this.tcPlanes.ContentPanel.Controls.Add(this.tlPlanes);
            this.tcPlanes.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlanes.Location = new System.Drawing.Point(0, 0);
            this.tcPlanes.Name = "tcPlanes";
            this.tcPlanes.Size = new System.Drawing.Size(800, 450);
            this.tcPlanes.TabIndex = 4;
            this.tcPlanes.Text = "toolStripContainer1";
            // 
            // tcPlanes.TopToolStripPanel
            // 
            this.tcPlanes.TopToolStripPanel.Controls.Add(this.tsPlanes);
            // 
            // tlPlanes
            // 
            this.tlPlanes.ColumnCount = 2;
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlanes.Controls.Add(this.dgvCursosDocente, 0, 0);
            this.tlPlanes.Controls.Add(this.btnSalir, 1, 1);
            this.tlPlanes.Controls.Add(this.btnActualizar, 0, 1);
            this.tlPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlPlanes.Name = "tlPlanes";
            this.tlPlanes.RowCount = 2;
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlanes.Size = new System.Drawing.Size(800, 425);
            this.tlPlanes.TabIndex = 0;
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosDocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDMateria,
            this.IDComision,
            this.AnioCalendario,
            this.Cupo});
            this.tlPlanes.SetColumnSpan(this.dgvCursosDocente, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursosDocente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursosDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursosDocente.Location = new System.Drawing.Point(3, 3);
            this.dgvCursosDocente.MultiSelect = false;
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.Size = new System.Drawing.Size(794, 390);
            this.dgvCursosDocente.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID Curso";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDMateria
            // 
            this.IDMateria.DataPropertyName = "IDMateria";
            this.IDMateria.HeaderText = "ID Materia";
            this.IDMateria.Name = "IDMateria";
            // 
            // IDComision
            // 
            this.IDComision.DataPropertyName = "IDComision";
            this.IDComision.HeaderText = "ID Comision";
            this.IDComision.Name = "IDComision";
            this.IDComision.Width = 150;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.Width = 150;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "Cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // 
            // tsPlanes
            // 
            this.tsPlanes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIngresar});
            this.tsPlanes.Location = new System.Drawing.Point(3, 0);
            this.tsPlanes.Name = "tsPlanes";
            this.tsPlanes.Size = new System.Drawing.Size(83, 25);
            this.tsPlanes.TabIndex = 0;
            // 
            // tsbIngresar
            // 
            this.tsbIngresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIngresar.Image = ((System.Drawing.Image)(resources.GetObject("tsbIngresar.Image")));
            this.tsbIngresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIngresar.Name = "tsbIngresar";
            this.tsbIngresar.Size = new System.Drawing.Size(71, 22);
            this.tsbIngresar.Text = "Seleccionar";
            // 
            // Cursos_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPlanes);
            this.Name = "Cursos_Docente";
            this.Text = "Cursos_Docente";
            this.tcPlanes.ContentPanel.ResumeLayout(false);
            this.tcPlanes.TopToolStripPanel.ResumeLayout(false);
            this.tcPlanes.TopToolStripPanel.PerformLayout();
            this.tcPlanes.ResumeLayout(false);
            this.tcPlanes.PerformLayout();
            this.tlPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            this.tsPlanes.ResumeLayout(false);
            this.tsPlanes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcPlanes;
        private System.Windows.Forms.TableLayoutPanel tlPlanes;
        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStrip tsPlanes;
        private System.Windows.Forms.ToolStripButton tsbIngresar;
    }
}