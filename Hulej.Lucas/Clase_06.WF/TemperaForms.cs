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
    public partial class TemperaForms : Form
    {
        private Tempera tempera;

        public Tempera MiTempera
        {
            get{ return this.tempera; }
        }
        
        public TemperaForms()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                this.cmbColor.Items.Add(color);

            this.cmbColor.SelectedItem = ConsoleColor.Magenta;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.tempera = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, this.txtMarca.Text, int.Parse(this.txtCantidad.Text));
            MessageBox.Show(tempera);
        }
    }
}
