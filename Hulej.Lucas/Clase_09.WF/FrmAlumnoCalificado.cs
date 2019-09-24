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
        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            Alumno auxiliar = this.GetAlumno;
            this.txtBoxNombre.Text = auxiliar.Nombre;
        }
    }
}
