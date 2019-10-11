using System;

namespace Repaso1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo(5, 7);
            Console.WriteLine($"El area del rectangulo es {rect.Area()} y su diagonal es {rect.Diagonal()}");
        }
    }
}
