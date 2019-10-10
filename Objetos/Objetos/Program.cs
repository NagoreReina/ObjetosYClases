using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Patata","Bonita","azul",166,9);
            coche.SetMarca("patatonia");
            Console.WriteLine(coche.GetMarca());
            coche.Arrancar();
        }
    }
}
