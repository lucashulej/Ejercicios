using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        #region Constructores

        public Pluma()
        {
            this.marca = "Sin marca";
            //this.tinta = new Tinta();
        }

        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        #endregion

        private string Mostrar()
        {
            return "Marca: " + this.marca + "\nTinta: " + Tinta.Mostrar(this.tinta) + "\nCantidad: " + this.cantidad;
        }

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return (pluma.tinta == tinta);
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma.tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma.tinta == tinta && pluma.cantidad <= 100)
                pluma.cantidad++;

            return pluma;
        }
    }
}
