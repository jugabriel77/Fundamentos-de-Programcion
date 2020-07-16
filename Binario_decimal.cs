using System;

namespace Binario_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input del usuario, lectura del input
            Console.Write("Valor 0 binario: ");
            string b0 = Console.ReadLine();

            Console.Write("Valor 1 binario: ");
            string b1 = Console.ReadLine();

            Console.Write("Valor 2 binario: ");
            string b2 = Console.ReadLine();

            Console.Write("Valor 3 binario: ");
            string b3 = Console.ReadLine();

            Console.Write("Valor 4 binario: ");
            string b4 = Console.ReadLine();

            //Conversión
            int d0 = Convert.ToInt32(b0, 2);
            int d1 = Convert.ToInt32(b1, 2);
            int d2 = Convert.ToInt32(b2, 2);
            int d3 = Convert.ToInt32(b3, 2);
            int d4 = Convert.ToInt32(b4, 2);

            //Resultados
            Console.WriteLine("El valor 0 binario en base 10 es: " + d0);
            Console.WriteLine("El valor 1 binario en base 10 es: " + d1);
            Console.WriteLine("El valor 2 binario en base 10 es: " + d2);
            Console.WriteLine("El valor 3 binario en base 10 es: " + d3);
            Console.WriteLine("El valor 4 binario en base 10 es: " + d4);
        }
    }
}