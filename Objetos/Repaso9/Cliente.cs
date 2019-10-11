using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso9
{
    class Cliente
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String TipoContrato { get; set; }

        public static int tipoC1;
        public static int tipoC2;
        public static int tipoC3;
        public static int tipoC4;

        public Cliente(string nombre, string apellido, string telefono, string tipoContrato)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            TipoContrato = tipoContrato;
            switch (TipoContrato)
            {
                case "Sólo Línea Telefónica fija":
                    tipoC1++;
                    break;
                case "Linea + Internet":
                    tipoC2++;
                    break;
                case "Linea + Internet + linea móvil":
                    tipoC3++;
                    break;
                case "Linea + Internet + linea móvil + televisión por cable":
                    tipoC4++;
                    break;
            }
            /*
             Sólo Línea Telefónica fija
             Linea + Internet
             Linea + Internet + linea móvil
             Linea + Internet + linea móvil + televisión por cable
            */
        }
        public bool EsDeCantabria()
        {
            if (Telefono.Substring(0, 3) == "942")
            {
                return true;
            }
            return false;
        }
        public string GeneraEmail()
        {
            return $" {Nombre}-{Apellido}{Telefono.Substring(Telefono.Length - 1, 1)}@javamail.com";
        }
        public string ContieneLetra(char letra)
        {
            int tempCont = 0;
            for (int i = 0; i < Apellido.Length; i++)
            {
                if (Apellido[i] == letra)
                {
                    tempCont++;
                }
            }
            return $"{letra}{tempCont}";
        }
        public double PrecioContrato()
        {
            switch (TipoContrato)
            {
                case "Sólo Línea Telefónica fija":
                    return 12;
                case "Linea + Internet":
                    return 22;
                case "Linea + Internet + linea móvil":
                    return 30;
                case "Linea + Internet + linea móvil + televisión por cable":
                    return 38;
                default:
                    return 0;
            }
        }
        public void DatosCliente()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Tipo de contrato: {TipoContrato}");
        }
        public void GenerarOferta()
        {
            string tempContr = "";
            bool ofertaMaxima = false;
            switch (TipoContrato)
            {
                case "Sólo Línea Telefónica fija":
                    tempContr = "Linea + Internet";
                    break;
                case "Linea + Internet":
                    tempContr = "Linea + Internet + linea móvil";
                    break;
                case "Linea + Internet + linea móvil":
                    tempContr = "Linea + Internet + linea móvil + televisión por cable";
                    break;
                case "Linea + Internet + linea móvil + televisión por cable":
                    tempContr = "Oferta super especial Ninja Secreta";
                    ofertaMaxima = true;
                    Console.WriteLine("No hay oferta disponible en este momento");
                    break;
            }
            if (!ofertaMaxima)
            {
                DatosCliente();
                Console.WriteLine("\n");
                Console.WriteLine($"Mensaje para: {GeneraEmail()}");
                Console.WriteLine("\n");
                Console.WriteLine($"*************** Oferta especial para {Nombre} {Apellido} ****************");
                string antContrato = TipoContrato;
                TipoContrato = tempContr;
                Console.WriteLine($"Si cambias a {tempContr}");
                double nuevoPrecio = PrecioContrato() - (0.2 * PrecioContrato());
                Console.WriteLine($"Obtendras un descuento único {PrecioContrato()} - 20% = {nuevoPrecio} euros el primer año");
                Console.WriteLine("**********************************************************************");
                TipoContrato = antContrato;
            }
        }
        public void cambiarTipoDeContrato(string nuevaTarifa)
        {
            TipoContrato = nuevaTarifa;
        }
        public void Estadisticas()
        {
            Console.WriteLine($"'Sólo Línea Telefónica fija' tiene {tipoC1} clientes");
            Console.WriteLine($"'Linea + Internet' tiene {tipoC2} clientes");
            Console.WriteLine($"'Linea + Internet + linea móvil' tiene {tipoC3} clientes");
            Console.WriteLine($"'Linea + Internet + linea móvil + televisión por cable' tiene {tipoC4} clientes");
        }
    }
}
