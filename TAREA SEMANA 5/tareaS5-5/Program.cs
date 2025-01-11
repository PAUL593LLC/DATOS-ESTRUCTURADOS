using System;
using System.Collections.Generic;

namespace NumerosInversos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los números del 1 al 10
            List<int> numeros = new List<int>();

            // Llenar la lista con los números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            // Mostrar los números en orden inverso, separados por comas
            Console.WriteLine("Números del 1 al 10 en orden inverso:");
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                // Imprimir el número, seguido de una coma si no es el último
                if (i > 0)
                {
                    Console.Write(numeros[i] + ", ");
                }
                else
                {
                    Console.Write(numeros[i]); // Imprimir el último número sin coma
                }
            }

            // Esperar entrada del usuario antes de cerrar
            Console.WriteLine("\n\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
