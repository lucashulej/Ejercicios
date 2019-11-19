using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Clase_25.Entidades
{
    public static class Extenzora
    {
        public static string ObtenerDatos(this PersonaExternaSellada persona)
        {
            string retorno = "";
            retorno = persona.Nombre + "-" + persona.Apellido + "-" + persona.Edad + "-" + persona.Sexo;
            return retorno;
        }

        public static bool esNulo(this Object objeto)
        {
            bool retorno = false;
            if(objeto == null)
            {
                retorno = true;
            } 
            return retorno;
        }

        public static List<Persona> ObtenerListadoBD(this List<Persona> lista)
        {

        }
    }
}
