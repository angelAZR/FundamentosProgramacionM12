using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;

namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14.Crear un algoritmo que permita calcular y mostrar por pantalla los números primos hasta el número 100.*//*

            int num = 2;

            Console.WriteLine("Numeros primos del 1 al 100:");

            do
            {
                int divisor = 1;
                int contadorDivi = 0;

                do
                {
                    if (num % divisor == 0)
                    {
                        contadorDivi++;
                    }
                    divisor++;
                }
                while (divisor <= num);
                if (contadorDivi <= num)
                {
                    Console.WriteLine(num + " ");
                }

                num++;
            } 
            while (num <= 100);*/


            /*14.Escribe un algoritmo que actúe como una calculadora básica. El algoritmo le debe permitir al usuario elegir una operación(suma, resta, multiplicación, división), y luego ingresar dos números.El ciclo debe continuar permitiendo al usuario realizar más cálculos hasta que elija salir.*/

            /*            int opcion;
                        int num1;
                        int num2;
                        int resultado;

                        do
                        {
                            Console.WriteLine("\nCalculadora");
                            Console.WriteLine("1. Sumar");
                            Console.WriteLine("2. Restar");
                            Console.WriteLine("3. Multiplicar");
                            Console.WriteLine("4. Dividir");
                            Console.WriteLine("5. Salir");

                            Console.WriteLine("Seleccione una opcion");
                            opcion = Convert.ToInt32(Console.ReadLine());

                            if (opcion >= 1 && opcion <= 4)
                            {
                                Console.WriteLine("Ingrese el primer numero");
                                num1 = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Ingrese el segundo numero");
                                num2 = Convert.ToInt32(Console.ReadLine());

                                if (opcion == 1)
                                {
                                    resultado = num1 + num2;
                                    Console.WriteLine($"Resultado: {resultado}");
                                }
                                else if (opcion == 2)
                                {
                                    resultado = num1 - num2;
                                    Console.WriteLine($"Resultado: {resultado}");
                                }
                                else if (opcion == 3)
                                {
                                    resultado = num1 * num2;
                                    Console.WriteLine($"Resultado: {resultado}");
                                }
                                else if (opcion == 4)
                                {
                                    if (num2 != 0)
                                    {
                                        resultado = num1 / num2;
                                        Console.WriteLine($"Resultado: {resultado}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error: No se puede dividir por cero");
                                    }
                                }
                                else if (opcion != 5) 
                                {
                                    Console.WriteLine("Opcion invalida");
                                }

                            }
                        }while (opcion != 5);
                        Console.WriteLine("Calculadora finalizada.");*/

            /* Crear un algoritmo que permita ingresar números:
            Contar cuántos son pares y cuántos impares
            Calcular el promedio de todos los números ingresados
            Terminar cuando el usuario lo indique*/

/*            int num;
            int pares = 0;
            int impares = 0;
            int suma = 0;
            int contador = 0;
            string opcion;

            do
            {
                Console.WriteLine("Ingres un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                suma+= num;
                contador++;

                Console.WriteLine("¿Desea ingre sar otro numero? (s/n): ");
                opcion = Console.ReadLine();
            }while (opcion.ToLower() == "s");
            if (contador > 0)
            {
                float promedio = suma / contador;

                Console.WriteLine($"\nCantidad de pares: {pares}");
                Console.WriteLine($"Cantidad de impares: {impares}");
                Console.WriteLine($"Promedio: {promedio}");
            }
            else 
            {
                Console.WriteLine("No se ingresaron numeros.");
            }*/

            /*Crear un algoritmo que:
                Permita al usuario ingresar una contraseña
                Se repita hasta que ingrese la contraseña correcta(por ejemplo: 1234)
                Mostrar cuántos intentos realizó*/

            string claveCorrecta = "50437623";
            string clave;
            int intentos = 0;

            do
            {
                Console.WriteLine("Ingrese la contraseña: ");
                clave = Console.ReadLine();

                intentos++;

                if (clave != claveCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. \n");
                }
            } while (clave != claveCorrecta);

            Console.WriteLine("\nAcceso permitido.");
            Console.WriteLine($"Numero de intentos: {intentos}");

        }
    }
}
