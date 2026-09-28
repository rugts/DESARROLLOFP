using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de alumnos: ");
            int N = int.Parse(Console.ReadLine());

            int[] frecuencias = new int[21];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese la nota entera del alumno {i + 1} (0-20): ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 20)
                {
                    frecuencias[nota]++;
                }
            }

            int notaMasRepetida = 0;
            int maximaFrecuencia = 0;

            for (int i = 0; i <= 20; i++)
            {
                if (frecuencias[i] > maximaFrecuencia)
                {
                    maximaFrecuencia = frecuencias[i];
                    notaMasRepetida = i;
                }
            }

            Console.WriteLine($"\nLa nota que se repitió más veces fue: {notaMasRepetida}");
            Console.WriteLine($"Se repitió un total de {maximaFrecuencia} veces.");

            Console.ReadLine();
        }
    }
}