using System;

namespace CajaDeCompensación
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Para conocer cual tarifa es aplicble a usted");
            Console.Write("Ingrese el valor de su salario mensual: ");
            int sal = int.Parse(Console.ReadLine());

            double smmlv = sal / 877803;

            if (smmlv < 2)
            {
                Console.WriteLine("Su tarifa correspondiente es la Tarifa A");
            }
            else if (2 <= smmlv && smmlv < 4)
            {
                Console.WriteLine("Su tarifa correspondiente es la Tarifa B");
            }
            else
            {
                Console.WriteLine("Su tarifa correspondiente es la Tarifa C");
            }
        }
    }
}
