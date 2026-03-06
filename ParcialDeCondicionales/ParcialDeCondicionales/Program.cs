using Microsoft.SqlServer.Server;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace ParcialDeCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* La pizzería Dulces Sueños ofrece dos tipos de pizza:
             Vegetariana
             No vegetariana
             El precio final depende de la combinación de ingredientes seleccionados e incluye IVA.
 🔹 Desarrollo(70 %)
 El programa en C# debe:
 1.Solicitar el tipo de pizza:
 Vegetariana
 No vegetariana
 2.Permitir seleccionar ingredientes:
 Vegetariana: elegir 3 ingredientes
 (Pimiento, Tofu, Champiñones, Tomate, Lechuga)
 No vegetariana: elegir 2 ingredientes
 (Res, Chorizo, Pollo, Tocineta, Cerdo)
 3.Calcular precio base e IVA según la combinación:
             Vegetariana
 Pimiento + Champiñones + Lechuga → $20.000(19 %)
 Tofu + Champiñones + Lechuga → $30.000(15 %)
 Otra combinación → $25.000(10 %)
 No vegetariana
 Res + Pollo → $10.000(19 %)
 Res + Tocineta → $15.000(17 %)
 Chorizo + Tocineta → $25.000(9 %)
 Otra combinación → $22.000(10 %)
 4.Fórmula a utilizar:
     Precio Final = Precio Base + (Precio Base × IVA)
 5.Mostrar:
 Tipo de pizza
 Ingredientes seleccionados
 Valor del IVA
 Precio final*/
            string tipoPizza;
            string ingre1;
            string ingre2;
            string ingre3;
            float PrecioBase= 0;
            float IVA = 0;
            float ValorIVA;
            float PrecioFinal;

            Console.WriteLine($"Eliga Tipo de pizza (Vegetariana/No vegetarina): ");
            tipoPizza = Console.ReadLine();
            

            if (tipoPizza == "Vegetariana") 
            {
                Console.WriteLine("Seleccione 3 ingredientes: ");
                Console.WriteLine("pimiento, tofu, champiñones, tomate, lechuga");
                Console.WriteLine("Ingrediente 1");
                ingre1 = Console.ReadLine();

                Console.WriteLine("Ingrediente 2");
                ingre2 = Console.ReadLine();

                Console.WriteLine("Ingedinete 3");
                ingre3 = Console.ReadLine();
                if ((ingre1 == "pimineto" || ingre2 == "pimiento" || ingre3 == "pimiento") && (ingre1 == "champiñones" || ingre2 == "champiñones" || ingre3 == "champiñones") && (ingre1 == "lechuga" || ingre2 == "lechuga" || ingre3 == "lechuga"))
                {
                    PrecioBase = 20000;
                    IVA = 0.19f;
                }
                else if ((ingre1 == "tofu" || ingre2 == "tofu" || ingre3 == "tofu" && (ingre1 == "champiñones" || ingre2 == "champiños" || ingre3 == "champiños") && (ingre1 == "lechuga" || ingre2 == "lechuga" || ingre3 == "lechuga")))
                {
                    PrecioBase = 30000;
                    IVA = 0.15f;
                }
                else 
                {
                    PrecioBase = 25000;
                    IVA = 0.10f;
                }

                Console.WriteLine("\nTipo: Vegetarina");
                Console.WriteLine("Ingredientes "+ingre1 +", "+ingre2+ ", "+ingre3+"");
            }

            else if(tipoPizza == "No vegetarina") 
            {
                Console.WriteLine("Seleccione 2 ingredientes: ");
                Console.WriteLine("res, chorizo, pollo, tocineta, cerdo");
                
                Console.WriteLine("Ingrediente 1");
                ingre1 = Console.ReadLine();

                Console.WriteLine("Ingrediente 2");
                ingre2 = Console.ReadLine();

                if ((ingre1 == "res" && ingre2 == "pollo") || (ingre1 == "pollo" && ingre2 == "res")) 
                {
                    PrecioBase = 10000;
                    IVA = 0.19f;

                }
                else if ((ingre1 == "res" && ingre2 == "tocineta") || (ingre1 == "tocineta" && ingre2 == "res")) 
                {
                    PrecioBase = 15000;
                    IVA = 0.17f;
                }
                else if ((ingre1 == "chorizo" && ingre2 == "tocineta") || (ingre1 == "tocineta" && ingre2 == "chorizo")) 
                {
                    PrecioBase = 25000;
                    IVA = 0.09f;
                }
                else
                {
                    PrecioBase = 22000;
                    IVA = 0.10f;
                }
                Console.WriteLine("\nTipo: No vegetarina");
                Console.WriteLine("Ingredientes " + ingre1 + ", " + ingre2 + "");
            }
            ValorIVA = PrecioBase*IVA;
            PrecioFinal = PrecioBase+IVA;

            Console.WriteLine("Valor del IVA: "+ValorIVA);
            Console.WriteLine("Precio final: "+PrecioFinal);
        }
    }
}
