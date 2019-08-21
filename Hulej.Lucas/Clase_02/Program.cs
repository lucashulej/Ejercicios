using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string palabra;
            bool boolean = false;
            Console.Title = "Clase_02";

            // inicializo los atributos
            MiClase.nombre = "Lucas";
            MiClase.edad = 20;

            palabra = MiClase.RetornarNombre();
            Console.WriteLine(palabra);
            MiClase.MostrarEdad();

            boolean = MiClase.CompararNombre("Nicolas");
            Console.WriteLine(boolean);
            boolean = MiClase.CompararNombre("Lucas");
            Console.WriteLine(boolean);
            Console.WriteLine(MiLibreria.MiClase.RetornarNombre());
            */
            string mensaje;
          
            Sello.mensaje = "Hola Mundo";
            mensaje = Sello.imprimir();
            Console.WriteLine(mensaje);
            Sello.borrar();
            mensaje = Sello.imprimir();
            Console.WriteLine(mensaje);

            Sello.mensaje = "Hola";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirColor();
            Sello.mensaje = "Hola";
            Sello.ImprimirColor();

            Console.ReadLine();
        }
    }
}
