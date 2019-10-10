using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class consumo
    {
        private double kilometros;
        private double litros;
        private double velocidadMedia;
        private string tipoCombustible;
        private double precioCombustible;

        public consumo(double kilometros, double litros, double velocidadMedia, string tipoCombustible)
        {
            this.kilometros = kilometros;
            this.litros = litros;
            this.velocidadMedia = velocidadMedia;
            this.tipoCombustible = tipoCombustible.ToLower();
            switch (tipoCombustible)
            {
                case "gasolina95":
                    precioCombustible = 1.14;
                    break;
                case "gasolina98":
                    precioCombustible = 1.25;
                    break;
                case "diesel":
                    precioCombustible = 1.04;
                    break;
                default:
                    Console.WriteLine("No has introducido un combustible valido, se aplicará Diesel");
                    tipoCombustible = "diesel";
                    precioCombustible = 1.04;
                    break;
            }
        }
        public double GetTiempo()
        {
            return kilometros/velocidadMedia;
        }
        public double GetConsumo()
        {
            return (litros/kilometros)*100;
        }
        public double ConsumoEuros()
        {
            return GetConsumo()*precioCombustible;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Kilometros realizados: {kilometros}");
            Console.WriteLine($"Litros consumidos: {litros}");
            Console.WriteLine($"Velocidad media: {velocidadMedia}");
            Console.WriteLine($"Tipo de combustible: {tipoCombustible}");
        }
    }
}
