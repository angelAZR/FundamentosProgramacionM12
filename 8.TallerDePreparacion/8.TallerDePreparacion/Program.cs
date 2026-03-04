using System;


namespace _8.TallerDePreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float num3;

            Console.WriteLine("Ingrese numero 1");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3");
            num3 = Convert.ToSingle(Console.ReadLine());
            if (num1 == num2 || num3 == num1 || num2 == num3)
            {
                Console.WriteLine("Ingresar numeros diferente");
            }
            else
            {
                if (num1 > num2 && num1 > num3 && num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es {num1}, el del medio es {num2} y el menor es {num3}");
                }
                else 
                {
                    if (num2 > num1 && num2 > num3 && num1 > num3)
                    {
                        Console.WriteLine($"El numero mayor es {num2}, el del medio es {num1} y el menor es {num3}");
                    }
                }
            }

        }
    }
}
