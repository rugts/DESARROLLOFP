using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Ingrese el número de personas N (máximo 100): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 100);

            int[] edades = new int[N];
            Random rnd = new Random();
            int menor = 999;
            int posMenor = -1;
            int contador30a50 = 0;

            Console.WriteLine("\nListado de edades generadas:");
            for (int i = 0; i < N; i++)
            {
                edades[i] = rnd.Next(1, 101);
                Console.Write($"{edades[i]} ");

                if (edades[i] < menor)
                {
                    menor = edades[i];
                    posMenor = i;
                }

                if (edades[i] >= 30 && edades[i] <= 50)
                {
                    contador30a50++;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"\nLa menor edad es {menor} y está en la posición {posMenor}");
            Console.WriteLine($"Personas que tienen entre 30 y 50 años: {contador30a50}");

            Console.Write("\nIngrese una edad a buscar en el arreglo: ");
            int buscar = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < N; i++)
            {
                if (edades[i] == buscar)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("La edad SÍ se encontró en el arreglo.");
            }
            else
            {
                Console.WriteLine("La edad NO se encontró en el arreglo.");
            }

            Console.ReadLine();
        }
    }
}