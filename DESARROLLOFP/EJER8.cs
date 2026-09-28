using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorEjemplo1 = { 36, 32, 6849, 5, 68, 12, 7, 1 };

            int[] vectorEjemplo2 = { 35, 22, 68, 49, 5, 68, 11, 7, 1 };
            ProcesarVector(vectorEjemplo1, 1);
            Console.WriteLine();
            ProcesarVector(vectorEjemplo2, 2);

            Console.ReadLine();
        }
        static void ProcesarVector(int[] numeros, int numeroEjemplo)
        {
            int contadorDivisibles = 0;

            Console.WriteLine($"Ejemplo {numeroEjemplo}:");
            Console.Write("Datos del Vector: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
                int sumaDigitos = SUMADIG(numeros[i]);
                if (sumaDigitos % 3 == 0)
                {
                    contadorDivisibles++;
                }
            }

            Console.WriteLine($". Hay {contadorDivisibles} datos divisibles entre 3");
        }

        static int SUMADIG(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma = suma + (numero % 10);
                numero = numero / 10;
            }
            return suma;
        }
    }
}