using System;
using System.Collections.Generic;

public class Ejercicio4
{
    private List<int> awarded;

    public Ejercicio4()
    {
        awarded = new List<int>();
    }

    public void Run()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Introduce un número ganador: ");
            int number = int.Parse(Console.ReadLine());
            awarded.Add(number);
        }
        awarded.Sort();

        Console.WriteLine("Los números ganadores son: " + string.Join(", ", awarded));
    }
}
