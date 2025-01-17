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
            Console.WriteLine("4. Agenda de Turnos");
            Console.WriteLine("5. Ejercicios de Listas");
            Console.WriteLine("6. Salir");

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
                    // Llamar al método de gestionar agenda de turnos
                    AgendaTurno agendaTurno = new AgendaTurno();
                    agendaTurno.GestionarAgenda(); // Llamar al método de AgendaTurno
                    break;

                case "5":
                    // Llamar al método para gestionar los ejercicios de listas enlazadas
                    GestionarListasEnlazadas();
                    break;

                case "6":
                    Console.WriteLine("\nSaliendo del programa...");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
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
                    Console.WriteLine("Has Seleccionado el Ejercicio 1");
                    Console.WriteLine("Asignaturas");
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Run();
                    break;

                case "2":
                    Console.WriteLine("Has Seleccionado el Ejercicio 2");
                    Console.WriteLine("Qué Asignatura Estudia");
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Run();
                    break;

                case "3":
                    Console.WriteLine("Has Seleccionado el Ejercicio 3");
                    Console.WriteLine("Notas de Asignaturas");
                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    ejercicio3.Run();
                    break;

                case "4":
                    Console.WriteLine("Has Seleccionado el Ejercicio 4");
                    Console.WriteLine("Números Ganadores");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Run();
                    break;

                case "5":
                    Console.WriteLine("Has Seleccionado el Ejercicio 5");
                    Console.WriteLine("Números en Orden Inverso");
                    Ejercicio5 ejercicio5 = new Ejercicio5();
                    ejercicio5.Run();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Método para gestionar los ejercicios de listas enlazadas
    static void GestionarListasEnlazadas()
    {
        Console.WriteLine("\nSeleccione el ejercicio:");
        Console.WriteLine("1. Contar Elementos en una Lista Enlazada");
        Console.WriteLine("2. Invertir una Lista Enlazada");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            // Ejercicio para contar elementos en una lista enlazada
            ListaEnlazadaContar lista = new ListaEnlazadaContar();

            Console.WriteLine("Ingrese valores (separados por espacios):");
            string[] valores = Console.ReadLine().Split(' ');
            foreach (var valor in valores)
            {
                lista.AgregarElemento(int.Parse(valor));
            }

            Console.WriteLine("Elementos en la lista:");
            lista.MostrarLista();
            Console.WriteLine("Número de elementos: " + lista.ContarElementos());
        }
        else if (opcion == "2")
        {
            // Ejercicio para invertir una lista enlazada
            ListaEnlazadaInvertir lista = new ListaEnlazadaInvertir();

            Console.WriteLine("Ingrese valores (separados por espacios):");
            string[] valores = Console.ReadLine().Split(' ');
            foreach (var valor in valores)
            {
                lista.AgregarDato(int.Parse(valor));
            }

            Console.WriteLine("Elementos en la lista:");
            lista.MostrarLista();

            lista.InvertirLista();
            Console.WriteLine("Lista invertida:");
            lista.MostrarLista();
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}


