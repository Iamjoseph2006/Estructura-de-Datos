using System;
using System.Collections.Generic;

public class Ejercicio5
{
    private List<int> numbers;

    public Ejercicio5()
    {
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    public void Run()
    {
        for (int i = 1; i <= numbers.Count; i++)
        {
            Console.Write(numbers[numbers.Count - i]);
            if (i < numbers.Count)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(); // Para finalizar la línea
    }
}
