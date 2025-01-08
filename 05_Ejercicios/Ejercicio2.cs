using System;
using System.Collections.Generic;

public class Ejercicio2
{
    public void Run()
    {
        // Definir la lista de asignaturas
        List<string> subjects = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Recorrer cada asignatura e imprimir el mensaje
        foreach (string subject in subjects)
        {
            Console.WriteLine("Yo estudio " + subject);
        }
    }
}


