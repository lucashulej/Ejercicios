using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09.Entidades;

namespace Clase_09.WF
{
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        public List<Alumno> listaAlumnos;
        
        public FrmCatedra()
        {
            InitializeComponent();
            this.comboBox.Items.Add(ETipoOrdenamiento.ApellidoAscendente);
            this.comboBox.Items.Add(ETipoOrdenamiento.ApellidoDescendente);
            this.comboBox.Items.Add(ETipoOrdenamiento.LegajoAscendente);
            this.comboBox.Items.Add(ETipoOrdenamiento.LegajoDescendente);
            this.comboBox.SelectedItem = ETipoOrdenamiento.ApellidoAscendente;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            Alumno auxiliar;
            frmAlumno.ShowDialog();
            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                auxiliar = frmAlumno.GetAlumno;
                this.listBox.Items.Add(auxiliar.Nombre + " " + auxiliar.Apellido + " " + auxiliar.Legajo + " " + auxiliar.Examen);
                    
            }
                

        }
    }
}
