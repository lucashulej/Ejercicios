namespace Clase_09.WF
{
    partial class FrmCatedra
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupAlumnos = new System.Windows.Forms.GroupBox();
            this.groupCalificados = new System.Windows.Forms.GroupBox();
            this.groupAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(150, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(81, 23);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(299, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(21, 231);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(345, 21);
            this.comboBox.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(21, 48);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(345, 160);
            this.listBox.TabIndex = 4;
            // 
            // groupAlumnos
            // 
            this.groupAlumnos.Controls.Add(this.comboBox);
            this.groupAlumnos.Controls.Add(this.btnAgregar);
            this.groupAlumnos.Controls.Add(this.listBox);
            this.groupAlumnos.Controls.Add(this.btnCalificar);
            this.groupAlumnos.Controls.Add(this.btnModificar);
            this.groupAlumnos.Location = new System.Drawing.Point(12, 12);
            this.groupAlumnos.Name = "groupAlumnos";
            this.groupAlumnos.Size = new System.Drawing.Size(386, 269);
            this.groupAlumnos.TabIndex = 5;
            this.groupAlumnos.TabStop = false;
            this.groupAlumnos.Text = "Alumnos";
            // 
            // groupCalificados
            // 
            this.groupCalificados.Location = new System.Drawing.Point(12, 293);
            this.groupCalificados.Name = "groupCalificados";
            this.groupCalificados.Size = new System.Drawing.Size(385, 186);
            this.groupCalificados.TabIndex = 6;
            this.groupCalificados.TabStop = false;
            this.groupCalificados.Text = "Alumnos Calificados";
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.groupCalificados);
            this.Controls.Add(this.groupAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.groupAlumnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupAlumnos;
        private System.Windows.Forms.GroupBox groupCalificados;
    }
}