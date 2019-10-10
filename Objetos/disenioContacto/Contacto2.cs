using System;
using System.Collections.Generic;
using System.Text;

namespace disenioContacto
{
    class Contacto2
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Tipo { get; set; }

        public Contacto2(string nombre, int numero, DateTime fechaNacimiento, string tipo)
        { Nombre = nombre; Numero = numero; FechaNacimiento = fechaNacimiento; Tipo = tipo; }
        public Contacto2(string nombre, string fechaNacimiento, string tipo)
        {
            Nombre = nombre;
            DateTime tempData = DateTime.Now;
            DateTime.TryParse(fechaNacimiento, out tempData);
            FechaNacimiento = tempData;
            Tipo = tipo;

        }
        public Contacto2(string nombre, string fechaNacimiento)
        {
            Nombre = nombre;
            DateTime tempData = DateTime.Now;
            DateTime.TryParse(fechaNacimiento, out tempData);
            FechaNacimiento = tempData;
            Tipo = "Amigos";

        }
        public Contacto2(string nombre, int numero, string tipo)
        { Nombre = nombre; Numero = numero; FechaNacimiento = DateTime.Now; Tipo = tipo; }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Telefono: {Numero}");
            Console.WriteLine($"Fecha Nacimiento: {FechaNacimiento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Tipo: {Tipo}");
        }
    }
}
