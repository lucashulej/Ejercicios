using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 5)
            {
                Random elemento = new Random();
                this.notaFinal = elemento.Next(1,10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            if(notaFinal != -1)
            {
                return "El alumno se llama " + this.nombre + " " + this.apellido + " su legajo es " + this.legajo + ". NOTA 1 = " + this.nota1 + " NOTA 2 = " + this.nota2 + " NOTA FINAL " + this.notaFinal;
            }
            else
            {
                return "El alumno se llama " + this.nombre + " " + this.apellido + " su legajo es " + this.legajo + ". NOTA 1 = " + this.nota1 + " NOTA 2 = " + this.nota2 + " ALumno desaporbado";
            }
            
        }

    }
}
