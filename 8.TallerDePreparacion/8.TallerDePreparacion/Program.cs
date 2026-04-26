using System;


namespace _8.TallerDePreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor. 
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

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
            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            cuenta con munición y si se encuentra en estado invencible, crear un programa que:
                a.Permita ingresar por teclado si el personaje está en estado invencible(True).
                b.La cantidad de munición que tiene el personaje en el momento será calculada por el
                sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#
                c.Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y
                10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
                no hacer nada.*/

            Random random = new Random();

            int municion = random.Next(0, 11);

            Console.Write("¿El personaje está en estado invencible? (true/false): ");
            bool invencible = bool.Parse(Console.ReadLine());

            Console.WriteLine("Munición disponible: " + municion);

            if (municion > 0 && invencible)
            {
                Console.WriteLine("El personaje puede disparar.");
            }
            else
            {
                Console.WriteLine("El personaje NO puede disparar.");
            }
            if (invencible && municion >= 1 && municion <= 10)
            {
                Console.WriteLine("El personaje está disparando");
            }

            /*Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1),
            P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            P3.La distancia entre dos puntos está dada por la siguiente formula:
            d = √((x2 - x1)² +(y2 - y1)²)
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
            cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
            condiciones no se cumplen.*/

            Console.WriteLine("Ingrese las coordenadas de P1:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas de P2:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas de P3:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double d12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double d23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double d13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            Console.WriteLine("\nDistancias:");
            Console.WriteLine("P1-P2: " + d12);
            Console.WriteLine("P2-P3: " + d23);
            Console.WriteLine("P1-P3: " + d13);

            bool c1 = d12 + d23 > d13;
            bool c2 = d12 + d13 > d23;
            bool c3 = d23 + d13 > d12;

            if (c1 && c2 && c3)
            {
                Console.WriteLine("\n✅ Se puede formar un triángulo.");
            }
            else
            {
                Console.WriteLine("\n❌ NO se puede formar un triángulo.");

                if (!c1)
                    Console.WriteLine("No se cumple: d12 + d23 > d13");

                if (!c2)
                    Console.WriteLine("No se cumple: d12 + d13 > d23");

                if (!c3)
                    Console.WriteLine("No se cumple: d23 + d13 > d12");
            }
            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
             derecha
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
             dirección”*/
            Console.Write("Presiona una tecla (d = derecha, i = izquierda): ");
            char tecla = char.ToLower(Console.ReadKey().KeyChar);

            Console.WriteLine();

            if (tecla == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (tecla == 'i')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("No me puedo mover en otra dirección");
            }

            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
              el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
               Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. (Función Random)
               Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. Encaso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizarninguna acción”.
               Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo alcarácter que se ingrese:
                Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
                Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
                Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
                Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”*/

            Random random = new Random();

            // Generar vidas entre 0 y 5
            int vidas = random.Next(0, 6);

            Console.WriteLine("Vidas del personaje: " + vidas);

            // Verificar si puede actuar
            if (vidas > 0)
            {
                Console.Write("\nIngresa una acción (c, x, t, i): ");
                char accion = char.ToLower(Console.ReadKey().KeyChar);

                Console.WriteLine(); // salto de línea

                if (accion == 'c')
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (accion == 'x')
                {
                    Console.WriteLine("El personaje está hablando con la Rana");
                }
                else if (accion == 't')
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (accion == 'i')
                {
                    Console.WriteLine("El personaje es Invencible");
                }
                else
                {
                    Console.WriteLine("Acción no válida");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas y no puede realizar ninguna acción");
            }

        }
    }
}
