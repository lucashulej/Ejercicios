using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #region CONSTRUCTORES

        public Provincial(Franja miFranja, Llamada unaLlamada) : this (unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        #endregion

        #region METODOS

        private float CalcularCosto()
        {
            float costo = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this._duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = this._duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = this._duracion * 0.66f;
                    break;
            }
            return costo;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();
            palabra.Append(base.Mostrar());
            palabra.Append(" ");
            palabra.Append("Franja Horaria: " + this._franjaHoraria);
            palabra.Append(" ");
            palabra.Append(this.CalcularCosto());
            return palabra.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
 
        #endregion

    }
}
