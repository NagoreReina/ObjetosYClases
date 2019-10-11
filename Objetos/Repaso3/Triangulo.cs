using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso3
{
    class Triangulo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }
        public Triangulo(int lado1, int lado2, int lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }
        public bool EsIsosceles()
        {
            if (!EsEquilatero())
            {
                if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1)
                {
                    return true;
                }
            }
            return false;
        }
        public bool EsEquilatero()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return true;
            }
            return false;
        }
        public bool EsEscaleno()
        {
            if (!EsEquilatero() && !EsIsosceles())
            {
                return true;
            }
            return false;
        }
        public int Perimetro()
        {
            return Lado1+Lado2+Lado3;
        }
    }
}
