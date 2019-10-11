using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso10
{
    class Rectangulo
    {
        public int Largo { get; set; }
        public int Ancho { get; set; }

        public Rectangulo(int largo, int ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public Rectangulo()
        {
            do
            {
                int temp = 0;
                Console.WriteLine("Introduce el largo");
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    Largo = temp;
                    Console.WriteLine("Introduce el ancho");
                    if (int.TryParse(Console.ReadLine(), out temp))
                    {
                        Ancho = temp;
                    }
                    else
                    {
                        Console.WriteLine("Dato incorrecto, introduce un numero valido");
                    }

                }
                else
                {
                    Console.WriteLine("Dato incorrecto, introduce un numero valido");
                }
            } while (Largo == 0 && Ancho == 0);
        }
        public bool EsAlargado()
        {
            if (Largo >= Ancho*2)
            {
                return true;
            }
            return false;
        }
        public void Dibuja()
        {
            string text = "";
            for (int i = 0; i < Ancho; i++)
            {
                for (int j = 0; j < Largo; j++)
                {
                    text += "*";
                }
                Console.WriteLine(text);
                text = "";
            }
        }
    }
}
