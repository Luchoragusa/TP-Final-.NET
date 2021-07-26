
using System;

namespace UI.Desktop
{
    partial class EspecialidadDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIDEsp = new System.Windows.Forms.TextBox();
            this.txtDescEsp = new System.Windows.Forms.TextBox();
            this.lblIDEsp = new System.Windows.Forms.Label();
            this.lblDescEsp = new System.Windows.Forms.Label();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtIDEsp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescEsp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDEsp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescEsp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 165);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtIDEsp
            // 
            this.txtIDEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDEsp.Location = new System.Drawing.Point(101, 20);
            this.txtIDEsp.Name = "txtIDEsp";
            this.txtIDEsp.ReadOnly = true;
            this.txtIDEsp.Size = new System.Drawing.Size(256, 20);
            this.txtIDEsp.TabIndex = 0;
            // 
            // txtDescEsp
            // 
            this.txtDescEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescEsp.Location = new System.Drawing.Point(101, 80);
            this.txtDescEsp.Name = "txtDescEsp";
            this.txtDescEsp.Size = new System.Drawing.Size(256, 20);
            this.txtDescEsp.TabIndex = 1;
            // 
            // lblIDEsp
            // 
            this.lblIDEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDEsp.AutoSize = true;
            this.lblIDEsp.Location = new System.Drawing.Point(3, 23);
            this.lblIDEsp.Name = "lblIDEsp";
            this.lblIDEsp.Size = new System.Drawing.Size(81, 13);
            this.lblIDEsp.TabIndex = 10;
            this.lblIDEsp.Text = "ID Especialidad";
            // 
            // lblDescEsp
            // 
            this.lblDescEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescEsp.AutoSize = true;
            this.lblDescEsp.Location = new System.Drawing.Point(3, 77);
            this.lblDescEsp.Name = "lblDescEsp";
            this.lblDescEsp.Size = new System.Drawing.Size(92, 26);
            this.lblDescEsp.TabIndex = 11;
            this.lblDescEsp.Text = "Descripcion de la especialidad";
            // 
            // btnModo
            // 
            this.btnModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModo.Location = new System.Drawing.Point(20, 131);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 2;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Location = new System.Drawing.Point(294, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EspecialidadDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 165);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EspecialidadDesktop";
            this.Text = "EspecialidadDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        /*private void btnCancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDescEsp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescEsp;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.TextBox txtIDEsp;
        private System.Windows.Forms.Label lblIDEsp;
    }
}