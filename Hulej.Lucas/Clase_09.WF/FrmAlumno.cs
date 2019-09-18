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
    public partial class FrmAlumno : Form
    {
        public Alumno alumno;
        public FrmAlumno()
        {
            InitializeComponent();
            this.comboBoxExamen.Items.Add(ETipoExamen.Primero);
            this.comboBoxExamen.Items.Add(ETipoExamen.Segundo);
            this.comboBoxExamen.Items.Add(ETipoExamen.Final);
            this.comboBoxExamen.SelectedItem = ETipoExamen.Final;
        }

        public Alumno GetAlumno
        {
            get
            {
                return this.alumno;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Alumno(this.txtBoxNombre.Text, this.txtBoxApellido.Text, int.Parse(this.txtBoxLegajo.Text), (ETipoExamen)this.comboBoxExamen.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }
    }
}
