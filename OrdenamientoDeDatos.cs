using System;

namespace OrdenamientoDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuco", "Tanjiro", "Zenitsu", "Tnozuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            for (int j = 0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        string temporalnombre = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = temporalnombre;
                    }
                }
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " tiene una estatura de:" + estatura[i]);
            }
        }
    }
}
