using System;

namespace Repaso7
{
    class Program
    {
        static void Main(string[] args)
        {
            Alimentos alimento1 = new Alimentos("Patata", 1, 17, false);
            alimento1.MostrarDatos();
            Console.WriteLine($"Clave: {alimento1.ClaveA()}, Es dietetico: {alimento1.EsDietetico()}, las calorias son: {alimento1.Calorias(100)}");
        }
    }
}
