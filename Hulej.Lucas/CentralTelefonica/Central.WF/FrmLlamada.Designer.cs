namespace Central.WF
{
    partial class FrmLlamada
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
            this.lblNroOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtBoxNroOrigen = new System.Windows.Forms.TextBox();
            this.txtBoxDestino = new System.Windows.Forms.TextBox();
            this.txtBoxDuracion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNroOrigen
            // 
            this.lblNroOrigen.AutoSize = true;
            this.lblNroOrigen.Location = new System.Drawing.Point(2, 7);
            this.lblNroOrigen.Name = "lblNroOrigen";
            this.lblNroOrigen.Size = new System.Drawing.Size(93, 13);
            this.lblNroOrigen.TabIndex = 0;
            this.lblNroOrigen.Text = "Numero de Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(2, 50);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(2, 98);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duracion";
            // 
            // txtBoxNroOrigen
            // 
            this.txtBoxNroOrigen.Location = new System.Drawing.Point(5, 23);
            this.txtBoxNroOrigen.Name = "txtBoxNroOrigen";
            this.txtBoxNroOrigen.Size = new System.Drawing.Size(167, 20);
            this.txtBoxNroOrigen.TabIndex = 3;
            // 
            // txtBoxDestino
            // 
            this.txtBoxDestino.Location = new System.Drawing.Point(5, 66);
            this.txtBoxDestino.Name = "txtBoxDestino";
            this.txtBoxDestino.Size = new System.Drawing.Size(167, 20);
            this.txtBoxDestino.TabIndex = 4;
            // 
            // txtBoxDuracion
            // 
            this.txtBoxDuracion.Location = new System.Drawing.Point(5, 114);
            this.txtBoxDuracion.Name = "txtBoxDuracion";
            this.txtBoxDuracion.Size = new System.Drawing.Size(167, 20);
            this.txtBoxDuracion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(5, 197);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 237);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBoxDuracion);
            this.Controls.Add(this.txtBoxDestino);
            this.Controls.Add(this.txtBoxNroOrigen);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblNroOrigen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamada";
            this.Text = "Llamada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblNroOrigen;
        protected System.Windows.Forms.Label lblDestino;
        protected System.Windows.Forms.Label lblDuracion;
        protected System.Windows.Forms.TextBox txtBoxNroOrigen;
        protected System.Windows.Forms.TextBox txtBoxDestino;
        protected System.Windows.Forms.TextBox txtBoxDuracion;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.Button btnCancelar;
    }
}