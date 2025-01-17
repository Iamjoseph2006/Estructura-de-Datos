using System;

public class NodoContar
{
    public int Dato; // Cambiado de "Valor" a "Dato"
    public NodoContar SiguienteNodo; // Cambiado de "Siguiente" a "SiguienteNodo"

    public NodoContar(int dato)
    {
        Dato = dato;
        SiguienteNodo = null;
    }
}

public class ListaEnlazadaContar
{
    private NodoContar inicio; // Cambiado de "cabeza" a "inicio"

    public ListaEnlazadaContar()
    {
        inicio = null;
    }

    public void AgregarElemento(int dato)
    {
        NodoContar nuevoNodo = new NodoContar(dato);
        if (inicio == null)
        {
            inicio = nuevoNodo;
        }
        else
        {
            NodoContar actual = inicio;
            while (actual.SiguienteNodo != null)
            {
                actual = actual.SiguienteNodo;
            }
            actual.SiguienteNodo = nuevoNodo;
        }
    }

    public int ContarElementos()
    {
        int contador = 0;
        NodoContar actual = inicio;
        while (actual != null)
        {
            contador++;
            actual = actual.SiguienteNodo;
        }
        return contador;
    }

    public void MostrarLista()
    {
        NodoContar actual = inicio;
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.SiguienteNodo;
        }
        Console.WriteLine();
    }
}
