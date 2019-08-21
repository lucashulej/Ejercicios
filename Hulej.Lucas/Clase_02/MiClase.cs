using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
namespace Clase_02
{
    public class MiClase // POR DEFECTO ESTA EN PRIVATE (-) -> priavte (+) -> public
    {
        public static string nombre;
        public static int edad;

        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }

        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
        }

        public static bool CompararNombre(string nombre)
        {
            bool retorno = false;
            if (MiClase.nombre == nombre)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
