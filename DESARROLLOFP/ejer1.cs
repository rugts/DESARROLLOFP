using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[6];
            int suma = 0;
            int menor = 21;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                notas[i] = int.Parse(Console.ReadLine());
                suma += notas[i];

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            double promedio = (suma - menor) / 5.0;

            Console.WriteLine($"\nLa nota que no se considera en el promedio seria {menor}");
            Console.WriteLine($"El promedio de notas del alumno es: {promedio}");

            Console.ReadLine();
        }
    }
}