﻿
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfClave = new System.Windows.Forms.TextBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.02564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.97436F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConfClave, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnModo, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblClave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmarClave, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(65, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(229, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(65, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(65, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.Location = new System.Drawing.Point(65, 200);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(229, 20);
            this.txtClave.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(382, 80);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(256, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Location = new System.Drawing.Point(382, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtConfClave
            // 
            this.txtConfClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfClave.Location = new System.Drawing.Point(382, 200);
            this.txtConfClave.Name = "txtConfClave";
            this.txtConfClave.Size = new System.Drawing.Size(256, 20);
            this.txtConfClave.TabIndex = 6;
            // 
            // btnModo
            // 
            this.btnModo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModo.Location = new System.Drawing.Point(301, 250);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(75, 23);
            this.btnModo.TabIndex = 7;
            this.btnModo.Text = "Aceptar";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.botonAceptarClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Location = new System.Drawing.Point(583, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botonCancelarClick);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(303, 21);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 9;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(3, 203);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 13;
            this.lblClave.Text = "Clave";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(300, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(300, 143);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(300, 197);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(54, 26);
            this.lblConfirmarClave.TabIndex = 16;
            this.lblConfirmarClave.Text = "Confirmar Clave";
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(661, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfClave;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarClave;
    }
}