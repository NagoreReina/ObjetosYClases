using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso6
{
    class Hipoteca
    {
        public double Capital { get; set; }
        public double Redito { get; set; }
        public double Tiempo { get; set; }

        public Hipoteca(double capital, double redito, double tiempo)
        {
            Capital = capital;
            Redito = redito;
            Tiempo = tiempo;
        }
        public double Cuota()
        {
            return Capital * Redito * Tiempo / 100;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"Redito: {Redito}");
            Console.WriteLine($"Tiempo: {Tiempo}");
        }
    }
}
