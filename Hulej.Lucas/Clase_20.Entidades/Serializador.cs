using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public static class Serializador
    {
        static bool Serializar(IXML interfaz)
        {
            interfaz.Guardar(AppDomain.CurrentDomain.BaseDirectory + @"SERIALIZADOR.xml");
            return true;
        }

        static bool Deserializar(IXML interfaz, out object obj)
        {
            interfaz.Leer(AppDomain.CurrentDomain.BaseDirectory + @"SERIALIZADOR.xml", out obj);
            return true;
        }
    }
}
