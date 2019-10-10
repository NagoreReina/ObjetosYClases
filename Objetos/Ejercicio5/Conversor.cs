using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class Conversor
    {
        private double unidad;

        public Conversor() { unidad = 1; }

        public void MillasAMetros()
        {
            unidad *= 1852;
        }
        public void MillasAKilometros()
        {
            unidad *= 1.852;
        }
        public double GetUnidad()
        {
            return unidad;
        }
    }
}
