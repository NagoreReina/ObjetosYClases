using System;

namespace Repaso8
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta jugador1 = new Carta();
            Carta jugador2 = new Carta();
            if (jugador1.Numero > jugador2.Numero)
            {
                Console.WriteLine("- Gana jugador 1 -");
                Console.WriteLine("Carta de jugador 1");
                jugador1.Mostrar();
                Console.WriteLine("Carta de jugador 2");
                jugador2.Mostrar();
            }
            else if (jugador1.Numero < jugador2.Numero)
            {
                Console.WriteLine("- Gana jugador 2 -");
                Console.WriteLine("Carta de jugador 1");
                jugador1.Mostrar();
                Console.WriteLine("Carta de jugador 2");
                jugador2.Mostrar();
            }
            else
            {
                Console.WriteLine("- Empate -");
                Console.WriteLine("Carta de jugador 1");
                jugador1.Mostrar();
                Console.WriteLine("Carta de jugador 2");
                jugador2.Mostrar();
            }

        }
    }
}
