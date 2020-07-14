using System;

namespace Desafío03._4
{
    class Program
    {
        static void Main()
        {
            //Ingreso de informacion
            Console.Write("Ingrese el valor para W: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para T: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para c (en grados): ");
            double c = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double z = t * Math.Sin(c * Math.PI / 180);
            double a = 90 - c;
            double y = t * Math.Sin(a * Math.PI / 180);
            double x = (Math.Sqrt((w*w)-(z*z))) - y;

            double x1 = Math.Round(x, 0);

            Console.WriteLine("El valor para x es: " + x1);
        }
    }
}