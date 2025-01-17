using System;

// Definición de la clase NodoInvertir que representa un nodo en la lista enlazada
public class NodoInvertir
{
    public int Contenido; // Almacena el dato del nodo (en este caso un número entero)
    public NodoInvertir NodoSiguiente; // Referencia al siguiente nodo en la lista

    // Constructor que inicializa un nodo con un valor dado
    public NodoInvertir(int contenido)
    {
        Contenido = contenido; // Asigna el valor al dato del nodo
        NodoSiguiente = null; // Inicializa la referencia al siguiente nodo como null
    }
}

// Definición de la clase ListaEnlazadaInvertir que representa una lista enlazada
public class ListaEnlazadaInvertir
{
    private NodoInvertir primerNodo; // Almacena la referencia al primer nodo de la lista

    // Constructor de la lista enlazada, inicializa el primer nodo como null
    public ListaEnlazadaInvertir()
    {
        primerNodo = null; // Inicializa la lista vacía (sin nodos)
    }

    // Método para agregar un nuevo nodo con un dato al final de la lista
    public void AgregarDato(int contenido)
    {
        // Crear un nuevo nodo con el dato proporcionado
        NodoInvertir nuevoNodo = new NodoInvertir(contenido);

        // Si la lista está vacía, el nuevo nodo será el primer nodo
        if (primerNodo == null)
        {
            primerNodo = nuevoNodo;
        }
        else
        {
            // Si la lista no está vacía, recorrer hasta el último nodo y agregar el nuevo nodo
            NodoInvertir actual = primerNodo;
            while (actual.NodoSiguiente != null)
            {
                actual = actual.NodoSiguiente; // Avanzar al siguiente nodo
            }
            // Establecer el siguiente nodo del último nodo como el nuevo nodo
            actual.NodoSiguiente = nuevoNodo;
        }
    }

    // Método para invertir el orden de los nodos en la lista
    public void InvertirLista()
    {
        NodoInvertir anterior = null; // Nodo anterior al nodo actual
        NodoInvertir actual = primerNodo; // Nodo actual que se va a invertir
        NodoInvertir siguiente = null; // Nodo que apunta al siguiente nodo

        // Recorrer la lista y cambiar las referencias de los nodos
        while (actual != null)
        {
            siguiente = actual.NodoSiguiente; // Guardar el siguiente nodo
            actual.NodoSiguiente = anterior; // Invertir la dirección del enlace
            anterior = actual; // Avanzar el nodo anterior al nodo actual
            actual = siguiente; // Avanzar al siguiente nodo
        }
        primerNodo = anterior; // El último nodo procesado es el nuevo primer nodo de la lista
    }

    // Método para mostrar todos los elementos de la lista en consola
    public void MostrarLista()
    {
        NodoInvertir actual = primerNodo; // Comenzar desde el primer nodo de la lista

        // Recorrer la lista y mostrar los valores de los nodos
        while (actual != null)
        {
            Console.Write(actual.Contenido + " "); // Mostrar el dato del nodo
            actual = actual.NodoSiguiente; // Avanzar al siguiente nodo
        }
        Console.WriteLine(); // Salto de línea después de mostrar todos los elementos
    }
}

