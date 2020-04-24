namespace login
{
    partial class Usuario
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
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.lblMensajeAdmin = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibro
            // 
            this.dgvLibro.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.GridColor = System.Drawing.Color.White;
            this.dgvLibro.Location = new System.Drawing.Point(75, 117);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.Size = new System.Drawing.Size(349, 253);
            this.dgvLibro.TabIndex = 25;
            // 
            // lblMensajeAdmin
            // 
            this.lblMensajeAdmin.AutoSize = true;
            this.lblMensajeAdmin.Location = new System.Drawing.Point(244, 22);
            this.lblMensajeAdmin.Name = "lblMensajeAdmin";
            this.lblMensajeAdmin.Size = new System.Drawing.Size(0, 0);
            this.lblMensajeAdmin.TabIndex = 32;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 382);
            this.Controls.Add(this.lblMensajeAdmin);
            this.Controls.Add(this.dgvLibro);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLibro;
        private MetroFramework.Controls.MetroLabel lblMensajeAdmin;
    }
}