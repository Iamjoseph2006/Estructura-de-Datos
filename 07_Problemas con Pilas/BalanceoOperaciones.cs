using System;
using System.Collections.Generic;

public class BalanceoOperaciones
{
    /// <summary>
    /// Verifica si una fórmula matemática está correctamente balanceada.
    /// </summary>
    /// <param name="formula">Cadena que representa la fórmula matemática.</param>
    /// <returns>True si está balanceada, False en caso contrario.</returns>
    public static bool VerificarBalanceo(string formula)
    {
        Stack<char> pila = new Stack<char>(); // Pila para almacenar los paréntesis.

        // Recorrer cada carácter de la fórmula.
        foreach (char c in formula)
        {
            // Abrimos un bloque si encontramos un paréntesis de apertura.
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía al encontrar un paréntesis de cierre, no está balanceada.
                if (pila.Count == 0) return false;

                // Verificamos que el paréntesis de apertura coincida con el de cierre.
                char tope = pila.Pop();
                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    return false;
                }
            }
        }

        // Si la pila está vacía al final, está balanceada.
        return pila.Count == 0;
    }
}
