using System;
using System.Collections.Generic;

public class AgendaTurno
{
    // Lista para almacenar los turnos
    private List<Turno> turnos = new List<Turno>();
    private List<Paciente> pacientes = new List<Paciente>();

    // Clase Paciente
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Paciente(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
    }

    // Clase Turno
    public class Turno
    {
        public int IdPaciente { get; set; }
        public DateTime FechaHora { get; set; }

        public Turno(int idPaciente, DateTime fechaHora)
        {
            IdPaciente = idPaciente;
            FechaHora = fechaHora;
        }
    }

    // Método para agregar pacientes
    public void AgregarPaciente(string nombre, string apellido, DateTime fechaNacimiento)
    {
        int id = pacientes.Count + 1; // Generar un ID único
        Paciente paciente = new Paciente(id, nombre, apellido, fechaNacimiento);
        pacientes.Add(paciente);
    }

    // Método para agendar un turno
    public void AgendarTurno(int idPaciente, DateTime fechaHora)
    {
        if (pacientes.Exists(p => p.Id == idPaciente))
        {
            Turno turno = new Turno(idPaciente, fechaHora);
            turnos.Add(turno);
            Console.WriteLine("Turno agendado exitosamente.");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado.");
        }
    }

    // Método para mostrar los turnos agendados
    public void MostrarTurnos()
    {
        foreach (var turno in turnos)
        {
            var paciente = pacientes.Find(p => p.Id == turno.IdPaciente);
            Console.WriteLine($"Turno de {paciente.Nombre} {paciente.Apellido} - {turno.FechaHora}");
        }
    }

    // Método para mostrar los pacientes registrados
    public void MostrarPacientes()
    {
        foreach (var paciente in pacientes)
        {
            Console.WriteLine($"ID: {paciente.Id} - Nombre: {paciente.Nombre} {paciente.Apellido}");
        }
    }

    // Método para iniciar la gestión de turnos
    public void GestionarAgenda()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Agregar Paciente");
            Console.WriteLine("2. Agendar Turno");
            Console.WriteLine("3. Mostrar Turnos");
            Console.WriteLine("4. Mostrar Pacientes");
            Console.WriteLine("5. Volver al menú principal");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Ingrese el nombre del paciente: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido del paciente: ");
                    string apellido = Console.ReadLine();
                    Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
                    DateTime fechaNacimiento;
                    if (DateTime.TryParse(Console.ReadLine(), out fechaNacimiento))
                    {
                        AgregarPaciente(nombre, apellido, fechaNacimiento);
                        Console.WriteLine("Paciente agregado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Fecha no válida.");
                    }
                    break;

                case "2":
                    Console.Write("Ingrese el ID del paciente: ");
                    int idPaciente;
                    if (int.TryParse(Console.ReadLine(), out idPaciente))
                    {
                        Console.Write("Ingrese la fecha y hora del turno (YYYY-MM-DD HH:mm): ");
                        DateTime fechaHora;
                        if (DateTime.TryParse(Console.ReadLine(), out fechaHora))
                        {
                            AgendarTurno(idPaciente, fechaHora);
                        }
                        else
                        {
                            Console.WriteLine("Fecha y hora no válidas.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID no válido.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nTurnos agendados:");
                    MostrarTurnos();
                    break;

                case "4":
                    Console.WriteLine("\nPacientes registrados:");
                    MostrarPacientes();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}
