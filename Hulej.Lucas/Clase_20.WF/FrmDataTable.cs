using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_20.Entidades;

namespace AdminPersonas
{
    public partial class FrmDataTable : frmVisorPersona
    {
        private DataTable tabla;

        public FrmDataTable(DataTable tabla)
        {
            InitializeComponent();
            this.tabla = tabla;
            this.actualizarListBox();
        }

        private void actualizarListBox()
        {
            this.lstVisor.Items.Clear();
            foreach (DataRow item in this.tabla.Rows)
            {
                this.lstVisor.Items.Add(item["nombre"].ToString() + " " + item["apellido"].ToString() + " " + item["edad"].ToString());
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            frmPersona.ShowDialog();
            if(frmPersona.DialogResult == DialogResult.OK)
            {
                DataRow fila = this.tabla.NewRow();
                fila[1] = frmPersona.Persona.nombre;
                fila[2] = frmPersona.Persona.apellido;
                fila[3] = frmPersona.Persona.edad;
                this.tabla.Rows.Add(fila);
                this.actualizarListBox();
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow fila = this.tabla.Rows[this.lstVisor.SelectedIndex];
            frmPersona frmPersona = new frmPersona(new Persona(fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3])));
            frmPersona.ShowDialog();
            if (frmPersona.DialogResult == DialogResult.OK)
            {
                fila[1] = frmPersona.Persona.nombre;
                fila[2] = frmPersona.Persona.apellido;
                fila[3] = frmPersona.Persona.edad;
                this.actualizarListBox();
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRow fila = this.tabla.Rows[this.lstVisor.SelectedIndex];
            fila.Delete();
            this.actualizarListBox();
        }

    }
}