using System;

namespace Desafio02._1
{
	public class Desafio02
	{
		public static void Main()
		{
			Console.WriteLine("Para hallar el angulo restante y los catetos de un triangulo rectangulo, ingrese: ");

			// Entrada del usuario de el cateto y 
			Console.Write("La hipotenusa : ");
			double h = double.Parse(Console.ReadLine());

			// Entrada del usuario del cateto z
			Console.Write("Un angulo direfente a 90: ");
			double a = double.Parse(Console.ReadLine());

			double c = (90 - a);
			Console.WriteLine("El angulo restante es: " + c + "°");

			double y = h * Math.Sin((a*Math.PI/180));
			double y1 = Math.Round(y, 0);
			Console.WriteLine("El cateto opuesto al angulo dado es: " + y1);

			double z = h* Math.Sin((c * Math.PI / 180));
			double z1 = Math.Round(z, 0);
			Console.WriteLine("El cateto opuesto al angulo restante es: " + z1);

		}
	}
}
