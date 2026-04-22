using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12.Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.*/

            int numero = 0;
            int contador = 0;
            int inicio = 1;

            Console.WriteLine("ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numeros pares: ");

            while (inicio <= numero) 
            {
                if (inicio % 2 == 0) 
                {
                    Console.WriteLine(inicio + " ");
                    contador++;
                }

                inicio++;
            }
            Console.WriteLine($"\nCantidad de numeros pares: {contador}");
        }
    }
}
