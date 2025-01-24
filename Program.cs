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
            Console.WriteLine("6. Problemas con Pilas");
            Console.WriteLine("7. Salir");

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
                
                    // Si el usuario selecciona '6', se llama al método MostrarProblemasConPilas que muestra un submenú
                case "6":
                    MostrarProblemasConPilas();
                    break;

                case "7":
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

// Método para mostrar y gestionar el submenú de "Problemas con Pilas"
static void MostrarProblemasConPilas()
{
    while (true) // Bucle infinito para mantener el submenú activo hasta que el usuario decida salir
    {
        // Mostrar opciones del submenú
        Console.WriteLine("\nSeleccione una opción de Problemas con Pilas:");
        Console.WriteLine("1. Verificar Balanceo de Operaciones"); // Opción para verificar si una fórmula matemática está balanceada
        Console.WriteLine("2. Resolver Torres de Hanoi"); // Opción para resolver las Torres de Hanoi
        Console.WriteLine("3. Volver al menú principal"); // Opción para regresar al menú principal

        string opcion = Console.ReadLine(); // Leer la opción seleccionada por el usuario

        switch (opcion)
        {
            case "1": // Opción 1: Verificar balanceo de operaciones matemáticas
                Console.WriteLine("\nIngrese una fórmula matemática:"); // Solicitar al usuario la fórmula
                string formula = Console.ReadLine(); // Leer la fórmula ingresada
                bool balanceada = BalanceoOperaciones.VerificarBalanceo(formula); // Verificar si la fórmula está balanceada
                // Mostrar el resultado de la verificación
                Console.WriteLine(balanceada ? "Fórmula balanceada" : "Fórmula no balanceada");
                break;

            case "2": // Opción 2: Resolver el problema de las Torres de Hanoi
                Console.WriteLine("\nIngrese el número de discos para las Torres de Hanoi:"); // Solicitar el número de discos
                int numDiscos = int.Parse(Console.ReadLine()); // Leer y convertir el número ingresado
                Console.WriteLine("\nMovimientos para resolver las Torres de Hanoi:");
                // Llamar al método que resuelve las Torres de Hanoi y muestra los movimientos
                TorresDeHanoi.Resolver(numDiscos, "Origen", "Destino", "Auxiliar");
                break;

            case "3": // Opción 3: Salir del submenú y volver al menú principal
                return; // Terminar el método y regresar al menú principal

            default: // Manejar opciones no válidas
                Console.WriteLine("Opción no válida. Intente nuevamente."); // Mostrar mensaje de error
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


