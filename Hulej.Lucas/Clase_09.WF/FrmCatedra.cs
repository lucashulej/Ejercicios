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
        public List<Alumno> listaAlumnosCalificados = new List<Alumno>();

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
                    printSortedList();
                }
                else
                {
                    MessageBox.Show("El legajo no es valido");
                }

            }

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            printSortedList();
        }

        private void printSortedList()
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
                this.listBox.Items.Add(auxiliar.ToString()); //
            }
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            if (this.catedra.Alumnos.Count > 0)
            {
                if(this.listBox.SelectedIndex >= 0)
                {
                    FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado();
                    frmCalificado.ShowDialog();

                    //Alumno auxiliar = this.catedra.Alumnos[this.listBox.SelectedIndex];

                    //this.catedra.Alumnos.Remove(auxiliar);
                    //this.listaAlumnosCalificados.Add(auxiliar);

                    //printSortedList(); //BORRA LA LISTBOX Y LA VUELVE A IMPRIMIR

                    //this.listBoxCalificados.Items.Add(auxiliar.ToString()); //
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
                    Alumno alumno;
                    bool existeLegajo = false;
                    int index = 0;

                    index = this.listBox.SelectedIndex;
                    frmAlumno.ShowDialog();

                    if (frmAlumno.DialogResult == DialogResult.OK)
                    {
                        alumno = frmAlumno.GetAlumno;
                        foreach (Alumno auxiliar in catedra.Alumnos)
                        {
                            if (auxiliar.Legajo == alumno.Legajo)
                            {
                                if (auxiliar.Legajo == catedra.Alumnos[index].Legajo)
                                    continue;

                                existeLegajo = true;
                                break;
                            }
                        }

                        if (existeLegajo == false)
                        {
                            catedra.Alumnos.RemoveAt(index);
                            catedra.Alumnos.Add(alumno);
                            printSortedList();
                        }
                        else
                        {
                            MessageBox.Show("El legajo no es valido");
                        }
                    }
                }
                else
                    MessageBox.Show("Seleccione un alumno");

            }
            else
                MessageBox.Show("No hay alumnos ingresados");
        }
    }
      
}
