using System;

namespace CiclosDadosCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, total = 0, contador = 0, ronda = 0;
            string ans = "";
            Random aleatorio = new Random();
            Console.WriteLine("¿Desea comenzar el juego? (si/no)");
            ans = Console.ReadLine();


            while (ans == "si" && total < 100)
            {
                dado = aleatorio.Next(1, 13);
                total = (dado + total);
                Console.WriteLine("Puntucion:"+ dado + "  total:" + total);
                ronda += 1;


                if (contador == 1)
                {
                    if (dado == 10)
                    {
                        contador += 1;
                    }
                    if (dado != 10)
                    {
                        contador = 0;
                    }
                }
                if (dado == 12)
                {
                    contador += 1;
                }


                if (ronda > 3)
                {
                    if (dado % 2 != 0)
                    {
                        total = 0;
                        Console.WriteLine("Has perdido");
                        ans = "no";
                    }
                }

                if (total >= 100 || contador == 2)
                {
                    Console.WriteLine("Has ganado");
                    ans = "no";
                }
                if (ans == "si")

                {
                    Console.WriteLine("¿Desea continuar jugando? (si/no)");
                    ans = Console.ReadLine();
                }
            }
        }
    }
}

