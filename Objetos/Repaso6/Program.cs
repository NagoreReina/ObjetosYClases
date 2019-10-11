using System;

namespace Repaso6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hipoteca valor = new Hipoteca(6000, 3.5, 20);
            Console.WriteLine($"Capital: {valor.Capital} \t Redito: {valor.Redito}");
            Console.WriteLine("TIEMPO \t CUOTA");

            for (int i = 10; i < 21; i++)
            {
                valor.Tiempo = i;
                Console.WriteLine($"{valor.Tiempo} \t {valor.Cuota()}");
            }
        }
    }
}
