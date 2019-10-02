using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    public class Local : Llamada
    {
        protected float _costo;

        public override float CostoLlamada
        {
            get
            {
                return  this._costo;
            }
        }

        #region CONSTRUCTORES

        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        #endregion

        #region METODOS

        private float CalcularCosto()
        {
            float costo;
            costo = this._costo * this._duracion;
            return costo;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        protected override string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();
            palabra.Append(base.Mostrar());
            palabra.Append(" ");
            palabra.Append("Costo: " + this._costo);
            return palabra.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
