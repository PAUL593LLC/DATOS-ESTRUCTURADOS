using System;
using System.Collections.Generic;

namespace GestionNotas
{
    // Clase que representa un curso
    public class Curso
    {
        // Lista de asignaturas y notas
        private List<string> asignaturas;
        private List<double> notas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>();
            notas = new List<double>();
        }

        // Método para agregar una asignatura
        public void AgregarAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        // Método para ingresar las notas de cada asignatura
        public void IngresarNotas()
        {
            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Introduce la nota para {asignatura}: ");
                double nota;
                while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                {
                    Console.Write("Nota inválida. Por favor, introduce una nota entre 0 y 10: ");
                }
                notas.Add(nota);
            }
        }

        // Método para mostrar las asignaturas con sus respectivas notas
        public void MostrarNotas()
        {
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Curso
            Curso curso = new Curso();

            // Agregar asignaturas
            curso.AgregarAsignatura("Matemáticas");
            curso.AgregarAsignatura("Física");
            curso.AgregarAsignatura("Química");
            curso.AgregarAsignatura("Historia");
            curso.AgregarAsignatura("Lengua");

            // Ingresar las notas para cada asignatura
            curso.IngresarNotas();

            // Mostrar las notas correspondientes a cada asignatura
            curso.MostrarNotas();

            // Esperar entrada del usuario antes de cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
