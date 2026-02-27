using System;


namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //string diaSemana = "";
             //float subtotal = 0;
             //float descuento = 0;
             //Console.WriteLine("Ingrese monto de la compra");
             //subtotal = Single.Parse(Console.ReadLine());
             //Console.WriteLine("Ingrese el dia de la semana");
             //diaSemana=Console.ReadLine();

             //switch (diaSemana) 
             //{
             //    case "Lunes":
             //        descuento=subtotal*0.1f;
             //        Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el valor total a pagar es de {subtotal-descuento}");
             //        break;
             //    case "Martes":
             //        descuento = subtotal * 0.15f;
             //        Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;
             //    case "Miercoles":
             //        descuento = subtotal * 0.10f;
             //        Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;
             //    case "Jueves":
             //        descuento = subtotal * 0.15f;
             //        Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;
             //    case "Viernes":
             //        descuento = subtotal * 0.2f;
             //        Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;
             //    case "Sabado":
             //        descuento = subtotal * 0.2f;
             //        Console.WriteLine($"Hoy es sabado, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;
             //    case "Domingo":
             //        descuento = 0;
             //        Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
             //        break;

             //    default:
             //        Console.WriteLine("Por favor ingrese un dia de la semana correcto");
             //        break;*/
            int num1;
            int num2;
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            int numSRMD = 0;
            Console.WriteLine("Ingrese numero 1");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija: Sumar = 1, restar = 2, multiplicar = 3 o dividir = 4 ");
            numSRMD = Convert.ToInt32(Console.ReadLine());
            if (numSRMD == 1) 
            {
                Console.WriteLine($"La suma de {num1} y {num2} es {suma}");
            }

        }
    }
    
}
