
namespace UI.Desktop.RegistroNotas
{
    partial class RegistroNotas
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
            this.dgvRN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRN
            // 
            this.dgvRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRN.Location = new System.Drawing.Point(12, 12);
            this.dgvRN.Name = "dgvRN";
            this.dgvRN.Size = new System.Drawing.Size(776, 426);
            this.dgvRN.TabIndex = 0;
            // 
            // RegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRN);
            this.Name = "RegistroNotas";
            this.Text = "RegistroNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRN;
    }
}