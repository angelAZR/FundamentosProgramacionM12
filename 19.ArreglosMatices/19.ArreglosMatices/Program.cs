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
        {
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

        }
    }
}
