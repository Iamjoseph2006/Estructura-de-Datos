using System;
using System.Collections.Generic;

public class Ejercicio3
{
    private List<string> subjects;
    private List<string> scores;

    public Ejercicio3()
    {
        subjects = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        scores = new List<string>();
    }

    public void Run()
    {
        foreach (string subject in subjects)
        {
            Console.Write("¿Qué nota has sacado en " + subject + "? ");
            string score = Console.ReadLine();
            scores.Add(score);
        }

        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine($"En {subjects[i]} has sacado {scores[i]}");
        }
    }
}
