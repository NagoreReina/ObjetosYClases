using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.-Realiza una clase Finanzas que convierta dólares a euros y viceversa. 
            //Codifica los métodos dolaresToEuros y eurosToDolares.

            Finanzas cambio = new Finanzas();
            Console.WriteLine($"{cambio.DolaresToEuros(1).ToString("0.00")} {cambio.EurosToDolares(1)}");
            Finanzas cambio2 = new Finanzas(0.8);
            Console.WriteLine($"{cambio2.DolaresToEuros(1).ToString("0.00")} {cambio2.EurosToDolares(1)}");
        }
    }
}
