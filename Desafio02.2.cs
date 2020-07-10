using System;

namespace Desafio02._2
{
	public class Desafio02
	{
		public static void Main()
		{
			Console.WriteLine("Para hallar la hipotenusa, el angulo y el cateto restante de un triangulo rectangulo, ingrese: ");

			// Entrada del usuario de el cateto y 
			Console.Write("Un angulo : ");
			double c = double.Parse(Console.ReadLine());

			// Entrada del usuario del cateto z
			Console.Write("El cateto opuesto a ese angulo: ");
			double z = double.Parse(Console.ReadLine());

			double a = (90 - c);
			Console.WriteLine("El angulo restante es: " + a + "°");

			double y = (z/ Math.Sin(c * Math.PI / 180)) * Math.Sin(a * Math.PI / 180);
			double y1 = Math.Round(y, 0);
			Console.WriteLine("El cateto opuesto al angulo restante es: " + y1);

			double h = Math.Sqrt((z*z)+(y1*y1));
			Console.WriteLine("La hipotenusa es: " + h);

		}
	}
}