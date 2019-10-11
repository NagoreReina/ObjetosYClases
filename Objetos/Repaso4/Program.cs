using System;

namespace Repaso4
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarma prueba1 = new Alarma();
            Alarma prueba2 = new Alarma(59);

            prueba1.Comprueba();
            if (prueba1.Timbre)
            {
                prueba1.Normaliza();
            }
            prueba2.Comprueba();
            if (prueba2.Timbre)
            {
                prueba2.Normaliza();
            }
        }
    }
}
