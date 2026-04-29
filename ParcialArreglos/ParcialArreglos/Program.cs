using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Definición de la matriz:
                         Solicite al usuario ingresar el número de filas n y columnas m de la matriz.
                         Ambos valores deben ser enteros mayores o iguales a 2 y menores o iguales a 10.
                         Si el usuario ingresa valores fuera del rango, debe mostrarse un mensaje de error y volver a solicitar la entrada.

                            Ingreso de elementos:
                        Permita al usuario ingresar los elementos de la matriz manualmente, uno a uno, indicando la posición actual(fila, columna).
                        Cada número debe ser un entero que puede ser positivo, negativo o cero.

                        Visualización de la matriz:
                         Una vez completado el ingreso, mostrar la matriz en pantalla con un formato tabu

                        Calcular y mostrar en pantalla lo siguiente:
                         La suma de todos los números pares ingresados en la matriz.
                         La suma de todos los números impares.
                         La cantidad de números negativos encontrados en la matriz.
                         La cantidad total de ceros.
                         El promedio general de todos los valores ingresados.

                        Formato de salida:
                         Cada resultado debe mostrarse con un mensaje descriptivo.

                        Consideraciones técnicas:
                         El cálculo del promedio debe considerar todos los elementos de la matriz.*/

            int filas = 0;
            int columnas = 0;

            do
            {
                Console.WriteLine("Ingrese el numero de filas de (2 a 10): ");
                filas = Convert.ToInt32(Console.ReadLine());

                if (filas < 2 || filas > 10)
                {
                    Console.WriteLine("Error: el numero de filas debe estar entre 2 y 10");
                }

            } while (filas < 2 || filas > 10);


            do
            {
                Console.WriteLine("Ingrese el numero de columnas de (2 a 10): ");
                columnas = Convert.ToInt32(Console.ReadLine());

                if (columnas < 2 || columnas > 10)
                {
                    Console.WriteLine("Error: el numero de columnas debe estar entre 2 y 10");
                }
            } while (columnas < 2 || columnas > 10);


            int[,] matriz= new int[filas, columnas];

            int SumaPares = 0;
            int SumaImpares = 0;
            int CantidadNeg = 0;
            int CantidadCeros = 0;
            int sumaTotal = 0;


            Console.WriteLine("------INGRESO DE ELEMENTOS------");

            for (int i = 0; i < filas; i++) 
            {
                for (int j = 0; j < columnas; j++) 
                {
                    Console.WriteLine($"Ingrese el valor para la posision{i},{j}");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    int num = matriz[i, j];

                    sumaTotal += num;

                    if (num % 2 == 0)
                    {
                        SumaPares += num;
                    }
                    else
                    {
                        SumaImpares += num;
                    }

                    if(num < 0)
                    {
                        CantidadNeg ++;
                    }

                    if (num == 0)
                    {
                        CantidadCeros++;
                    }
                }
                
            }

            Console.WriteLine("\n--- Matriz Ingresada---");

            for(int i = 0;i < filas; i++)
            {
                for(int j = 0;j < columnas; j++)
                {
                    Console.Write(matriz[i,j]+ "\t");


                }
                Console.WriteLine();
            }

            int totalElementos = filas*columnas;
            float promedio = sumaTotal/totalElementos;

            Console.WriteLine("\n---RESULTADOS---");
            Console.WriteLine($"Suma de numeros Pares: {SumaPares}");
            Console.WriteLine($"Suma de numeros Impares: {SumaImpares}");
            Console.WriteLine($"Cantidad de numero Negativos: {CantidadNeg}");
            Console.WriteLine($"Cantidad de Ceros: {CantidadCeros}");
            Console.WriteLine($"El promedio general: {promedio}");

        }
    }
}
    

