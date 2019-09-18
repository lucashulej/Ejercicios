using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Alumno
    {
        protected string nombre;
        protected string apellido;
        protected int legajo;
        protected ETipoExamen examen;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
        }

        public ETipoExamen Examen
        {
            get
            {
                return this.examen;
            }
        }

        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        public static string Mostrar(Alumno a)
        {
            string retorno;
            retorno = a.nombre + " " + a.apellido + " " + a.legajo + " " + a.examen;
            return retorno;
        }

        public static bool operator ==(Alumno a, Alumno b)
        {
            bool retorno = false;
            if (Object.Equals(a, null) == false && Object.Equals(b, null) == false)
            {
                if (a.legajo == b.legajo)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.legajo.ToString(), b.legajo.ToString());
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a, b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * Alumno.OrdenarPorApellidoAsc(a, b);
        }

    }
}
