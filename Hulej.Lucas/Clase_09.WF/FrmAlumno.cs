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
            if(int.TryParse(this.txtBoxLegajo.Text,out int auxiliar) && isValidName(this.txtBoxNombre.Text) && isValidName(this.txtBoxApellido.Text))
            {
                alumno = new Alumno(this.txtBoxNombre.Text, this.txtBoxApellido.Text, int.Parse(this.txtBoxLegajo.Text), (ETipoExamen)this.comboBoxExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son validos");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidName(string auxiliar)
        {
            bool retorno = true;

            if (auxiliar != "")
            {
                foreach (char aux in auxiliar)
                {
                    if ((aux < 'a' || aux > 'z') && (aux < 'A' || aux > 'Z'))
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            else
                retorno = false;

            return retorno;
        }
    }
}
