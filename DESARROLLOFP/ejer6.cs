using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Ingrese el número de personas N (máximo 200): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 200);

            int[] montos = new int[N];
            Random rnd = new Random();
            int gasto100y300 = 0, cantidadImpares = 0;

            Console.WriteLine("\nListado de los N montos generados al azar:");
            for (int i = 0; i < N; i++)
            {
                montos[i] = rnd.Next(25, 501);
                Console.Write($"{montos[i]} ");

                if (montos[i] >= 100 && montos[i] <= 300)
                {
                    gasto100y300++;
                }
                if (montos[i] % 2 != 0)
                {
                    cantidadImpares++;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - 1 - i; j++)
                {
                    if (montos[j] > montos[j + 1])
                    {
                        int temp = montos[j];
                        montos[j] = montos[j + 1];
                        montos[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nListado ordenado ascendentemente de los N montos:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{montos[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine($"\nNúmero de personas que gastaron entre 100 y 300 soles: {gasto100y300}");
            Console.WriteLine($"Cantidad de montos que tienen asociada una cantidad impar: {cantidadImpares}");

            Console.ReadLine();
        }
    }
}