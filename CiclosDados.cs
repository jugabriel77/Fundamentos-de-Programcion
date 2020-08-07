using System;

namespace CiclosDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado1 = 0, dado2 = 0, total = 0, puntuacion = 0, contadorTurnos = 1, contadorSeis = 0, contadorDobles = 0;
            double porcentajeSeis = 0;
            string ans = "";
            Random aleatorio = new Random();
            Console.WriteLine("¿Desea comenzar el juego? (si/no)");
            ans = Console.ReadLine();
            dado1 = aleatorio.Next(1, 6);
            dado2 = aleatorio.Next(1, 6);
            puntuacion = dado1 + dado2;
            total = puntuacion;

            if (dado1 == 1 && dado2 == 1)
            {
                Console.WriteLine("Dado1:" + dado1 + "  Dado2:" + dado2 + "  Puntuación:" + puntuacion + "  Total:" + total + ".  Usted ha perdido el juego.");
                ans = "no";
            }
            else
            {
                Console.WriteLine("Dado1:" + dado1 + "  Dado2:" + dado2 + "  Puntuación:" + puntuacion + "  Total:" + total);
                Console.WriteLine("¿Desea sguir jugando? (si/no)");
                ans = Console.ReadLine();
            }

            if (puntuacion > 6)
                contadorSeis++;


            while (ans == "si")
            {
                dado1 = aleatorio.Next(1, 6);
                dado2 = aleatorio.Next(1, 6);
                puntuacion = dado1 + dado2;
                total += puntuacion;
                contadorTurnos++;

                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Dado1: " + dado1 + "  Dado2: " + dado2 + "  Ha perdido el juego.");
                    ans = "no";
                }
                else
                {
                    Console.WriteLine("Dado1:" + dado1 + "  Dado2: " + dado2 + "  Puntuación:" + puntuacion + "  Total:" + total);
                    Console.WriteLine("¿Continuar? (si/no)");
                    ans = Console.ReadLine();
                }

                if (puntuacion > 6)
                    contadorSeis++;

                if (total >= 100)
                {
                    Console.WriteLine("Has ganado");
                    
                }

                if (dado1 == dado2)
                {
                    contadorDobles++;

                    if (contadorDobles >= 3)
                    {
                        Console.WriteLine("Has ganado");
                        ans = "no";
                    }
                }

                else
                    contadorDobles = 0;

                if (ans == "no")
                    Console.WriteLine("Gracias por jugar.");

            }
            porcentajeSeis = Math.Round((((double)contadorSeis / contadorTurnos) * 100), 2);
            Console.WriteLine("Su total fue: " + total + ". El porcentaje de turnos con puntuacion mayor a 6: " + porcentajeSeis + "%");
        }
    }
}