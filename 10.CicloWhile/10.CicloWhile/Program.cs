using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10.Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo.Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            int num = 0;
            int suma = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num >= 0) 
            {
                suma += num;

                Console.WriteLine("Ingrese otro numero, si desea terminal ingrese un numero negativo: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
