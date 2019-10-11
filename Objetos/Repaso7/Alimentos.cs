using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso7
{
    class Alimentos
    {
        public string Nombre { get; set; }
        public int Grasas { get; set; }
        public int Hidratos { get; set; }
        public bool OrigenAnimal { get; set; }

        public Alimentos(string nombre, int grasas, int hidratos, bool origenAnimal)
        {
            Nombre = nombre;
            Grasas = grasas;
            Hidratos = hidratos;
            OrigenAnimal = origenAnimal;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Grasas: {Grasas}");
            Console.WriteLine($"Hidratos: {Hidratos}");
            Console.WriteLine($"Origen Animal: {OrigenAnimal}");
        }
        public bool EsDietetico()
        {
            if (Grasas < 12 && OrigenAnimal == false)
            {
                return true;
            }
            return false;
        }
        public string ClaveA()
        {
            string tempName = Nombre.Substring(0,3);
            return (tempName + Grasas.ToString()).ToUpper();
        }
        public double Calorias(double gramos)
        {
            return gramos * (Grasas * 5.3 + Hidratos * 2.1);

        }
    }
}
