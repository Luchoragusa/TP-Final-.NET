﻿
namespace UI.Desktop
{
    partial class ComisionesDesktop
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModo = new System.Windows.Forms.Button();
            this.txtAnioEsp_Com = new System.Windows.Forms.TextBox();
            this.lblAnioEsp = new System.Windows.Forms.Label();
            this.lblDescCom = new System.Windows.Forms.Label();
            this.txtDesc_Com = new System.Windows.Forms.TextBox();
            this.txtIDPlan_Com = new System.Windows.Forms.TextBox();
            this.txtIDCom = new System.Windows.Forms.TextBox();
            this.lblID_Plan = new System.Windows.Forms.Label();
            this.lblIDComision = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.4375F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAnioEsp_Com, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioEsp, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDescCom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc_Com, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIDPlan_Com, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID_Plan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIDComision, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 262);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(306, 236);
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
            this.btnModo.Location = new System.Drawing.Point(3, 236);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 4;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // txtAnioEsp_Com
            // 
            this.txtAnioEsp_Com.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioEsp_Com.Location = new System.Drawing.Point(105, 195);
            this.txtAnioEsp_Com.Name = "txtAnioEsp_Com";
            this.txtAnioEsp_Com.Size = new System.Drawing.Size(256, 20);
            this.txtAnioEsp_Com.TabIndex = 3;
            // 
            // lblAnioEsp
            // 
            this.lblAnioEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioEsp.AutoSize = true;
            this.lblAnioEsp.Location = new System.Drawing.Point(3, 199);
            this.lblAnioEsp.Name = "lblAnioEsp";
            this.lblAnioEsp.Size = new System.Drawing.Size(89, 13);
            this.lblAnioEsp.TabIndex = 10;
            this.lblAnioEsp.Text = "Año Especialidad";
            // 
            // lblDescCom
            // 
            this.lblDescCom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescCom.AutoSize = true;
            this.lblDescCom.Location = new System.Drawing.Point(3, 137);
            this.lblDescCom.Name = "lblDescCom";
            this.lblDescCom.Size = new System.Drawing.Size(92, 26);
            this.lblDescCom.TabIndex = 11;
            this.lblDescCom.Text = "Descripcion de la comision";
            // 
            // txtDesc_Com
            // 
            this.txtDesc_Com.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc_Com.Location = new System.Drawing.Point(105, 140);
            this.txtDesc_Com.Name = "txtDesc_Com";
            this.txtDesc_Com.Size = new System.Drawing.Size(256, 20);
            this.txtDesc_Com.TabIndex = 2;
            // 
            // txtIDPlan_Com
            // 
            this.txtIDPlan_Com.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDPlan_Com.Location = new System.Drawing.Point(105, 80);
            this.txtIDPlan_Com.Name = "txtIDPlan_Com";
            this.txtIDPlan_Com.Size = new System.Drawing.Size(256, 20);
            this.txtIDPlan_Com.TabIndex = 1;
            // 
            // txtIDCom
            // 
            this.txtIDCom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIDCom.Location = new System.Drawing.Point(105, 20);
            this.txtIDCom.Name = "txtIDCom";
            this.txtIDCom.ReadOnly = true;
            this.txtIDCom.Size = new System.Drawing.Size(256, 20);
            this.txtIDCom.TabIndex = 1;
            // 
            // lblID_Plan
            // 
            this.lblID_Plan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID_Plan.AutoSize = true;
            this.lblID_Plan.Location = new System.Drawing.Point(3, 83);
            this.lblID_Plan.Name = "lblID_Plan";
            this.lblID_Plan.Size = new System.Drawing.Size(58, 13);
            this.lblID_Plan.TabIndex = 12;
            this.lblID_Plan.Text = "ID del plan";
            // 
            // lblIDComision
            // 
            this.lblIDComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDComision.AutoSize = true;
            this.lblIDComision.Location = new System.Drawing.Point(3, 23);
            this.lblIDComision.Name = "lblIDComision";
            this.lblIDComision.Size = new System.Drawing.Size(63, 13);
            this.lblIDComision.TabIndex = 13;
            this.lblIDComision.Text = "ID Comision";
            // 
            // ComisionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComisionesDesktop";
            this.Text = "Comisiones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAnioEsp_Com;
        private System.Windows.Forms.TextBox txtDesc_Com;
        private System.Windows.Forms.TextBox txtIDPlan_Com;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAnioEsp;
        private System.Windows.Forms.Label lblDescCom;
        private System.Windows.Forms.Label lblID_Plan;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.TextBox txtIDCom;
        private System.Windows.Forms.Label lblIDComision;
    }
}
