using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central.Entidades
{
    public class Centralita
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
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;
            foreach (Llamada auxiliar in _listaDeLlamadas)
            {
                if(auxiliar is Local)
                {
                    gananciaLocal = gananciaLocal + auxiliar.CostoLlamada;
                }
                else
                {
                    gananciaProvincial = gananciaProvincial + auxiliar.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLLamada.Local:
                    retorno = gananciaLocal;
                    break;

                case TipoLLamada.Provincial:
                    retorno = GananciaPorProvincial;
                    break;

                case TipoLLamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
            }

            return retorno;
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
                //Console.WriteLine("ERROR");
            }
            return central;
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
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
