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
    public partial class FrmLocal : FrmLlamada
    {
        public FrmLocal()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.llamada = new Local(this.txtBoxNroOrigen.Text, float.Parse(this.txtBoxDuracion.Text), this.txtBoxDestino.Text, float.Parse(this.txtBoxCosto.Text));
            base.btnAceptar_Click(sender, e);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            base.btnCancelar_Click(sender, e);
        }
    }
}
