namespace Central.WF
{
    partial class FrmProvincial
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
            this.lblFranjaHoraria = new System.Windows.Forms.Label();
            this.cmbBoxFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblFranjaHoraria
            // 
            this.lblFranjaHoraria.AutoSize = true;
            this.lblFranjaHoraria.Location = new System.Drawing.Point(2, 146);
            this.lblFranjaHoraria.Name = "lblFranjaHoraria";
            this.lblFranjaHoraria.Size = new System.Drawing.Size(73, 13);
            this.lblFranjaHoraria.TabIndex = 8;
            this.lblFranjaHoraria.Text = "Franja Horaria";
            // 
            // cmbBoxFranjaHoraria
            // 
            this.cmbBoxFranjaHoraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFranjaHoraria.FormattingEnabled = true;
            this.cmbBoxFranjaHoraria.Location = new System.Drawing.Point(5, 162);
            this.cmbBoxFranjaHoraria.Name = "cmbBoxFranjaHoraria";
            this.cmbBoxFranjaHoraria.Size = new System.Drawing.Size(167, 21);
            this.cmbBoxFranjaHoraria.TabIndex = 9;
            // 
            // FrmProvincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 231);
            this.Controls.Add(this.cmbBoxFranjaHoraria);
            this.Controls.Add(this.lblFranjaHoraria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProvincial";
            this.Text = "FrmProvincial";
            this.Controls.SetChildIndex(this.lblNroOrigen, 0);
            this.Controls.SetChildIndex(this.lblDestino, 0);
            this.Controls.SetChildIndex(this.lblDuracion, 0);
            this.Controls.SetChildIndex(this.txtBoxNroOrigen, 0);
            this.Controls.SetChildIndex(this.txtBoxDestino, 0);
            this.Controls.SetChildIndex(this.txtBoxDuracion, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblFranjaHoraria, 0);
            this.Controls.SetChildIndex(this.cmbBoxFranjaHoraria, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFranjaHoraria;
        private System.Windows.Forms.ComboBox cmbBoxFranjaHoraria;
    }
}