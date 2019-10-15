namespace Archivos.WF
{
    partial class Form1
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
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.txtBoxTexto = new System.Windows.Forms.TextBox();
            this.cmbBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArchivo.Location = new System.Drawing.Point(9, 9);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(101, 13);
            this.lblNombreArchivo.TabIndex = 0;
            this.lblNombreArchivo.Text = "Nombre Archivo:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(9, 69);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(68, 13);
            this.lblUbicacion.TabIndex = 1;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(12, 144);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(39, 13);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Texto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 290);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(138, 290);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(103, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // txtBoxNombreArchivo
            // 
            this.txtBoxNombreArchivo.Location = new System.Drawing.Point(12, 29);
            this.txtBoxNombreArchivo.Name = "txtBoxNombreArchivo";
            this.txtBoxNombreArchivo.Size = new System.Drawing.Size(228, 20);
            this.txtBoxNombreArchivo.TabIndex = 5;
            // 
            // txtBoxTexto
            // 
            this.txtBoxTexto.Location = new System.Drawing.Point(12, 171);
            this.txtBoxTexto.Multiline = true;
            this.txtBoxTexto.Name = "txtBoxTexto";
            this.txtBoxTexto.Size = new System.Drawing.Size(228, 85);
            this.txtBoxTexto.TabIndex = 6;
            // 
            // cmbBoxUbicacion
            // 
            this.cmbBoxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUbicacion.FormattingEnabled = true;
            this.cmbBoxUbicacion.Location = new System.Drawing.Point(12, 100);
            this.cmbBoxUbicacion.Name = "cmbBoxUbicacion";
            this.cmbBoxUbicacion.Size = new System.Drawing.Size(229, 21);
            this.cmbBoxUbicacion.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 323);
            this.Controls.Add(this.cmbBoxUbicacion);
            this.Controls.Add(this.txtBoxTexto);
            this.Controls.Add(this.txtBoxNombreArchivo);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblNombreArchivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ArchivoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.TextBox txtBoxNombreArchivo;
        private System.Windows.Forms.TextBox txtBoxTexto;
        private System.Windows.Forms.ComboBox cmbBoxUbicacion;
    }
}

