using System;
using System.Collections.Generic;

namespace LoteriaPrimitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los números ganadores
            List<int> numerosGanadores = new List<int>();
            const int cantidadNumeros = 6; // Cantidad de números a ingresar

            Console.WriteLine($"Por favor, introduce {cantidadNumeros} números ganadores de la lotería primitiva (del 1 al 49):");

            while (numerosGanadores.Count < cantidadNumeros)
            {
                Console.Write($"Introduce el número {numerosGanadores.Count + 1}: ");
                int numero;

                // Validar la entrada del usuario
                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 49 || numerosGanadores.Contains(numero))
                {
                    Console.Write("Número inválido. Por favor, introduce un número entre 1 y 49 que no haya sido ingresado: ");
                }

                // Agregar el número a la lista
                numerosGanadores.Add(numero);
            }

            // Ordenar la lista de números ganadores
            numerosGanadores.Sort();

            // Mostrar los números ganadores ordenados
            Console.WriteLine("\nNúmeros ganadores ordenados de menor a mayor:");
            foreach (var num in numerosGanadores)
            {
                Console.WriteLine(num);
            }

            // Esperar entrada del usuario antes de cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
