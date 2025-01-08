using System;
using System.Collections.Generic;

public class Ejercicio1
{
    private List<string> subjects;

    public Ejercicio1()
    {
        subjects = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    public void Run()
    {
        Console.WriteLine("Lista de asignaturas:");
        foreach (string subject in subjects)
        {
            Console.WriteLine(subject);
        }
    }
}


