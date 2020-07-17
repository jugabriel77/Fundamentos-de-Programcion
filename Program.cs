using System;

namespace Cuadrática
{
    class Program
    {
        static void Main()
        {
            //Input
            Console.WriteLine("Para resolver una ecuación cuadrática:");
            Console.Write("Ingrese el valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            //Operaciones matemáticas
            double discrim = (b * b) - (4 * a * c);

            if (discrim == 0)
            {
                double solutionPositive = (-b) / (2 * a);

                Console.WriteLine("Unica solucion:"+ solutionPositive);
            }
            else if (discrim > 0)
            {
                double solutionPositive = ((-b) + Math.Sqrt(discrim)) / (2 * a);
                double solutionNegative = ((-b) - Math.Sqrt(discrim)) / (2 * a);

                Console.WriteLine("Existen dos soluciones.");
                Console.WriteLine("Solucion positiva: " + solutionPositive);
                Console.WriteLine("Solucion Negativa: " + solutionNegative);
            }
            else
            {
                Console.WriteLine("No tiene solución.");
            }


        }
    }
}