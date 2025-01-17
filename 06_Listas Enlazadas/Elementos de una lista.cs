using System;

// Definición de la clase NodoContar que representa un nodo en la lista enlazada
public class NodoContar
{
    public int Dato; // Almacena el dato del nodo (en este caso un número entero)
    public NodoContar SiguienteNodo; // Referencia al siguiente nodo en la lista

    // Constructor que inicializa un nodo con un valor dado
    public NodoContar(int dato)
    {
        Dato = dato; // Asigna el valor al dato del nodo
        SiguienteNodo = null; // Inicializa la referencia al siguiente nodo como null
    }
}

// Definición de la clase ListaEnlazadaContar que representa una lista enlazada
public class ListaEnlazadaContar
{
    private NodoContar inicio; // Almacena la referencia al primer nodo de la lista

    // Constructor de la lista enlazada, inicializa el primer nodo como null
    public ListaEnlazadaContar()
    {
        inicio = null; // Inicializa la lista vacía (sin nodos)
    }

    // Método para agregar un nuevo nodo con un dato al final de la lista
    public void AgregarElemento(int dato)
    {
        // Crear un nuevo nodo con el dato proporcionado
        NodoContar nuevoNodo = new NodoContar(dato);

        // Si la lista está vacía, el nuevo nodo será el primer nodo
        if (inicio == null)
        {
            inicio = nuevoNodo;
        }
        else
        {
            // Si la lista no está vacía, recorrer hasta el último nodo y agregar el nuevo nodo
            NodoContar actual = inicio;
            while (actual.SiguienteNodo != null)
            {
                actual = actual.SiguienteNodo; // Avanzar al siguiente nodo
            }
            // Establecer el siguiente nodo del último nodo como el nuevo nodo
            actual.SiguienteNodo = nuevoNodo;
        }
    }

    // Método para contar la cantidad de elementos (nodos) en la lista
    public int ContarElementos()
    {
        int contador = 0; // Variable para contar los elementos
        NodoContar actual = inicio; // Comenzar desde el primer nodo de la lista

        // Recorrer la lista hasta el final (cuando el siguiente nodo es null)
        while (actual != null)
        {
            contador++; // Aumentar el contador por cada nodo encontrado
            actual = actual.SiguienteNodo; // Avanzar al siguiente nodo
        }
        return contador; // Retornar el número total de nodos
    }

    // Método para mostrar todos los elementos de la lista en consola
    public void MostrarLista()
    {
        NodoContar actual = inicio; // Comenzar desde el primer nodo de la lista

        // Recorrer la lista y mostrar los valores de los nodos
        while (actual != null)
        {
            Console.Write(actual.Dato + " "); // Mostrar el dato del nodo
            actual = actual.SiguienteNodo; // Avanzar al siguiente nodo
        }
        Console.WriteLine(); // Salto de línea después de mostrar todos los elementos
    }
}
