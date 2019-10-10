using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Finanzas
    {
        private double dolarEuro;

        public Finanzas()
        {
            this.dolarEuro = 0.92;
        }
        public Finanzas(double dolarEuro)
        {
            this.dolarEuro = dolarEuro;
        }
        public double DolaresToEuros(double dolares)
        {
            return dolares / dolarEuro;
        }
        public double EurosToDolares(double euros)
        {
            return euros * dolarEuro;
        }
    }
}
