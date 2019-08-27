using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Persona
    {
        public string nombre = "";
        public string apellido = "";
        public int dni = 0;

        public Persona()
        {
            
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Mostrar()
        {
            return "La persona se llama " + this.nombre + " " + this.apellido + " y el dni es " + this.dni;
        }

    }
}
