using System;

namespace CalculoCuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Para conocer su tarifa y su cuota moderada:");
            Console.WriteLine("Ingrese el valor de su salario (mensual): ");
            int sal = int.Parse(Console.ReadLine());

            double smmlv = sal / 877803;

            if (smmlv < 2)
            {
                Console.WriteLine("Su tarifa es de $3.400COP correpondiente a la Cuota A");
            }
            else if (2 <= smmlv && smmlv < 5)
            {
                Console.WriteLine("Su tarifa es de $13.500COP correpondiente a la Cuota B");
            }
            else
            {
                Console.WriteLine("Su tarifa es de $35.600COP correpondiente a la Cuota C");
            }
        }
    }
}