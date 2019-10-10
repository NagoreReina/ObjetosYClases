using System;

namespace Ejercicio6
{
    class Program
    {
        /*Crea la clase coche con dos constructores. Uno no toma parámetros y el otro sí. 
         Los dos constructores inicializarán los atributos marca y modelo de la clase.
 
        Implementa métodos para obtener y establecer el valor de los atributos, así como un método 
        para mostrar toda la información.
  
        Crea dos objetos (cada objeto llama a un constructor distinto) y 
        verifica que todo funciona correctamente.

         */
        static void Main(string[] args)
        {
            
            Coche vehiculo = new Coche();
            Coche vehiculo2 = new Coche(120,5);
            vehiculo.Marca = "Patatonia";
            vehiculo.Modelo ="Novesientosonse";
            Console.ForegroundColor = ConsoleColor.Cyan;
            vehiculo.AllInfo();
            Console.ForegroundColor = ConsoleColor.Green;
            vehiculo2.AllInfo();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
