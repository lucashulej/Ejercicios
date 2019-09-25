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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        public AlumnoCalificado alumnoCalificado;
        
        public AlumnoCalificado AlumnoCalificado
        {
            get
            {
                return this.alumnoCalificado;
            }
        }

        public FrmAlumnoCalificado()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.alumnoCalificado = new AlumnoCalificado(this.txtBoxNombre.Text, this.txtBoxApellido.Text, int.Parse(this.txtBoxLegajo.Text), (ETipoExamen)this.comboBoxExamen.SelectedItem, int.Parse(this.txtBoxNota.Text));
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("ACA HAY ALGO RARO");
        }
    }
}
