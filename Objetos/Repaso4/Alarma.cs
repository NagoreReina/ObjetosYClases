using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso4
{
    class Alarma
    {
        public double Temperatura { get; set; }
        public bool Timbre { get; set; }

        public Alarma(double temperatua)
        {
            Temperatura = temperatua;
            Timbre = false;
        }

        public Alarma()
        {
            Console.WriteLine("Introduce la temperatura");
            double tempTemp = 0;
            if (double.TryParse(Console.ReadLine(), out tempTemp))
            {
                Temperatura = tempTemp;
            }
            else
            {
                Console.WriteLine("Valor incorrecto");
            }
            Timbre = false;
        }
        public void Comprueba()
        {
            if (Temperatura >35 || Temperatura < 10)
            {
                Timbre = true;
            }
        }
        public void Normaliza()
        {
            Temperatura = 25;
            Timbre = false;
        }
    }
}
