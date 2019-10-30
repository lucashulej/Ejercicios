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
    public partial class frmVisorPersona : Form
    {
        private List<Persona> listaAux;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.listaAux = new List<Persona>();
        }

        public frmVisorPersona(List<Persona> lista) : this()
        {
            this.listaAux = lista;
            this.cargarListBox();
        }

        public List<Persona> Lista
        {
            get
            {
                return this.listaAux;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                this.listaAux.Add(frm.Persona);
                this.cargarListBox();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //PARAMETRO EN CONSTRUCTOR APRA MODIFICAR
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void cargarListBox()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona item in this.listaAux)
            {
                this.lstVisor.Items.Add(item.ToString());
            }
        }
    }
}
