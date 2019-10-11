using System;

namespace Repaso9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario u1 = new Usuario("Pablo", "Garcia", "942026484");
            //Console.WriteLine($"Cantabria: {u1.EsDeCantabria()}");
            //string email = u1.GeneraEmail();
            //Console.WriteLine($"email: {email}");
            //Console.WriteLine($"Letra A: {u1.ContieneLetra('a')}");
            //u1.Telefono = "955676767";
            //Console.WriteLine($"Cantabria: {u1.EsDeCantabria()}");

            Cliente c1 = new Cliente("Marcos", "Garcia", "944026484", "Sólo Línea Telefónica fija");
            Cliente c2 = new Cliente("Lucia", "Fernandez", "686460888", "Linea + Internet");
            Cliente c3 = new Cliente("Nagore", "Reina", "680692048", "Linea + Internet + linea móvil");
            Cliente c4 = new Cliente("Sergio", "Reina", "680693122", "Linea + Internet + linea móvil + televisión por cable");
            Cliente c5 = new Cliente("Begoña", "Gonzalez", "944587623", "Sólo Línea Telefónica fija");
            Cliente c6 = new Cliente("Juan José", "Reina", "606450887", "Linea + Internet + linea móvil");
            Cliente c7 = new Cliente("Begoña", "De La Maza", "646767609", "Linea + Internet + linea móvil");
            c1.GenerarOferta();
            c2.cambiarTipoDeContrato("Linea + Internet + linea móvil + televisión por cable");
            c2.GenerarOferta();
            c1.Estadisticas();

        }
    }
}
