using System;
using System.Collections.Generic;

public class Ejercicio4
{
    // Se define la lista que almacenará los números ganadores
    private List<int> awarded;

    // Constructor que inicializa la lista de números ganadores
    public Ejercicio4()
    {
        // Inicializa la lista 'awarded' vacía
        awarded = new List<int>();
    }

    // Método Run que maneja la interacción con el usuario
    public void Run()
    {
        // Bucle que se ejecuta 6 veces, solicitando un número ganador en cada iteración
        for (int i = 0; i < 6; i++)
        {
            // Muestra un mensaje solicitando al usuario que ingrese un número
            Console.Write("Introduce un número ganador: ");
            
            // Lee la entrada del usuario, la convierte a un número entero y lo almacena en la variable 'number'
            int number = int.Parse(Console.ReadLine());
            
            // Agrega el número ingresado a la lista 'awarded'
            awarded.Add(number);
        }

        // Ordena la lista 'awarded' en orden ascendente
        awarded.Sort();

        // Muestra los números ganadores ordenados como una cadena, separándolos por comas
        Console.WriteLine("Los números ganadores son: " + string.Join(", ", awarded));
    }
}

