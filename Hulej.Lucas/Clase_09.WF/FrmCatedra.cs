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
        private Catedra catedra = new Catedra();
        public List<AlumnoCalificado> listaAlumnosCalificados = new List<AlumnoCalificado>();

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
            Alumno alumno;
            bool existeLegajo = false;
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                alumno = frmAlumno.GetAlumno;
                foreach (Alumno auxiliar in catedra.Alumnos)
                {
                    if (auxiliar.Legajo == alumno.Legajo)
                    {
                        existeLegajo = true;
                        break;
                    }
                }

                if (existeLegajo == false)
                {
                    catedra.Alumnos.Add(alumno);
                    this.ActualizarListadoAlumnos();
                }
                else
                {
                    MessageBox.Show("El legajo no es valido");
                }
            }
          

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListadoAlumnos();
        }

        private void ActualizarListadoAlumnos()
        {
            switch (this.comboBox.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    printList();
                    break;

                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    printList();
                    break;

                case ETipoOrdenamiento.LegajoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    printList();
                    break;

                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    printList();
                    break;
            }
        }

        private void printList()
        {
            this.listBox.Items.Clear();
            foreach (Alumno auxiliar in catedra.Alumnos)
            {
                this.listBox.Items.Add(auxiliar.ToString()); 
            }
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            if (this.catedra.Alumnos.Count > 0)
            {
                if(this.listBox.SelectedIndex >= 0)
                {
                    FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado();
                    Alumno auxiliar = this.catedra.Alumnos[this.listBox.SelectedIndex];
                    frmCalificado.txtBoxNombre.Text = auxiliar.Nombre;
                    frmCalificado.txtBoxApellido.Text = auxiliar.Apellido;
                    frmCalificado.txtBoxLegajo.Text = auxiliar.Legajo.ToString();
                    frmCalificado.comboBoxExamen.SelectedItem = auxiliar.Examen;
                    frmCalificado.ShowDialog();

                    if(frmCalificado.DialogResult == DialogResult.OK)
                    {
                        //SE SACA DE UNA LISTA DEL Y SE PONE EN LA OTRA
                        this.catedra.Alumnos.Remove(auxiliar);
                        this.listaAlumnosCalificados.Add(frmCalificado.AlumnoCalificado);

                        this.ActualizarListadoAlumnosCalificados();
                    }
                }
                else
                    MessageBox.Show("Seleccione un alumno");

            }
            else
                MessageBox.Show("No hay alumnos ingresados");
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.catedra.Alumnos.Count > 0)
            {
                if (this.listBox.SelectedIndex >= 0)
                {
                    FrmAlumno frmAlumno = new FrmAlumno();
                    Alumno auxiliar = this.catedra.Alumnos[this.listBox.SelectedIndex];

                    frmAlumno.txtBoxNombre.Text = auxiliar.Nombre;
                    frmAlumno.txtBoxApellido.Text = auxiliar.Apellido;
                    frmAlumno.txtBoxLegajo.Text = auxiliar.Legajo.ToString();
                    frmAlumno.comboBoxExamen.SelectedItem = auxiliar.Examen;
                    frmAlumno.txtBoxLegajo.Enabled = false;

                    frmAlumno.ShowDialog();

                    if (frmAlumno.DialogResult == DialogResult.OK)
                    {
                        this.catedra.Alumnos[this.listBox.SelectedIndex] = frmAlumno.GetAlumno;
                        this.ActualizarListadoAlumnos();
                    }
                }
                else
                    MessageBox.Show("Seleccione un alumno");

            }
            else
                MessageBox.Show("No hay alumnos ingresados");
        }

        private void ActualizarListadoAlumnosCalificados()
        {
            //LIMPIA E IMPRIME LA LISTA DE ALUMNOS
            this.ActualizarListadoAlumnos();

            //LIMPIA E IMPRIME LA LISTA DE ALUMNOS CALIFICADOS
            this.listBoxCalificados.Items.Clear();
            foreach (AlumnoCalificado auxiliar in listaAlumnosCalificados)
                this.listBoxCalificados.Items.Add(auxiliar.ToString());
        }
    }
}


