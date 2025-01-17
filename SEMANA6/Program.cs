using System;

class Nodo
{
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Método para agregar un nuevo nodo al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            // Si la lista está vacía, el nuevo nodo es la cabeza
            cabeza = nuevoNodo;
        }
        else
        {
            // Recorrer la lista hasta encontrar el último nodo
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para invertir la lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;

        while (actual != null)
        {
            Nodo siguiente = actual.Siguiente; // Guardar el siguiente nodo
            actual.Siguiente = anterior;      // Invertir el enlace
            anterior = actual;                // Mover el puntero anterior
            actual = siguiente;               // Mover el puntero actual
        }

        cabeza = anterior; // Actualizar la cabeza de la lista al nuevo inicio
    }

    // Método para mostrar los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("None"); // Indicar el final de la lista
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);
        lista.Agregar(4);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
