using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int contador = 1;
              int acumulador = 0;
              while (contador <= 5) 
              {
                  acumulador += contador;
                  Console.WriteLine($"Contador:{contador} - Acumulador: {acumulador}");
                  contador++;
              }
              Console.WriteLine($"La suma de los cinco primeros números enteros es:{acumulador}");*/

            int num = 0;
            int contador = 1;
            int acumulador = num;
            Console.WriteLine("Ingrese el numero a calcular");
            num = Convert.ToInt32(Console.ReadLine());


            while (contador <= num) 
            {
                acumulador += contador;
                Console.WriteLine($"Contador:{contador} - Acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine($"La factorisacion de {num} es: {acumulador} ");
        }
    }
}
