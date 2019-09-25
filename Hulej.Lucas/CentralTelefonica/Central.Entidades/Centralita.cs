using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas = new List<Llamada>();
        protected string _razonSocial;

        #region PROPIEDADES

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        #endregion

        #region CONSTRUCTORES

        public Centralita() : this("")
        {

        }

        public Centralita(string nombreEmpresa)
        {
            this._razonSocial = nombreEmpresa;
        }

        #endregion

        #region METODOS

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if (Object.Equals(nuevaLlamada, null) == false)
                this._listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLLamada tipo)
        {
            Local localAux = null;
            Provincial provAux = null;
            float ganancia = 0;
            switch(tipo)
            {
                case TipoLLamada.Local:
                    foreach(Llamada auxiliar in _listaDeLlamadas)
                    {
                        if(localAux.Equals(auxiliar))
                        {
                            ganancia = ganancia + auxiliar.CostoLlamada;
                        }
                    }
                    break;

                case TipoLLamada.Provincial:
                    foreach (Llamada auxiliar in _listaDeLlamadas)
                    {
                        if (provAux.Equals(auxiliar))
                        {
                            ganancia = ganancia + auxiliar.CostoLlamada;
                        }
                    }
                    break;

                case TipoLLamada.Todas:
                    foreach (Llamada auxiliar in _listaDeLlamadas)
                    {
                        ganancia = ganancia + auxiliar.CostoLlamada;
                    }
                    break;
            }
            return ganancia;
        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool retorno = false;
            foreach(Llamada auxiliar in central.Llamadas)
            {
                if(auxiliar == nuevaLlamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            return central;

        }

        public void OrdenarLlamadas()
        {
            Llamada auxiliar = null;
            this._listaDeLlamadas.Sort(auxiliar.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            StringBuilder palabra = new StringBuilder();
            foreach(Llamada auxiliar in this._listaDeLlamadas)
            {
                palabra.Append(auxiliar.ToString());
                palabra.AppendLine();
            }
            return palabra.ToString();
        }

        #endregion
    }
}
