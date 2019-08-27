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
        byte notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 5)
            {
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

    }
}
