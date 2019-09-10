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
        Paleta paleta;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.grpPaleta.Visible = false;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemperaForms frm = new TemperaForms();
            //frm.MdiParent = this;
            frm.ShowDialog();
            this.paleta += frm.MiTempera;
            this.listBox1.Items.Add(paleta);
            
        }

        private void paleta_Enter(object sender, EventArgs e)
        {

        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grpPaleta.Visible = true;
        }
    }
}
