namespace Clase_09.WF
{
    partial class FrmAlumnoCalificado
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
            this.lblNota = new System.Windows.Forms.Label();
            this.txtBoxNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Enabled = false;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Enabled = false;
            // 
            // txtBoxLegajo
            // 
            this.txtBoxLegajo.Enabled = false;
            // 
            // comboBoxExamen
            // 
            this.comboBoxExamen.Enabled = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(167, 284);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 284);
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(19, 226);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 10;
            this.lblNota.Text = "Nota";
            // 
            // txtBoxNota
            // 
            this.txtBoxNota.Location = new System.Drawing.Point(12, 242);
            this.txtBoxNota.Name = "txtBoxNota";
            this.txtBoxNota.Size = new System.Drawing.Size(237, 20);
            this.txtBoxNota.TabIndex = 11;
            // 
            // FrmAlumnoCalificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 330);
            this.Controls.Add(this.txtBoxNota);
            this.Controls.Add(this.lblNota);
            this.Name = "FrmAlumnoCalificado";
            this.Text = "FrmAlumnoCalificado";
            this.Controls.SetChildIndex(this.txtBoxNombre, 0);
            this.Controls.SetChildIndex(this.txtBoxApellido, 0);
            this.Controls.SetChildIndex(this.txtBoxLegajo, 0);
            this.Controls.SetChildIndex(this.comboBoxExamen, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblNota, 0);
            this.Controls.SetChildIndex(this.txtBoxNota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtBoxNota;
    }
}