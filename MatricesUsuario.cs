using System;

namespace MatricesUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-" };
            int n = 10;
            int m = 15;
            string ans = "";

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                }

            }

            //ENTRADA
            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }

                Console.Write("|\n");
            }

            Console.WriteLine("¿Desea reemplazar un espacio vacio por una X? (si/no) ");
            ans = Console.ReadLine();

            while (ans == "si")
            {
                Console.WriteLine("Indique la fila en la que desea ubicar la X: ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique la que columna en la que desea ubicar la X: ");
                int b = int.Parse(Console.ReadLine());

                if (salida[a, b] == "X")
                {
                    Console.WriteLine("La posicion (" + a + "," + b + ") ya está ocupada, porfavor seleccione una celda vacia");
                }

                if (tablero[a, b] == "-")
                {
                    salida[a, b] = "X";
                }

                //SALIDA
                Console.WriteLine("\nSALIDA: ");
                for (int i = 0; i < tablero.GetLength(0); i++)
                {
                    for (int j = 0; j < tablero.GetLength(1); j++)
                    {
                        Console.Write("|" + salida[i, j]);
                    }
                    Console.Write("|\n");
                }
            }
        }
    }
}
