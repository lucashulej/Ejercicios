using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color,short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            int porcentaje;
            porcentaje = ((this.tinta - gasto) * 100) / this.tinta;
            porcentaje = 100 - porcentaje;
            porcentaje = porcentaje / 10;

            if(this.tinta - gasto > 0)
            {
                retorno = true;
                for (int i = 0; i < porcentaje; i++)
                {
                    dibujo = dibujo + '*';
                }
                SetTinta((short)gasto);
            }
            return retorno;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if (this.tinta < 0)
                this.tinta = 0;

            if (this.tinta > cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
        }
    }
}
