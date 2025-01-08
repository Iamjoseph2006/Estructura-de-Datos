using System;

class Program
{
    static void Main()
    {
        while (true) // Bucle para mostrar el menú de manera continua
        {
            // Mostrar opciones del menú principal
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Productos");
            Console.WriteLine("2. Tipos de Datos");
            Console.WriteLine("3. Ejercicios");
            Console.WriteLine("4. Salir");

            // Leer la opción del usuario en la variable 'option'
            string option = Console.ReadLine();

            // Procesar la opción seleccionada
            switch (option)
            {
                case "1":
                    // Llama al método que manejará productos
                    Console.WriteLine("Has seleccionado la opción de Productos.");
                    break;

                case "2":
                    // Llama al método de tipos de datos
                    Console.WriteLine("Has seleccionado la opción de Tipos de Datos.");
                    break;

                case "3":
                    // Mostrar submenú de ejercicios
                    MostrarEjercicios();
                    break;

                case "4":
                    Console.WriteLine("\nSaliendo del programa...");
                    return; // Sale del bucle y termina el programa

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Método que muestra el submenú de ejercicios
    static void MostrarEjercicios()
    {
        while (true)
        {
            // Mostrar opciones de ejercicios
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar Asignaturas");
            Console.WriteLine("2. Mostrar Asignatura Estudia");
            Console.WriteLine("3. Mostrar Notas de Asignaturas");
            Console.WriteLine("4. Mostrar Números Ganadores");
            Console.WriteLine("5. Mostrar Números en Orden Inverso");
            Console.WriteLine("6. Salir");

            // Leer la opción del usuario en la variable 'ejercicioOption'
            string ejercicioOption = Console.ReadLine();

            // Procesar la opción seleccionada
            switch (ejercicioOption)
            {
                case "1":
                    Console.WriteLine("Has Seleccionado el Ejercicio 1");
                    Console.WriteLine("Asignaturas");
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Run(); // Llamada a Ejercicio 1
                    break;

                case "2":
                    Console.WriteLine("Has Seleccionado el Ejercicio 2");
                    Console.WriteLine("Que Asignatura Estudia");
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Run(); // Llamada a Ejercicio 2
                    break;

                case "3":
                    Console.WriteLine("Has Seleccionado el Ejercicio 3");
                    Console.WriteLine("Notas de Asignaturas");
                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    ejercicio3.Run(); // Llamada a Ejercicio 3
                    break;

                case "4":
                    Console.WriteLine("Has Seleccionado el Ejercicio 4");
                    Console.WriteLine("Números Ganadores");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Run(); // Llamada a Ejercicio 4
                    break;

                case "5":
                    Console.WriteLine("Has Seleccionado el Ejercicio 5");
                    Console.WriteLine("Números en Orden Inverso");
                    Ejercicio5 ejercicio5 = new Ejercicio5();
                    ejercicio5.Run(); // Llamada a Ejercicio 5
                    break;

                case "6":
                    // Volver al menú principal
                    return;

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}

