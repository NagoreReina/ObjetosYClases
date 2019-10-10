using System;
using System.Collections.Generic;
using System.Text;

namespace disenioContacto
{
    class Contacto
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Contacto(string nombre, int numero, DateTime fechaNacimiento) 
        { Nombre = nombre; Numero = numero; FechaNacimiento = fechaNacimiento; }
        public Contacto(string nombre, string fechaNacimiento)
        { 
            Nombre = nombre;
            DateTime tempData = DateTime.Now;
            DateTime.TryParse(fechaNacimiento, out tempData);
            FechaNacimiento = tempData;

        }
        public Contacto(string nombre, int numero)
        { Nombre = nombre; Numero = numero; FechaNacimiento = DateTime.Now; }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Telefono: {Numero}");
            Console.WriteLine($"Fecha Nacimiento: {FechaNacimiento.ToString("dd/MM/yyyy")}");
        }

    }
}
