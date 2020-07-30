using System;

namespace IMC
{
    class Program
    {
        static void Main()
        {
            //Ingreso de informacion
            Console.WriteLine("Para conocer el estado de su IMC (Indice de Masa Corporal): ");

            Console.Write("Ingrese su peso (En kilogramos): ");
            double pk = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura (En centimetros): ");
            double ac = double.Parse(Console.ReadLine());

            //operaciones matemáticas
            double pl = pk*2.205;
            double ap = ac / 2.54;

            double imc = (pl * 703) / (ap * ap);

            Console.WriteLine("Su indice de masa corporal es: " + imc);

            //condicionales
            if (imc < 18.5)
            {
                Console.WriteLine("Usted se encuentra bajo se peso");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Usted se encuentra en un peso normal");
            }
            else if (25 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Usted se encuentra en un peso superior al normal");
            }
            else    
            {
                Console.WriteLine("Usted tiene obesidad");
            }

        }
    }
}
