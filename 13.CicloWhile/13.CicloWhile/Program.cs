using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/

            /*    int num = 0;
                int ini = 0;
                string opc = "s";

                while (opc.ToLower() == "s")
                {
                    Console.WriteLine("Ingrese un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    ini = 1;

                    while (ini <= 10) 
                    {
                        Console.WriteLine(num + " x " + ini + " = " + (num * ini));
                        ini++;
                    }
                    Console.WriteLine("¿Desea generar otra tabla? (s/n): ");
                    opc = Console.ReadLine();
                }
                Console.WriteLine("Finalizado");*/

            /* Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente
             * 1. Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito”
             * 2. Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito”
             * El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más.
               Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.*/

            string nombre;
            string numCuenta;
            float saldo = 0f;
            float sumsaldo = 0f;
            int ContadorUsu = 0;
            string opcion = "s";

            while (opcion.ToLower() == "s")
            {
                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el numero de cuenta: ");
                numCuenta = Console.ReadLine();

                Console.WriteLine("Ingrese el saldo: ");
                saldo = Convert.ToInt32(Console.ReadLine());

                if (saldo > 3000000) 
                {
                    Console.WriteLine($"\nUsuario: {nombre}");
                    Console.WriteLine($"Cuenta: {numCuenta}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine($"Es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"\nUsuario: {nombre}");
                    Console.WriteLine($"Cuenta: {numCuenta}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine($"No es apto para el credito");
                }

                sumsaldo += saldo;
                ContadorUsu++;

                Console.WriteLine("¿Desea ingresar otro usuario? (s/n): ");
                opcion = Console.ReadLine();
            }
            if (ContadorUsu > 0)
            {
                float promedio = sumsaldo / ContadorUsu;

                Console.WriteLine($"\nTotal de usuarios: {ContadorUsu}");
                Console.WriteLine($"Promedio de saldos: {promedio}");
            }
            else 
            {
             Console.WriteLine("No se ingresaron usuarios.");   
            }

        }
    }
}
