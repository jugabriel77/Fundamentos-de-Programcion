using System;

namespace ValidacionCaptcha
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c=0, ronda=0, ans;
            Random aleatorio = new Random();

            while (ronda <= 3)
            {
                if (ronda == 3)

                {
                    Console.WriteLine("Validacion incorrecta, no puede continuar.");
                    break;
                }
                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);
                c = a + b;
                Console.WriteLine("Calcule el valor para c dado por: a+b=c");
                Console.WriteLine("Siendo a:" + a);
                Console.WriteLine("siendo b:" + b);
                Console.WriteLine("El valor de c es:");
                ans = int.Parse(Console.ReadLine());

                if (ans == c)
                {
                    Console.WriteLine("Puede continuar.");
                    break;
                }
                else
                {
                    Console.WriteLine("Validacion incorrecta, intente otra vez.");
                    ronda += 1;
                }
            }
        }
    }
}
