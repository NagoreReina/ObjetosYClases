using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {
        public int Caballos { get; set; }
        public int Puertas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Coche() { Marca = "Patata"; Modelo = "Chinco"; }
        public Coche(int caballos, int puertas) 
        { 
            Marca = "Patata"; 
            Modelo = "Chinco"; 
            Puertas = puertas; 
            Caballos = caballos; 
        }
        public void AllInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Caballos: {Caballos}");
            Console.WriteLine($"Puertas: {Puertas}");
        }
    }
}
