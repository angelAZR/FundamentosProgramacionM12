using System;

namespace _4.EjercicioProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

          int numEnt = 0;
          Console.WriteLine("Ingrese el numero");
          numEnt = Convert.ToInt32(Console.ReadLine());
            if (numEnt < 0)
            {
                Console.WriteLine($"El numero {numEnt} es negativo");
            }
            else 
            { 
                Console.WriteLine($"El numer {numEnt} es positivo"); 
            }
                     
        }
    }
}
