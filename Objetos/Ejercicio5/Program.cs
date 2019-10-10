using System;

namespace Ejercicio5
{
    class Program
    {
        /*Crea una clase con un método MillasAMetros() que toma como parámetro de entrada un valor en millas marinas 
         y las convierte a metros.
         Una vez tengas este método escribe otro MillasAKilometros() que realice la misma conversión, 
         pero esta vez exprese el resultado en kilómetros.
         Nota: 1 milla marina equivale a 1852 metros.

         */
        static void Main(string[] args)
        {
            Conversor num = new Conversor();
            num.MillasAKilometros();
            Console.WriteLine(num.GetUnidad());
            num.MillasAMetros();
            Console.WriteLine(num.GetUnidad());
        }
    }
}
