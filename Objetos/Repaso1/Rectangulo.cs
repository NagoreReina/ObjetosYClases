using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso1
{
    class Rectangulo
    {
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public Rectangulo(){}
        public Rectangulo(int largo, int ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
        public int Area()
        {
            return Largo * Ancho;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largo, 2) + Math.Pow(Ancho, 2));
        }
    }
}
