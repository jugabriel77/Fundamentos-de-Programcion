using System;

namespace Desafío03._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de los datos
            Console.Write("Ingrese el valor para d (en grados): ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para b (en grados): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese Y: ");
            double y = double.Parse(Console.ReadLine());

            //operaciones
            double e = 180 - d - b;
            double c = 180 - e;
            double a = 90 - c;
            double z = (y * Math.Sin(c * Math.PI / 180)) / (Math.Sin(a * Math.PI / 180));

            double z1 = Math.Round(z, 0);

            Console.WriteLine("El valor para z es: " + z1);


        }
    }
}