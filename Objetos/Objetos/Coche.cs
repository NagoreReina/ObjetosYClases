using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Coche
    {
        private string marca;
        private string modelo;
        private string color;
        private int caballos;
        private int puertas;

        //Constructor - construye el objeto ya especifico
        public Coche(string marca, string modelo, string color, int caballos, int puertas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.caballos = caballos;
            this.puertas = puertas;
        }
        //Getter
        public string GetMarca()
        {
            return marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetCaballos()
        {
            return caballos;
        }
        public int GetPuertas()
        {
            return puertas;
        }

        //Setter
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetCaballos(int caballos)
        {
            this.caballos = caballos;
        }
        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }

        //Metodos
        public void Arrancar()
        {
            Console.WriteLine($"El {marca} {modelo} ha arrancado. Brum Brum");
        }
    }
}
