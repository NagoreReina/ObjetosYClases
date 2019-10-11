using System;

namespace Repaso3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(1, 2, 3);
            triangulo.EsIsosceles();
            triangulo.EsEscaleno();
            triangulo.EsEquilatero();
            Console.WriteLine($"El perimetro es {triangulo.Perimetro()}");
        }
    }
}
