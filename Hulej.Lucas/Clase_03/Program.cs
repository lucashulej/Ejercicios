using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersona = new Persona("PAPITO","DOOM",42028318);
            Persona miPersona2 = new Persona("LUCAS", "HULEJ",23022123);
            Persona miPersona3 = new Persona();
            Console.WriteLine(miPersona.Mostrar());
            Console.WriteLine(miPersona2.Mostrar());
            Console.WriteLine(miPersona3.Mostrar());

            Console.ReadLine();

           
        }
    }
}
