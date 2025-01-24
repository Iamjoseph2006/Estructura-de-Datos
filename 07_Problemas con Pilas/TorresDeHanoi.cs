using System;
using System.Collections.Generic;

public class TorresDeHanoi
{
    /// <summary>
    /// Soluciona el problema de las Torres de Hanoi usando pilas.
    /// </summary>
    /// <param name="n">Número de discos.</param>
    /// <param name="origen">Nombre de la torre de origen.</param>
    /// <param name="destino">Nombre de la torre de destino.</param>
    /// <param name="auxiliar">Nombre de la torre auxiliar.</param>
    public static void Resolver(int n, string origen, string destino, string auxiliar)
    {
        // Condición base: si solo hay un disco, se mueve directamente al destino.
        if (n == 1)
        {
            Console.WriteLine($"Mover disco de {origen} a {destino}");
            return;
        }

        // Paso 1: Mover n-1 discos del origen al auxiliar.
        Resolver(n - 1, origen, auxiliar, destino);

        // Paso 2: Mover el disco restante al destino.
        Console.WriteLine($"Mover disco de {origen} a {destino}");

        // Paso 3: Mover los n-1 discos del auxiliar al destino.
        Resolver(n - 1, auxiliar, destino, origen);
    }
}
