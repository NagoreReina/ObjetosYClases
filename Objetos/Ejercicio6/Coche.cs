using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {
        private int caballos;
        private int puertas;
        private string marca;
        private string modelo;
        public Coche() { marca = "Patata"; modelo = "Chinco"; }
        public Coche(int caballos, int puertas) 
        { 
            marca = "Patata"; 
            modelo = "Chinco"; 
            this.puertas = puertas; 
            this.caballos = caballos; 
        }
        public string GetMarca(){return marca;}
        public string GetModelo(){return modelo;}
        public int GetPuertas(){return puertas;}
        public int GetCaballos(){return caballos;}
        public void SetMarca(string m) {marca = m;}
        public void SetModelo(string m) {modelo = m;}
        public void SetPuertas(int p) {puertas = p;}
        public void SetCaballos(int c) {puertas = c;}
        public void AllInfo()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Caballos: {caballos}");
            Console.WriteLine($"Puertas: {puertas}");
        }
    }
}
