using System;

namespace Repaso10
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo();
            Rectangulo r2 = new Rectangulo(12, 5);
            Console.WriteLine($"Es alargado = {r2.EsAlargado()}");
            r1.Dibuja();
            Console.WriteLine("\n");
            r2.Dibuja();
        }
    }
}
