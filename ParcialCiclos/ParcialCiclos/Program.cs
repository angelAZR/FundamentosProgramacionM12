using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa que permita a un profesor calcular la nota definitiva de cada uno de los 25 estudiantes del curso de Ciencias Naturales, con el fin de identificar si aprobaron o reprobaron la asignatura.
            Las condiciones del problema son las siguientes:
            Cada estudiante presenta dos exámenes y un trabajo de investigación en el primer período académico.
            Las calificaciones se encuentran en un rango de 0.0 a 5.0.
            Para aprobar la asignatura, el estudiante debe obtener un promedio mayor o igual a 3.5.
            El programa debe realizar los siguientes pasos para cada estudiante:
            Solicitar por teclado las tres calificaciones(dos exámenes y un trabajo de investigación).
            Calcular el promedio de las tres notas.
            Mostrar en pantalla un mensaje indicando si el estudiante aprobó o reprobó la asignatura.*/

            float examen1 = 0; 
            float examen2 = 0;
            float trabajo3 = 0;
            float promedio = 0;
           

            for (int estudiantes = 1; estudiantes <= 25; estudiantes++)
            {
                Console.WriteLine($"\nEstudiante #{estudiantes}");

                Console.WriteLine("Ingrese nota del Examen#1: ");
                examen1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese nota del Examen#2: ");
                examen2 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese nota del Trabajo de investigación: ");
                trabajo3 = Convert.ToSingle(Console.ReadLine());

                promedio = (examen1 + examen2 + trabajo3) / 3;

                if (promedio >= 3.5)
                {
                    Console.WriteLine($"El estudiante aprobó con: {promedio}");
                }
                else 
                {
                    Console.WriteLine($"El estudiante reprobó con: {promedio}");
                }

            }






        }
    }
}
