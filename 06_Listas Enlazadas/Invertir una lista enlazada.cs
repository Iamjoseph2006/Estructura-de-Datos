using System;

public class NodoInvertir
{
    public int Contenido; // Cambiado de "Valor" a "Contenido"
    public NodoInvertir NodoSiguiente; // Cambiado de "Siguiente" a "NodoSiguiente"

    public NodoInvertir(int contenido)
    {
        Contenido = contenido;
        NodoSiguiente = null;
    }
}

public class ListaEnlazadaInvertir
{
    private NodoInvertir primerNodo; // Cambiado de "cabeza" a "primerNodo"

    public ListaEnlazadaInvertir()
    {
        primerNodo = null;
    }

    public void AgregarDato(int contenido)
    {
        NodoInvertir nuevoNodo = new NodoInvertir(contenido);
        if (primerNodo == null)
        {
            primerNodo = nuevoNodo;
        }
        else
        {
            NodoInvertir actual = primerNodo;
            while (actual.NodoSiguiente != null)
            {
                actual = actual.NodoSiguiente;
            }
            actual.NodoSiguiente = nuevoNodo;
        }
    }

    public void InvertirLista()
    {
        NodoInvertir anterior = null;
        NodoInvertir actual = primerNodo;
        NodoInvertir siguiente = null;

        while (actual != null)
        {
            siguiente = actual.NodoSiguiente;
            actual.NodoSiguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        primerNodo = anterior;
    }

    public void MostrarLista()
    {
        NodoInvertir actual = primerNodo;
        while (actual != null)
        {
            Console.Write(actual.Contenido + " ");
            actual = actual.NodoSiguiente;
        }
        Console.WriteLine();
    }
}
