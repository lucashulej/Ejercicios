﻿namespace Clase_06.WF
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPaleta = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // paletaToolStripMenuItem
            // 
            this.paletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.paletaToolStripMenuItem.Name = "paletaToolStripMenuItem";
            this.paletaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.paletaToolStripMenuItem.Text = "Crear Paleta";
            this.paletaToolStripMenuItem.Click += new System.EventHandler(this.paletaToolStripMenuItem_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // grpPaleta
            // 
            this.grpPaleta.Controls.Add(this.list);
            this.grpPaleta.Location = new System.Drawing.Point(7, 35);
            this.grpPaleta.Name = "grpPaleta";
            this.grpPaleta.Size = new System.Drawing.Size(431, 282);
            this.grpPaleta.TabIndex = 1;
            this.grpPaleta.TabStop = false;
            this.grpPaleta.Text = "groupBox1";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(0, 32);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(431, 238);
            this.list.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.grpPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPaleta;
        private System.Windows.Forms.ListBox list;
    }
}

