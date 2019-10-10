using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realiza una clase número que almacene un número entero y tenga las siguientes características:
                  - Constructor por defecto que inicializa a 0 el número interno.
                  - Constructor que inicializa el número interno (pasado por parámetro).
                  - Método Aniade que permite sumarle un número al valor interno(++).
                  - Método Resta que resta un número al valor interno(--).
                  - Método GetValor. Devuelve el valor interno.
                  - Método GetDoble. Devuelve el doble del valor interno.
                  - Método GetTriple. Devuelve el triple del valor interno.
                  - Método SetNumero. Inicializa de nuevo el valor interno.
             */
            numero valor = new numero();
            numero valor2 = new numero(2);

            Console.WriteLine($"valor suma siendo 0 se queda en {valor.Aniade()}");
            Console.WriteLine($"valor resta siendo 0 se queda en {valor.Resta()}");
            Console.WriteLine($"valor es {valor.GetValor()}");
            Console.WriteLine($"el doble de valor2 es {valor2.GetDoble()}");
            Console.WriteLine($"el triple de valor2 es {valor2.GetTriple()}");
            valor.SetNumero(5);
            Console.WriteLine($"valor es ahora {valor.GetValor()}");


        }
    }
}
