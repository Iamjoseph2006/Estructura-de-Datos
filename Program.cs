using System;

class Program
{
    // Método principal de la aplicación
    static void Main()
    {
        // Bucle infinito para mostrar el menú de manera continua
        while (true)
        {
            // Mostrar las opciones del menú principal
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Productos");
            Console.WriteLine("2. Tipos de Datos");
            Console.WriteLine("3. Ejercicios");
            Console.WriteLine("4. Salir");

            // Leer la opción del usuario en la variable 'option'
            string option = Console.ReadLine();

            // Procesar la opción seleccionada con una estructura switch
            switch (option)
            {
                case "1":
                    // Si el usuario selecciona '1', muestra un mensaje relacionado con productos
                    Console.WriteLine("Has seleccionado la opción de Productos.");
                    break;

                case "2":
                    // Si el usuario selecciona '2', muestra un mensaje relacionado con tipos de datos
                    Console.WriteLine("Has seleccionado la opción de Tipos de Datos.");
                    break;

                case "3":
                    // Si el usuario selecciona '3', se llama al método MostrarEjercicios que muestra un submenú
                    MostrarEjercicios();
                    break;

                case "4":
                    // Si el usuario selecciona '4', sale del programa
                    Console.WriteLine("\nSaliendo del programa...");
                    return; // Sale del bucle y termina la ejecución del programa

                default:
                    // Si el usuario ingresa una opción no válida, se muestra un mensaje de error
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Método que muestra un submenú con opciones relacionadas con ejercicios
    static void MostrarEjercicios()
    {
        // Bucle infinito para mostrar el submenú de ejercicios
        while (true)
        {
            // Mostrar las opciones del submenú
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar Asignaturas");
            Console.WriteLine("2. Mostrar Asignatura Estudia");
            Console.WriteLine("3. Mostrar Notas de Asignaturas");
            Console.WriteLine("4. Mostrar Números Ganadores");
            Console.WriteLine("5. Mostrar Números en Orden Inverso");
            Console.WriteLine("6. Salir");

            // Leer la opción seleccionada por el usuario en la variable 'ejercicioOption'
            string ejercicioOption = Console.ReadLine();

            // Procesar la opción seleccionada con una estructura switch
            switch (ejercicioOption)
            {
                case "1":
                    // Si el usuario selecciona '1', muestra el Ejercicio 1 y lo ejecuta
                    Console.WriteLine("Has Seleccionado el Ejercicio 1");
                    Console.WriteLine("Asignaturas");
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Run(); // Llamada a Ejercicio 1
                    break;

                case "2":
                    // Si el usuario selecciona '2', muestra el Ejercicio 2 y lo ejecuta
                    Console.WriteLine("Has Seleccionado el Ejercicio 2");
                    Console.WriteLine("Qué Asignatura Estudia");
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Run(); // Llamada a Ejercicio 2
                    break;

                case "3":
                    // Si el usuario selecciona '3', muestra el Ejercicio 3 y lo ejecuta
                    Console.WriteLine("Has Seleccionado el Ejercicio 3");
                    Console.WriteLine("Notas de Asignaturas");
                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    ejercicio3.Run(); // Llamada a Ejercicio 3
                    break;

                case "4":
                    // Si el usuario selecciona '4', muestra el Ejercicio 4 y lo ejecuta
                    Console.WriteLine("Has Seleccionado el Ejercicio 4");
                    Console.WriteLine("Números Ganadores");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Run(); // Llamada a Ejercicio 4
                    break;

                case "5":
                    // Si el usuario selecciona '5', muestra el Ejercicio 5 y lo ejecuta
                    Console.WriteLine("Has Seleccionado el Ejercicio 5");
                    Console.WriteLine("Números en Orden Inverso");
                    Ejercicio5 ejercicio5 = new Ejercicio5();
                    ejercicio5.Run(); // Llamada a Ejercicio 5
                    break;

                case "6":
                    // Si el usuario selecciona '6', vuelve al menú principal
                    return;

                default:
                    // Si el usuario ingresa una opción no válida en el submenú, muestra un mensaje de error
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}

