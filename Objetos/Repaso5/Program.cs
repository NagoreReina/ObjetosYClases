using System;

namespace Repaso5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifras numero = new Cifras(3482);
            if (numero.EsPar())
            {
                Console.WriteLine($"{numero.MyNum} es par, sus divisores son {numero.Divisores()} y si sumamos sus digitos el resultado nos da {numero.SumaDigitos()}");
            }
            
        }
    }
}
