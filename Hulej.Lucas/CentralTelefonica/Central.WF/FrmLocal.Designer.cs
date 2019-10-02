namespace Central.WF
{
    partial class FrmLocal
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
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtBoxCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 197);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.TabIndex = 11;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(6, 144);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo";
            // 
            // txtBoxCosto
            // 
            this.txtBoxCosto.Location = new System.Drawing.Point(6, 160);
            this.txtBoxCosto.Name = "txtBoxCosto";
            this.txtBoxCosto.Size = new System.Drawing.Size(161, 20);
            this.txtBoxCosto.TabIndex = 9;
            // 
            // FrmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 230);
            this.Controls.Add(this.txtBoxCosto);
            this.Controls.Add(this.lblCosto);
            this.Name = "FrmLocal";
            this.Text = "FrmLocal";
            this.Controls.SetChildIndex(this.lblNroOrigen, 0);
            this.Controls.SetChildIndex(this.lblDestino, 0);
            this.Controls.SetChildIndex(this.lblDuracion, 0);
            this.Controls.SetChildIndex(this.txtBoxNroOrigen, 0);
            this.Controls.SetChildIndex(this.txtBoxDestino, 0);
            this.Controls.SetChildIndex(this.txtBoxDuracion, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.Controls.SetChildIndex(this.txtBoxCosto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtBoxCosto;
    }
}