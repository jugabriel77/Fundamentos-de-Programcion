using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 2, total = 0, puntuacion = 0;
            Random aleatorio = new Random();
            string ans = "";
            Console.WriteLine("¿Desea iniciar el juego? (si/no)");
            ans = Console.ReadLine();
            puntuacion = aleatorio.Next(2, 20);
            total = puntuacion;
            Console.WriteLine("Cartas: " + carta + "  Puntuación: " + puntuacion + " Puntuacion Total: " + total);
            
            while (ans == "si")
            {
                puntuacion = aleatorio.Next(1, 10);
                carta = (carta + 1);
                Console.WriteLine("¿Desea continuar jugando? (si/no)");
                ans = Console.ReadLine();

                if (ans == "si")
                {
                    total += puntuacion;
                    Console.WriteLine("Cartas: " + carta + "  Puntuación: " + puntuacion + " Puntucion Total: " + total);
                }
                if (total > 21)
                {
                    total = 0;
                    Console.WriteLine("Ha perdido el juego.");
                    ans = "no";
                }
                else if (total == 21)
                {
                    Console.WriteLine("Ha ganado el juego.");
                    ans = "no";
                }
                else if (ans == "no")
                {
                    Console.WriteLine("Gracias por jugar.");
                }
                Console.WriteLine("Su total fue de: " + total);
            }
            
        }
    }
}