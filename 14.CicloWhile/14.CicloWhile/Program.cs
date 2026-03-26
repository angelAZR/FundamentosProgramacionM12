using System;

namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar numeros: contar cuantos son pares y cuantos impares calcular el promedio de todos los numeros ingresados terminar cuando el usuario lo indique*/
           /*int num = 0;
           int numpar = 0;
           int numimpar = 0;
           int contador = 0;
           int cantidad = 0;

            Console.WriteLine("Cuántos números desea ingresar?: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (contador < cantidad) 
            {
                Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    numpar++;
                }
                else 
                {
                    numimpar ++;

                }
                contador ++;
            }

            Console.WriteLine("\n Resultados");
            Console.WriteLine($"Cantidad de pares: {numpar}");
            Console.WriteLine($"Cantidad de impares: {numimpar}");*/
            /*int numimpar = 1;
       int acumulador = 0;

       while(numimpar <= 99)/
       {
           acumulador = acumulador + numimpar;
           numimpar = numimpar +2;

       }
       Console.WriteLine("La suma es: "+ acumulador);*/
            int cantidad = 0;
            int contador = 1;
            int cero = 0;
            int mayorcero = 0;
            int menorcero = 0;
            int numero = 0;
            Console.WriteLine("¡¿uantos numeros desea ingresar?");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (contador < cantidad)
            {
                Console.WriteLine($"Ingrese el valor para el numero {contador}");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    cero++;

                }
                else
                {
                    if (numero > 0)
                    {
                        mayorcero++;
                    }
                    else
                    {
                        menorcero++;
                    }
                }

                contador++;
            }
            Console.WriteLine($"Ceros: {cero}, Mayores a cero: {mayorcero}, Menores a cero {menorcero}");
        }
    }
}
