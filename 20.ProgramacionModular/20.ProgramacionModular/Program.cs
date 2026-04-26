using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Angel";
            string apellidos = "Alvarez Alvarado";
            Console.WriteLine($"Edad: {EdadAñoNacimiento()}");
            Saludo( nombre, apellidos );
            Saludo("carlos", "Perez Lopez");
            Console.ReadKey();
            BorrarPantalla();
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static void Saludo(string nombre, string apellidos) 
        {
            Console.WriteLine($"Bienvenido {nombre} {apellidos}, a la programacion modular");
        }
        static int EdadAñoNacimiento()
        {
            int añoActual = DateTime.Now.Year;
            int añoNacimiento = 2006;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
    }
}
