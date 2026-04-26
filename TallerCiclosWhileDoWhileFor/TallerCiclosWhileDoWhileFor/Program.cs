using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCiclosWhileDoWhileFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente*/
            /*
                        double nota, suma = 0;
                        int contador = 0;
                        string opcion;

                        do
                        {
                            Console.Write("Ingrese una calificación: ");
                            nota = double.Parse(Console.ReadLine());

                            suma += nota;
                            contador++;

                            Console.Write("¿Desea ingresar otra calificación? (s/n): ");
                            opcion = Console.ReadLine();

                        } while (opcion.ToLower() == "s");

                        if (contador > 0)
                        {
                            double promedio = suma / contador;
                            Console.WriteLine("\nPromedio de calificaciones: " + promedio);
                        }
                        else
                        {
                            Console.WriteLine("No se ingresaron calificaciones.");
                        }*/

            /*            Se requiere un algoritmo para mostrar por pantalla los divisores de un
                        número ingresado por teclado.
                        Tener en cuenta que dados dos números enteros a y b, se dice que b es
                        divisor de a si se cumple que al efectuar una división entera a/ b el
                        residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
                        una división de dos números*/

            /*int numero;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDivisores de " + numero + ":");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.Write(i + " ");
                }
            }*/

            /*Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación.
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’*/

            int b, e;
            long resultado;
            string opcion;

            do
            {
                Console.Write("Ingrese la base: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el exponente: ");
                e = int.Parse(Console.ReadLine());

                resultado = 1;

                // cálculo de potencia
                for (int i = 1; i <= e; i++)
                {
                    resultado *= b;
                }

                Console.WriteLine("Resultado: " + resultado);

                Console.Write("¿Desea continuar? (s/n): ");
                opcion = Console.ReadLine();

            } while (opcion.ToLower() != "n");

            Console.WriteLine("Programa finalizado.");


            /* Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco 
             kilómetros durante 10 días, para determinar si es apto para la prueba de 5 kilómetros.
             Para considerarlo apto debe cumplir las siguientes condiciones: 
                 Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos. 
                 Que al menos en una de las pruebas realice un tiempo menor de 15 minutos. 
                 Que su promedio sea menor o igual a 18 minutos. 
                 Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia.*/

            double tiempo, suma = 0;
            bool menor15 = false;
            bool apto = true;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese el tiempo del día " + i + ": ");
                tiempo = double.Parse(Console.ReadLine());

                // Condición 1
                if (tiempo > 20)
                {
                    apto = false;
                }

                // Condición 2
                if (tiempo < 15)
                {
                    menor15 = true;
                }

                suma += tiempo;
            }

            double promedio = suma / 10;

            // Condición 3
            if (promedio > 18)
            {
                apto = false;
            }

            // Validación final
            if (apto && menor15)
            {
                Console.WriteLine("\nEl atleta es APTO para la prueba.");
            }
            else
            {
                Console.WriteLine("\nEl atleta NO es apto para la prueba.");
            }

            Console.WriteLine("Promedio: " + promedio);



        }
    }
}
