using System;
using System.Collections.Generic;

public class Ejercicio2
{
    // Método Run que será llamado para mostrar los mensajes de estudio
    public void Run()
    {
        // Definir e inicializar una lista de asignaturas
        // Cada asignatura se agrega a la lista de forma explícita
        List<string> subjects = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Recorre cada asignatura de la lista y muestra el mensaje correspondiente
        foreach (string subject in subjects)
        {
            // Imprime el mensaje "Yo estudio <nombre de la asignatura>" en consola
            Console.WriteLine("Yo estudio " + subject);
        }
    }
}



