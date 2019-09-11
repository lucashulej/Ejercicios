using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return "\nColor: " + this.color + "\n Marca: " + this.marca + "\n Cantidad: " + this.cantidad;
        }
        
        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            if (Object.Equals(tempera1, null) == false && Object.Equals(tempera2, null) == false)
            {
                return (tempera1.color == tempera2.color && tempera1.marca == tempera2.marca);
            }
            else
                return false;
        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            tempera.cantidad = tempera.cantidad + cantidad;
            return tempera;
        }

        public static Tempera operator -(Tempera tempera, int cantidad)
        {
            tempera.cantidad = tempera.cantidad - cantidad;
            return tempera;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if(tempera1 == tempera2)
                tempera1 = tempera1 + tempera2.cantidad;

            return tempera1;
        }

        public static Tempera operator -(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
                tempera1 = tempera1 - tempera2.cantidad;

            if (tempera1.cantidad < 1)
                tempera1 = null;
            return tempera1;
        }

    }
}
