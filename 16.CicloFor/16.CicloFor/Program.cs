using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16.Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:
            El número de partidos perdidos
            El número de partidos empatados
            El número de partidos ganados
            El porcentaje de partidos perdidos
            El porcentaje de partidos empatados
            El porcentaje de partidos ganados*/

            int ganados =0;
            int perdidos = 0;
            int empatados = 0;
            int resultados = 0;

            for (int partido = 1; partido <= 30; partido++) 
            {
                Console.WriteLine($"\nPartido #{partido}");
                Console.WriteLine("1. Ganado");
                Console.WriteLine("2. Empatado");
                Console.WriteLine("3. Perdido");

                Console.WriteLine("Ingrese el resultado: ");
                resultados = Convert.ToInt32(Console.ReadLine());

                if (resultados == 1)
                {
                    ganados++;
                }
                else if (resultados == 2)
                {
                    empatados++;
                }
                else if (resultados == 3)
                {
                    perdidos++;
                }
                float Ganados = (ganados * 100) / 30;
                float Empatados = (empatados * 100) / 30;
                float Perdidos = (perdidos * 100) / 30;

                Console.WriteLine("\n RESULTADOS");
                Console.WriteLine($"Ganados: {ganados}");
                Console.WriteLine($"Empatados: {empatados}");
                Console.WriteLine($"Perdidos: {perdidos}");

                Console.WriteLine($"\nPorcentaje de Ganados: {Ganados}%");
                Console.WriteLine($"\nPorcentaje de Empatados: {Empatados}%");
                Console.WriteLine($"\nPorcentaje de Perdidos: {Perdidos}%");

            }

        }
    }
}
