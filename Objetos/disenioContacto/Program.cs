using System;

namespace disenioContacto
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTACTO 1
            Contacto miren = new Contacto("Miren", 944123456, Convert.ToDateTime("4/2/1990"));
            CFecha mirenFecha = new CFecha(miren.FechaNacimiento);
            Contacto jon = new Contacto("Jon", 931212123);
            CFecha jonFecha = new CFecha(jon.FechaNacimiento);
            Contacto ane = new Contacto("Ane", "5/5/1995");
            CFecha aneFecha = new CFecha(ane.FechaNacimiento);
            Contacto julen = new Contacto("Julen", 944123321, Convert.ToDateTime("4/2/1992"));
            CFecha julenFecha = new CFecha(julen.FechaNacimiento);

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //miren.MostrarDatos();
            //Console.WriteLine($"{miren.Nombre} tiene {mirenFecha.ObtenerEdad()} años");
            //mirenFecha.felicitar();
            //Console.ForegroundColor = ConsoleColor.Green;
            //jon.MostrarDatos();
            //Console.WriteLine($"{jon.Nombre} tiene {jonFecha.ObtenerEdad()} años");
            //jonFecha.felicitar();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //ane.MostrarDatos();
            //Console.WriteLine($"{ane.Nombre} tiene {aneFecha.ObtenerEdad()} años");
            //aneFecha.felicitar();
            //Console.ForegroundColor = ConsoleColor.Red;
            //julen.MostrarDatos();
            //Console.WriteLine($"{julen.Nombre} tiene {julenFecha.ObtenerEdad()} años");
            //julenFecha.felicitar();

            //CONTACTO2
            Contacto2 miren2 = new Contacto2("Miren", 944123456, Convert.ToDateTime("4/2/1990"), "Amigos");
            Contacto2 jon2 = new Contacto2("Jon", 931212123, "Trabajo");
            Contacto2 ane2 = new Contacto2("Ane", "5/5/1995","Familia");
            Contacto2 julen2 = new Contacto2("Julen", 944123321, Convert.ToDateTime("4/2/1992"), "Estudios");
            Contacto2 jone = new Contacto2("Jone", "6/6/1992");
            Contacto2 mikel = new Contacto2("Mikel", "7/7/1997", "Familia");

            Console.ForegroundColor = ConsoleColor.Cyan;
            miren2.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.Green;
            jon2.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.Yellow;
            ane2.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.Red;
            julen2.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.Magenta;
            jone.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.Blue;
            mikel.MostrarDatos();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
