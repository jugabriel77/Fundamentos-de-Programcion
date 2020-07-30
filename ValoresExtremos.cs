using System;

namespace ValoresExtremos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Ingrese el numero de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombreMax = "nombreMax";
            string nombreMin = "nombreMin";


            while (i < n)
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMin = nombre;
                }
                total += edad;
                i++;
                
            }
            double promedio = total / n;
            Console.WriteLine("El promedio de edad es: " + promedio);
            Console.WriteLine("Mayor: " + nombreMax + " " + max+"años");
            Console.WriteLine("Menor: " + nombreMin + " " + min+"años");

        }
    }
}