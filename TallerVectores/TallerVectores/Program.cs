using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            encuentre y muestre el valor máximo y mínimo de los números ingresados.*/

            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine("\nNúmero mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);

            /*2.Escribir un algoritmo que permita:
              a.Crear dos vectores del mismo tamaño. 
              b.Llenarlos con números.
              c.Comparar posición por posición.
              d.Indicar cuántos elementos son iguales.*/

            int num = 10; 
            int[] v1 = new int[num];
            int[] v2 = new int[num];
            int contador = 0;

            Console.WriteLine("Ingrese los valores del primer vector:");
            for (int i = 0; i < num; i++)
            {
                Console.Write("v1[" + i + "]: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese los valores del segundo vector:");
            for (int i = 0; i < num; i++)
            {
                Console.Write("v2[" + i + "]: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                if (v1[i] == v2[i])
                {
                    contador++;
                }
            }

            Console.WriteLine("\nCantidad de elementos iguales: " + contador);

            /*3. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
               orden de los elementos del vector.Se deben mostrar lo dos vectores.*/
            
            int n = 10; 
            char[] vector = new char[n];
            char[] invertido = new char[n];

            Console.WriteLine("Ingrese los caracteres:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Posición " + i + ": ");
                vector[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                invertido[i] = vector[n - 1 - i];
            }

            Console.WriteLine("\nVector original:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine("\nVector invertido:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(invertido[i] + " ");
            }
            /*7.Escribir un algoritmo que permita:
              a.Crear un vector de nombres.
              b.Solicitar una letra al usuario. 
              c.Contar cuántos nombres empiezan con esa letra.*/

            int n = 10; 
            string[] nombres = new string[n];

            Console.WriteLine("Ingrese los nombres:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();
            }

            Console.Write("\nIngrese una letra: ");
            char letra = char.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                if (!string.IsNullOrEmpty(nombres[i]) &&
                    char.ToLower(nombres[i][0]) == char.ToLower(letra))
                {
                    contador++;
                }
            }

            Console.WriteLine("\nCantidad de nombres que empiezan con '" + letra + "': " + contador);


        }
    }
}
