using System;

namespace Ejercicio2
{
    class ejer2
    {
        static void Main(string[] args)
        {
            double[] pesos = new double[10];
            double suma = 0, maximo = 0;
            int delgadas = 0, medianas = 0, gruesas = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el peso en kilos del cliente {i + 1}: ");
                pesos[i] = double.Parse(Console.ReadLine());
                suma += pesos[i];

                if (pesos[i] > maximo)
                {
                    maximo = pesos[i];
                }

                if (pesos[i] < 53)
                {
                    delgadas++;
                }
                else if (pesos[i] >= 53 && pesos[i] <= 60)
                {
                    medianas++;
                }
                else if (pesos[i] > 60)
                {
                    gruesas++;
                }
            }

            Console.WriteLine($"\nEl peso promedio es: {suma / 10}");
            Console.WriteLine($"El peso de la persona que pesa más es: {maximo}");
            Console.WriteLine($"Número de personas de contextura delgada: {delgadas}");
            Console.WriteLine($"Número de personas de contextura mediana: {medianas}");
            Console.WriteLine($"Número de personas de contextura gruesa: {gruesas}");
            
            Console.ReadLine();
        }
    }
}