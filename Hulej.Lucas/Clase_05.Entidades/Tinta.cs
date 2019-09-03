using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        #region Constructores

        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        #endregion

        private string Mostrar()
        {
            return "Color: " + this.color.ToString() + ", Tipo: " + this.tipo.ToString();
        }

        public static string Mostrar(Tinta ver)
        {
            return ver.Mostrar();
        }

        public static bool operator ==(Tinta primerElemento, Tinta segundoElemento)
        {
            bool retorno = false;

            if (!Object.Equals(primerElemento, null) && !Object.Equals(segundoElemento, null))
            {
                return (primerElemento.color == segundoElemento.color && primerElemento.tipo == segundoElemento.tipo);
            }

            return retorno;
        }

        public static bool operator !=(Tinta primerElemento, Tinta segundoElemento)
        {
            return !(primerElemento == segundoElemento);
        }

        public static bool operator ==(Tinta elemento, ConsoleColor color)
        {
            bool retorno = false;

            if (!Object.Equals(elemento, null) && !Object.Equals(color, null))
            {
                return (elemento.color == color);
            }

            return retorno;
        }

        public static bool operator !=(Tinta elemento, ConsoleColor color)
        {
            return !(elemento == color);
        }

        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
}
