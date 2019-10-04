using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Central.Entidades;

namespace Central.WF
{
    public partial class FrmProvincial : FrmLlamada
    {
        public FrmProvincial()
        {
            InitializeComponent();
            this.cmbBoxFranjaHoraria.Items.Add(Franja.Franja_1);
            this.cmbBoxFranjaHoraria.Items.Add(Franja.Franja_2);
            this.cmbBoxFranjaHoraria.Items.Add(Franja.Franja_3);
            this.cmbBoxFranjaHoraria.SelectedItem = Franja.Franja_1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            base.llamada = new Provincial(this.txtBoxNroOrigen.Text, (Franja)this.cmbBoxFranjaHoraria.SelectedItem, float.Parse(this.txtBoxDuracion.Text), this.txtBoxDestino.Text);
            base.btnAceptar_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
