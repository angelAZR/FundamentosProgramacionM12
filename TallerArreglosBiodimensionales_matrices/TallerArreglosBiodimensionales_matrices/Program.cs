using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TallerArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
             pantalla la suma de los elementos de cada columna*/
            /* int[,] matriz = new int[10, 20];

             Console.WriteLine("Ingrese los valores de la matriz:");
             for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     Console.Write("Valor [" + i + "," + j + "]: ");
                     matriz[i, j] = int.Parse(Console.ReadLine());
                 }
             }

             Console.WriteLine("\nSuma de cada columna:");
             for (int j = 0; j < 20; j++)
             {
                 int sumaColumna = 0;

                 for (int i = 0; i < 10; i++)
                 {
                     sumaColumna += matriz[i, j];
                 }

                 Console.WriteLine("Columna " + j + ": " + sumaColumna);

             }*/

            /*Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.*/

            Console.Write("Ingrese número de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            Console.WriteLine("\nIngrese los caracteres:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Posición [" + i + "," + j + "]: ");
                    matriz[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz original:");
            MostrarMatriz(matriz, n, m);

            for (int j = 0; j < m; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }

            Console.WriteLine("\nMatriz con filas intercambiadas:");
            MostrarMatriz(matriz, n, m);
        }
        static void MostrarMatriz(char[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /* Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
         5x5 llena de números aleatorios.
             El algoritmo debe permitir:
             Usa la función Random para generar los números aleatorios.
             Crea un arreglo adicional para almacenar la frecuencia de cada número.
             Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número.*/
        int[,] matriz = new int[5, 5];
        int[] frecuencia = new int[10]; // índices 0-9 representan números 1-10
        Random rand = new Random();

        static void Main()
        {
            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10]; // índices 0-9 representan números 1-10
            Random rand = new Random();

            // Llenar la matriz con números aleatorios (1-10)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(1, 11); // 1 a 10
                }
            }

            // Mostrar la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");

                    // Contar frecuencia
                    frecuencia[matriz[i, j] - 1]++;
                }
                Console.WriteLine();
            }

            // Mostrar frecuencias
            Console.WriteLine("\nFrecuencia de los números:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número " + (i + 1) + ": " + frecuencia[i]);
            }
        }

    }
}
