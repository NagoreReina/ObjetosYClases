using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class numero
    {
        private int valor;
        public numero(){}
        public int GetValor()
        {
            return valor;
        }
        public void SetNumero(int num)
        {
            this.valor = num;
        }
        public numero(int valor){this.valor = valor;}
        public int Aniade()
        {
            return this.valor+1;
        }
        public int Resta()
        {
            return valor-1;
        }
        public int GetDoble()
        {
            return valor * 2;
        }
        public int GetTriple()
        {
            return valor * 3;
        }
    }
}
