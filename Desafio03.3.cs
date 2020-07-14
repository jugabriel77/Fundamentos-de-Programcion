using System;

namespace Desafío03._3
{
    class Program
    {
        static void Main()
        {
            //Inngreso de informacion
            Console.Write("Ingrese el valor para W: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para d (en grados): ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para X: ");
            double x = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double z = w * Math.Sin(d * Math.PI / 180);
            double y = (Math.Sqrt((w*w)-(z*z)))- x;

            double y1 = Math.Round(y, 0);

            Console.WriteLine("El valor para y es: " + y1);
        }
    }
}