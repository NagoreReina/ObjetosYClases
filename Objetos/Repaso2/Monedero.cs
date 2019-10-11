using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso2
{
    class Monedero
    {
        private double dinero;

        public Monedero (double dinero)
        {
            this.dinero = dinero;
        }
        public void SacarDinero(double dinero)
        {
            if (this.dinero - dinero < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se pudo sacar dinero, no tienes tanto");
            }
            else
            {
                this.dinero -= dinero;
            }

        }
        public void MeterDinero (double dinero)
        {
            if (dinero < 0)
            {
                Console.WriteLine("No se pueden introducir numeros negativos");
            }
            else
            {
                this.dinero += dinero;
            }
        }
        public double ConsultarDinero()
        {
            return dinero;
        }
    }
}
