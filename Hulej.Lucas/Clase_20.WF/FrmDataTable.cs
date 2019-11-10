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

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            frmPersona.ShowDialog();
            if(frmPersona.DialogResult == DialogResult.OK)
            {
                DataRow fila = this.tabla.NewRow();
                fila["nombre"] = frmPersona.Persona.nombre;
                fila["apellido"] = frmPersona.Persona.apellido;
                fila["edad"] = frmPersona.Persona.edad;
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
                fila["nombre"] = frmPersona.Persona.nombre;
                fila["apellido"] = frmPersona.Persona.apellido;
                fila["edad"] = frmPersona.Persona.edad;
                this.actualizarListBox();
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRow fila = this.tabla.Rows[this.lstVisor.SelectedIndex];
            fila.Delete();
            this.actualizarListBox();
        }

        private void actualizarListBox()
        {
            this.lstVisor.Items.Clear();
            foreach (DataRow item in this.tabla.Rows)
            {
                if (item.RowState != DataRowState.Deleted)
                {
                    this.lstVisor.Items.Add(item["nombre"].ToString() + " " + item["apellido"].ToString() + " " + item["edad"].ToString());
                }
            }
        }
    }
}