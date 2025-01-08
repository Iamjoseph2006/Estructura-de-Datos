using System;
using System.Collections.Generic;

public class Ejercicio3
{
    // Se definen las listas para las asignaturas y las notas
    private List<string> subjects;  // Lista que almacenará las asignaturas
    private List<string> scores;    // Lista que almacenará las notas

    // Constructor que inicializa las listas
    public Ejercicio3()
    {
        // Inicialización de la lista de asignaturas con valores predefinidos
        subjects = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        // Inicialización de la lista de notas, que estará vacía al principio
        scores = new List<string>();
    }

    // Método Run que maneja la interacción con el usuario
    public void Run()
    {
        // Bucle que recorre cada asignatura y pide la nota al usuario
        foreach (string subject in subjects)
        {
            // Imprime un mensaje pidiendo la nota de la asignatura actual
            Console.Write("¿Qué nota has sacado en " + subject + "? ");
            
            // Lee la respuesta del usuario (nota) y la almacena en la variable 'score'
            string score = Console.ReadLine();
            
            // Agrega la nota ingresada a la lista 'scores'
            scores.Add(score);
        }

        // Bucle que recorre las asignaturas y las notas para imprimir los resultados
        for (int i = 0; i < subjects.Count; i++)
        {
            // Imprime el nombre de la asignatura junto con la nota obtenida por el usuario
            Console.WriteLine($"En {subjects[i]} has sacado {scores[i]}");
        }
    }
}
