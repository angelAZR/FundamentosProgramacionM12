using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ArreglosMatices
{
    internal class Program
    {
        static void Main(string[] args)
        /*{
            int[,] numero = new int[2, 3];
            numero[0, 0] = 13;
            numero[0, 1] = 65;
            numero[0, 2] = 0;
            numero[1, 0] = 45;
            numero[1, 1] = 100;
            numero[1, 2] = 29; 
            string[,] nombres =
            {
                {"Angel, Abbad"},
                {"Samuel, Ramiro"},
                {"Alvaro, David"}
            };
            char[,] simbolos = new char[2, 5];
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 5; j++) 
                {
                    Console.WriteLine($"Ingrese el valor para la matriz[{i}, {j}]: ");
                    simbolos[i,j]=Char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            for (int i = 0;i < simbolos.GetLength(0); i++) 
            {
                for (int j = 0;j < simbolos.GetLength(1); j++)
                {
                    Console.Write($"{simbolos[i,j]} | ");
                }
                Console.WriteLine();
            }

        }*/

/*            19. Desarrolla un programa(o algoritmo) que permita eliminar a un alumno de un salón de clases, representado como una matriz de 3x3(3 filas y 3 columnas). 
            El programa debe permitir: 
             capturar los nombres de 9 alumnos, los cuales serán almacenados en una matriz de 3x3.
             Solicitar al usuario la posición del alumno a eliminar, ingresando dos valores: la fila y la columna.
             Eliminar al alumno ubicado en esa posición, reemplazando su nombre por un campo vacío o marcador(por ejemplo, una cadena vacía " "). 
             Mostrar la matriz resultante, con el alumno eliminado.*/

           string[,] alumnos = new string[3, 3];

        Console.WriteLine("Ingrese los nombres de los alumnos:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Alumno [" + i + "," + j + "]: ");
                alumnos[i, j] = Console.ReadLine();
            }
        }

        Console.WriteLine("\nMatriz original:");
        MostrarMatriz(alumnos);

        Console.Write("\nIngrese la fila del alumno a eliminar (0-2): ");
        int fila = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la columna del alumno a eliminar (0-2): ");
        int columna = int.Parse(Console.ReadLine());

        if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3)
        {
            alumnos[fila, columna] = " "; // eliminar (vacío)
        }
        else
        {
            Console.WriteLine("Posición inválida.");
        }

        Console.WriteLine("\nMatriz después de eliminar:");
        MostrarMatriz(alumnos);
    }

    static void MostrarMatriz(string[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

}

