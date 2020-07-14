using System;

namespace Desafío03
{
    class Program
    {
        static void Main()
        {
            //Ingreso de informacion
            Console.Write("Ingrese el valor para B(en grados): ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor para Z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor para Y: ");
            double y = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double c = Math.Atan(z / y);
            double c1 = c * 180 / Math.PI;
            double e = 180 - c1;
            double d = 180 - b - e;
            double w = z / (Math.Sin(d * Math.PI / 180));
            double W = w * w;
            double Z = z * z;
            double x = (Math.Sqrt((w*w) - (z*z))) - y;

            double x1 = Math.Round(x, 0);

            Console.WriteLine("El valor de x es: " + x1);


        }
    }
}