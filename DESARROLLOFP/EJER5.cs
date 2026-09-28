using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Ingrese la cantidad de alumnos N (máximo 40): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 40);

            int[] notas = new int[N];
            int cantidad00 = 0, cantidad20 = 0, aprobados = 0, desaprobados = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ingrese la nota del alumno {i + 1}: ");
                notas[i] = int.Parse(Console.ReadLine());

                if (notas[i] == 0) cantidad00++;
                if (notas[i] == 20) cantidad20++;

                if (notas[i] >= 13)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine($"\nLa cantidad de personas que obtuvieron 00: {cantidad00}");
            Console.WriteLine($"La cantidad de personas que obtuvieron 20: {cantidad20}");
            Console.WriteLine($"La cantidad de personas aprobadas: {aprobados}");
            Console.WriteLine($"La cantidad de personas desaprobadas: {desaprobados}");

            Console.ReadLine();
        }
    }
}