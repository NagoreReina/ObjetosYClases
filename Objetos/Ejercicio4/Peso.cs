using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Peso
    {
        private double peso;
        private string unidad;
        public Peso(double peso, string unidad)
        {
            this.peso = peso;
            if (unidad == "lb" || unidad == "li" || unidad == "oz" || unidad == "p" || unidad == "k" || unidad == "g" || unidad == "q")
            {
                this.unidad = unidad;
            }
            else
            {
                Console.WriteLine("La unidad introducida no es correcta, por defecto se aplica K");
                this.unidad = "k";
            }
            double valueInKg = 0;
            switch (unidad)
            {
                /*
                1 Libra = 16 onzas = 453 gramos.
                1 Lingote = 32,17 libras = 14,59 kg.
                1 Onza = 0,0625 libras = 28,35 gramos.
                1 Penique = 0,05 onzas = 1,55 gramos.
                1 Quintal = 100 libras = 43,3 kg.
                */
                case "lb":
                    valueInKg = peso / 0.453;
                    break;
                case "li":
                    valueInKg = peso * 14.59;
                    break;
                case "oz":
                    valueInKg = peso * 0.02835;
                    break;
                case "p":
                    valueInKg = peso * 0.00155;
                    break;
                case "k":
                    valueInKg = peso;
                    break;
                case "g":
                    valueInKg = peso * 0.001;
                    break;
                case "q":
                    valueInKg = peso * 43.3;
                    break;
            }
            peso = valueInKg;
        }
        public double GetLibras()
        {
            peso = peso * 0.453;
            return peso;
        }
        public double GetLingotes()
        {
            peso = peso / 14.59;
            return peso;
        }
        public double GetPeso(string unidad)
        {
            switch (unidad)
            {

                case "lb":
                    peso = peso * 0.453;
                    break;
                case "li":
                    peso = peso / 14.59;
                    break;
                case "oz":
                    peso = peso / 0.02835;
                    break;
                case "p":
                    peso = peso / 0.00155;
                    break;
                case "k":
                    break;
                case "g":
                    peso = peso / 0.001;
                    break;
                case "q":
                    peso = peso / 43.3;
                    break;
                default:
                    Console.WriteLine("Unidad Incorrecta");
                    break;
            }
            return peso;
        }

    }
}
