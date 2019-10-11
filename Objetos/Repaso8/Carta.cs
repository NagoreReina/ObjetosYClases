using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso8
{
    class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public Carta()
        {
            Random random = new Random();
            Numero = random.Next(1, 11);
            int temp = random.Next(1, 5);
            switch (temp)
            {
                case 1:
                    Palo = "Copas";
                    break;
                case 2:
                    Palo = "Espadas";
                    break;
                case 3:
                    Palo = "Bastos";
                    break;
                case 4:
                    Palo = "Oros";
                    break;
            }
        }
        public void Mostrar()
        {
            Console.WriteLine($"{Numero} de {Palo}");
        }
    }
}
