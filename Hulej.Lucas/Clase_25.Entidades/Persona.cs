using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_25.Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string ObtenerDatos()
        {
            string retorno = "";
            retorno = this.nombre + " " + this.apellido + " " + this.dni;
            return retorno;
        }
    }
}
