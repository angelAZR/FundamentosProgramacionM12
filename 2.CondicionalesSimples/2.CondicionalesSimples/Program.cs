using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           String nombre = "";
              float sueldo = 0;
              Console.WriteLine("Ingresar el nombre del usuario");
              nombre = Console.ReadLine();//Lo que llega de la consola es de tipo string
                        Console.WriteLine("ingrese el sueldo del usuario");
                        sueldo = Convert.ToSingle (Console.ReadLine());
                        if (sueldo>=3000)
                        {
                            Console.WriteLine($"lapersona {nombre}, debe abonar impuestos");
                        }*/
            string nombre = "";
            int edad = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad del usuario");
            edad = Convert.ToInt32 (Console.ReadLine());
            if (edad >= 18) 
            {
                Console.WriteLine("Bienvenido a mi sito web");
            }


        }
    }
}
