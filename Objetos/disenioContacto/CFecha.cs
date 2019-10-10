using System;
using System.Collections.Generic;
using System.Text;

namespace disenioContacto
{
    class CFecha
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }

        public CFecha(DateTime fecha)
        {
            Dia = fecha.Day;
            Mes = fecha.Month;
            Anio = fecha.Year;
        }

        public int ObtenerEdad()
        {
            return DateTime.Now.Year-Anio;
        }
        public void felicitar()
        {
            Console.WriteLine($"Felicidades por cumplir {ObtenerEdad()}");
        }
    }
}
