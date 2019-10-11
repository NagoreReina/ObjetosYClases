using System;

namespace Repaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monedero cartera = new Monedero(1000);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Tu salgo actual es de {cartera.ConsultarDinero()}");
            cartera.MeterDinero(50);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tu salgo actual es de {cartera.ConsultarDinero()}");
            cartera.SacarDinero(947);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Tu salgo actual es de {cartera.ConsultarDinero()}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
