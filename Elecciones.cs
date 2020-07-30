using System;

namespace Elecciones
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("Ingrese la cantidad de votos por el partido A:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de los votos por el partido B:  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de votos en blanco:  ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de votos anulados:  ");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de la población:  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de la población mayor de edad:  ");
            double p = double.Parse(Console.ReadLine());

      
            int votantes = a + b + blanco + anulados;
            int mayores = (int)(n * (p / 100));
            int abstinencia = (mayores) - votantes;
      
            bool A = anulados < ((a + b) * 0.30);
            bool B = blanco < (a + b);
            bool C = abstinencia < votantes;
            bool ganador = a < b;

           
            Console.WriteLine("Total mayores de edad: " + mayores);
            Console.WriteLine("Total  de votantes: " + votantes + " Abstinencia: " + abstinencia);

         
            if ((A || B) && C)
            {
                if (ganador) Console.WriteLine("El ganador es B");
                else Console.WriteLine("El ganador es A");
            }
            else Console.WriteLine("La elección debe realizarse de nuevo");


        }


    }
}