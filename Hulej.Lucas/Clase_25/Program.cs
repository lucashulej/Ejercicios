using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_25.Entidades;
using Entidades.Externa.Sellada;

namespace Clase_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona("lucas", "hulej", 42028318);
            PersonaExternaSellada personaSellada = new PersonaExternaSellada("nicolas", "hulej", 18, ESexo.Masculino);
            //Console.WriteLine(persona1.Nombre + " " + persona1.Apellido + " " + persona1.Dni);
            //Console.WriteLine(persona1.ObtenerDatos());
            //Console.WriteLine(Extenzora.ObtenerDatos(personaSellada));
            Console.WriteLine(personaSellada.ObtenerDatos());
          
            Console.ReadLine();
        }
    }
}
