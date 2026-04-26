using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arreglos_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros=new int[5];//El rango de este vector es 5
            numeros[0] = 12;
            numeros[1] = 13;
            numeros[2] = 42;
            numeros[3] = 201;
            numeros[4] = 0;
           // numeros[5] = 1; La posicion 6 con indice 5 no existe, porque el rango del vector es 5
           Console.WriteLine($"El valor almacenado en la posicion 3, con indice 2 es: {numeros[2]}");
            //recorrel el vector para llenarlo

            string[] nombres =new string[5];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Ingrese el nombre para guardar en la posicion {i + 1}con indice {i}");
                nombres[i]=Console.ReadLine();
            }
            //Recorrer vector para recupera los datos almacenados
            char[] simbolos = new char[] {'#', '%', '?', '|', 'Q', 'Ñ', '&', '9', '*'};

            for (int i = 0;i < simbolos.Length;i++) 
            {
                Console.Write(simbolos[i]+ " | "); 
            }*/
            //Crear arreglo llamado "numeros" de 100 elementos asignar el numero 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.

            /*            int[] numeros = new int[100];

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numeros[i] = 10;
                        }

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine("Posición " + i + ": " + numeros[i]);
                        }*/
            //Llene un arreglo con 15 nuemros ingresados por teclado. Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo: Finalmente, determine cual numero mayor y cual es el numero menor, junto con la posicion que ocupa cada uno dentro del arreglo.
            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nElementos del arreglo:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posición " + i + ": " + numeros[i]);
            }

            int mayor = numeros[0];
            int menor = numeros[0];
            int posMayor = 0;
            int posMenor = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posMayor = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posMenor = i;
                }
            }

            Console.WriteLine("\nNúmero mayor: " + mayor + " en la posición " + posMayor);
            Console.WriteLine("Número menor: " + menor + " en la posición " + posMenor);

        }
    }
}
