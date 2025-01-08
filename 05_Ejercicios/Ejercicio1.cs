using System;
using System.Collections.Generic;

public class Ejercicio1
{
    // Lista privada que almacenará las asignaturas
    private List<string> subjects;

    // Constructor de la clase Ejercicio1
    // Inicializa la lista subjects con un conjunto de asignaturas predeterminadas
    public Ejercicio1()
    {
        // Se inicializa la lista subjects con las asignaturas
        subjects = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    // Método Run que será llamado para mostrar las asignaturas
    public void Run()
    {
        // Imprime el mensaje indicando que se mostrará la lista de asignaturas
        Console.WriteLine("Lista de asignaturas:");

        // Recorre cada asignatura en la lista subjects
        foreach (string subject in subjects)
        {
            // Imprime cada asignatura en una nueva línea
            Console.WriteLine(subject);
        }
    }
}



