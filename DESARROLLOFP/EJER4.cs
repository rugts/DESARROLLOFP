using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad N de alumnos: ");
            int N = int.Parse(Console.ReadLine());

            double[] notas = new double[N];
            double suma = 0, maxima = -1, minima = 21;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
                suma += notas[i];

                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }
            }

            double promedio = suma / N;
            Console.WriteLine($"\nPromedio de Notas: {promedio}");
            Console.WriteLine($"La máxima nota: {maxima}");
            Console.WriteLine($"La mínima nota: {minima}");

            Console.ReadLine();
        }
    }
}