using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso9
{
    class Usuario
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }

        public Usuario(string nombre, string apellido, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }
        public bool EsDeCantabria()
        {
            if (Telefono.Substring(0,3) == "942")
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


    }
}
