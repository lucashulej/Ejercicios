using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    abstract public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrginen;

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrginen;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrginen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder palabra = new StringBuilder();
            palabra.Append(this._nroOrginen);
            palabra.Append(" ");
            palabra.Append(this._nroDestino);
            palabra.Append(" ");
            palabra.Append(this._duracion);
            return palabra.ToString();
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            bool retorno = false;
            if (object.Equals(uno, null) == false && object.Equals(dos, null) == false)
            {

            }
            return retorno;
        }

        public static bool operator !=(Llamada uno,Llamada dos)
        {
            return !(uno==dos);
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return 1;
        }




    }
}
