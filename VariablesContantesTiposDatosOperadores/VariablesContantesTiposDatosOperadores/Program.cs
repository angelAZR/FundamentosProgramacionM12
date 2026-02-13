using System;

namespace VariablesContantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numericos
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.Write(num1 + "//" + num2 + "//" + num3);
            //Aritmeticos
            int num4 = 3 + 5;
            int num5 = 12 - 63;
            int num6 = 26 * 14;
            float num7 = 5f / 3;
            Console.Write("\n Suma:{0}, Resta:{1}, Multiplicacion: {2}, Division: {3}",num4,num5,num6,num7);
            //Incremento y decremento
            num4++;//num4=num4+1
            num5--;//num5=num5-1
            num6 += 4;//num6=num6+4 
            num4 -= 10;
            num5 *= 3;
            num6 /= 2;
            num6 *= num4;
            int num8 = 4 * 3 / 2;
            int num9= 4*(3 / 2);
            int num10 = 4 + 6 * (2 - 1);
            //operadores logicos
            //Conjuncion - y- AMD - &&
            Console.WriteLine("\n TABLA DE VERDAD CONJUGACION");
            Console.WriteLine("V Y V: " + (true && true));
            Console.WriteLine("V Y F: " + (true && false));
            Console.WriteLine("F Y V: " + (false && true));
            Console.WriteLine("F Y F: " + (false && false));
            Console.WriteLine("-----------------------------");
            //Disyuncion - O -OR - ||
            Console.WriteLine("\n TABLA DE VERDAD CONJUGACION");
            Console.WriteLine("V O V: " + (true || true));
            Console.WriteLine("V O F: " + (true || false));
            Console.WriteLine("F O V: " + (false || true));
            Console.WriteLine("F O F: " + (false || false));
            //Operaciones de comparacion
            bool dato1 = 4 > 5;
            bool dato2 = 16 != 100;
            bool dato3 = 1== 1;
            bool dato4 = !dato3;
            bool dato5 = 100<200 || dato3 && true;
        }
    }
}
