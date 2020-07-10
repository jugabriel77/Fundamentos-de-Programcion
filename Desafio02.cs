using System;

namespace Desafio02
{
	public class Desafio02
	{
		public static void Main()
		{
			Console.WriteLine("Para hallar los angulos y la hipotenusa de un triangulo rectangulo ingrese los catetos ");

			// Entrada del usuario de el cateto y 
			Console.Write("Indique el valor del cateto Y: ");
			double y = double.Parse(Console.ReadLine());

			// Entrada del usuario del cateto z
			Console.Write("Indique el valor del cateto Z: ");
			double z = double.Parse(Console.ReadLine());

			double h = Math.Sqrt((y*y)+(z*z));
			Console.WriteLine("La hipotenusa es: " + h);

			double c = Math.Asin(y / h);
			double c1 = (c * (180 / Math.PI));
			Console.WriteLine("El angulo formado entre el cateto Z y la hipotenusa es: " + c1 + "°");

			double a = Math.Asin(z / h);
			double a1 = (a * (180 / Math.PI));
			Console.WriteLine("El angulo formado entre el cateto Z y la hipotenusa es: " + a1+ "°");

			double b = (180-a1-c1);
			double b1 = Math.Round(b,0);
			Console.WriteLine("El angulo formado entre los catetos es: " + b1 + "°");




		}
	}
}
