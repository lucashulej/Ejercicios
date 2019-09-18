using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color = ConsoleColor.Gray;

        public static string imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirColor()
        {
            Console.ForegroundColor = color;

            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Sello.color = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            int aux= Sello.mensaje.Length+2;
            string auxiliar = "";
            for(int i=0;i<aux;i++)
            {
                auxiliar = auxiliar + "*";
            }
            Sello.mensaje = auxiliar + "\n*" + Sello.mensaje + "*\n" + auxiliar;
            return Sello.mensaje;
        }
    }
}
