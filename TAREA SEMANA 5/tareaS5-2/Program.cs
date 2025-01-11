using System;
using System.Collections.Generic;

namespace GestionAsignaturas
{
    // Clase que representa un curso
    public class Curso
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>();
        }

        // Método para agregar una asignatura
        public void AgregarAsignatura(string asignatura)
        {
            asignaturas.Add(asignatura);
        }

        // Método para mostrar las asignaturas con el mensaje personalizado
        public void MostrarAsignaturas()
        {
            foreach (var asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}.");
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

            // Mostrar las asignaturas con el mensaje personalizado
            curso.MostrarAsignaturas();

            // Esperar entrada del usuario antes de cerrar
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
