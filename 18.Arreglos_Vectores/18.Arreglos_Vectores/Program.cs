using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Arreglos_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Llenar un arreglo con 15 palabras ingresadas por teclado, luego invertir el contenido del arreglo, y mostrar por pantalla los elementos del arreglo original y los elementos del arreglo invertido.*/

            string[] palabras = new string[15];
            string[] invertido = new string[15];

            Console.WriteLine("Ingrese 15 palabras:");
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.Write("Palabra " + (i + 1) + ": ");
                palabras[i] = Console.ReadLine();
            }

            for (int i = 0; i < palabras.Length; i++)
            {
                invertido[i] = palabras[palabras.Length - 1 - i];
            }

            Console.WriteLine("\nArreglo original:");
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }

            Console.WriteLine("\nArreglo invertido:");
            for (int i = 0; i < invertido.Length; i++)
            {
                Console.WriteLine(invertido[i]);
            }
        }
    }
}
