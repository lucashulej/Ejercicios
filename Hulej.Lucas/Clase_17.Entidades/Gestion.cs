using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17.Entidades
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAFIP bienPinuble)
        {
            return bienPinuble.CalcularImpuesto();
        }
        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            return bienPunible.CobrarImpuesto();
        }
    }
}
