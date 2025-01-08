using System;
using System.Collections.Generic;

public class Ejercicio5
{
    // Se define una lista de enteros llamada 'numbers' que contiene los números del 1 al 10
    private List<int> numbers;

    // Constructor de la clase Ejercicio5
    public Ejercicio5()
    {
        // Inicializa la lista 'numbers' con los números del 1 al 10
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    // Método Run que contiene la lógica para mostrar los números en orden inverso
    public void Run()
    {
        // Bucle que recorre la lista de números en orden inverso
        for (int i = 1; i <= numbers.Count; i++)
        {
            // Imprime el número en la posición 'numbers.Count - i', que es el índice correspondiente en orden inverso
            Console.Write(numbers[numbers.Count - i]);

            // Si no es el último número, imprime una coma y un espacio para separar los números
            if (i < numbers.Count)
            {
                Console.Write(", ");
            }
        }

        // Imprime una nueva línea al final para que la salida esté limpia
        Console.WriteLine();
    }
}
