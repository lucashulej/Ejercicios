using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class AlumnoCalificado : Alumno
    {
        protected double nota;

        public AlumnoCalificado(Alumno a, double nota) : this(a.Nombre, a.Apellido, a.Legajo, a.Examen, nota)
        {
            
        }

        public AlumnoCalificado(string nombre, string apellido, int legajo, ETipoExamen examen, double nota) : base(nombre, apellido, legajo, examen)
        {
            this.nota = nota;
        }

        public double Nota
        {
            get
            {
                return this.nota;
            }
        }

        public string Mostrar()
        {
            return Alumno.Mostrar(this) + " " + this.nota;
        }

        public override string ToString()
        {
            return this.Mostrar();

        }
    }
}
