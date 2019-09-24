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
            // FrmAlumnoCalificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 354);
            this.Name = "FrmAlumnoCalificado";
            this.Text = "FrmAlumnoCalificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}