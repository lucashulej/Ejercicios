using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;
namespace Clase_06.WF
{
    public partial class Form1 : Form
    {
        Paleta paleta = 5;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.grpPaleta.Visible = false;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm.MdiParent = this;
            TemperaForms frm = new TemperaForms();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.paleta = this.paleta + frm.MiTempera;
                this.list.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    if (Object.Equals(paleta[i], null) == false)
                    {
                        this.list.Items.Add((string)paleta[i]);
                    }
                }
            }   
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grpPaleta.Visible = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            TemperaForms frm = new TemperaForms(); 
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.paleta = this.paleta + frm.MiTempera;
                this.list.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    if (Object.Equals(paleta[i], null) == false)
                    {
                        this.list.Items.Add((string)paleta[i]);
                    }
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            TemperaForms frm = new TemperaForms();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.paleta = this.paleta - frm.MiTempera;
                this.list.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    if (Object.Equals(paleta[i], null) == false)
                    {
                        this.list.Items.Add((string)paleta[i]);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Tempera t = null;

            if (this.list.SelectedIndex >= 0)
                t = this.paleta[this.list.SelectedIndex];

            if(Object.Equals(t,null) == false)
            {
                TemperaForms frm = new TemperaForms();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.list.Items.Clear();
                   // this.paleta[this.list.SelectedIndex] = t;
                    for (int i = 0; i < 5; i++)
                    {
                        if (Object.Equals(paleta[i], null) == false)
                        {
                            this.list.Items.Add((string)paleta[i]);
                        }
                    }
                }
            }
        }
    }
}
