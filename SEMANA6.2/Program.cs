using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    public Node Head;

    public void Prepend(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Head;
        Head = newNode;
    }

    public int Count()
    {
        Node current = Head;
        int count = 0;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    public bool Compare(LinkedList otherList)
    {
        Node current1 = this.Head;
        Node current2 = otherList.Head;

        while (current1 != null && current2 != null)
        {
            if (current1.Data != current2.Data)
            {
                return false; // Los datos no son iguales
            }
            current1 = current1.Next;
            current2 = current2.Next;
        }

        // Verificar si ambas listas han terminado
        return current1 == null && current2 == null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();

        // Cargar datos en la primera lista
        Console.WriteLine("Cargar datos en la primera lista (ingrese -1 para terminar):");
        while (true)
        {
            Console.Write("Ingrese un número entero: ");
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break; // Termina la carga si se ingresa -1
            list1.Prepend(input);
        }

        // Cargar datos en la segunda lista
        Console.WriteLine("Cargar datos en la segunda lista (ingrese -1 para terminar):");
        while (true)
        {
            Console.Write("Ingrese un número entero: ");
            int input = int.Parse(Console.ReadLine());
            if (input == -1) break; // Termina la carga si se ingresa -1
            list2.Prepend(input);
        }

        // Comparar las listas
        int size1 = list1.Count();
        int size2 = list2.Count();
        bool areEqual = list1.Compare(list2);

        // Mostrar resultados
        if (areEqual && size1 == size2)
        {
            Console.WriteLine("Las listas son iguales en tamaño y en contenido.");
        }
        else if (size1 == size2)
        {
            Console.WriteLine("Las listas son iguales en tamaño pero no en contenido.");
        }
        else
        {
            Console.WriteLine("Las listas no tienen el mismo tamaño ni contenido.");
        }
    }
}