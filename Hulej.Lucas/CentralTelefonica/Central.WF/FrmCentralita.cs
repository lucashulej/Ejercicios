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
    public partial class FrmCentralita : Form
    {
        Centralita central = new Centralita();
        Llamada auxiliar;

        public FrmCentralita()
        {
            InitializeComponent();
            this.comboBox.Items.Add("Ordenar x duracion");
            this.comboBox.SelectedItem = "Ordenar x duracion";
            this.IsMdiContainer = true;
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmLocal frmLocal = new FrmLocal();
            frmLocal.ShowDialog();
            int lastSize = 0;
            if(frmLocal.DialogResult == DialogResult.OK)
            {
                auxiliar = frmLocal.GetLlamada;
                lastSize = this.central.Llamadas.Count;
                this.central = this.central + auxiliar;
                if(this.central.Llamadas.Count > lastSize)
                {
                    this.listBox.Items.Add(frmLocal.GetLlamada.ToString());
                }
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial frmProvincial = new FrmProvincial();
            frmProvincial.ShowDialog();
            int lastSize = 0;
            if (frmProvincial.DialogResult == DialogResult.OK)
            {
                auxiliar = frmProvincial.GetLlamada;
                lastSize = this.central.Llamadas.Count;
                this.central = this.central + auxiliar;
                if (this.central.Llamadas.Count > lastSize)
                {
                    this.listBox.Items.Add(frmProvincial.GetLlamada.ToString());
                }
            }
        }

        private void printSortedList()
        {
            switch(this.comboBox.SelectedItem)
            {
                case "Ordenar x duracion Ascendente":
                    this.central.OrdenarLlamadas();
                    this.printList();
                    break;
            }
        }

        private void printList()
        {
            this.listBox.Items.Clear(); 
            foreach(Llamada auxiliar in this.central.Llamadas)
            {
                this.listBox.Items.Add(auxiliar.ToString());
            }
        }
    }
}
