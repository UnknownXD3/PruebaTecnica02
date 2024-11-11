class Program
{
    static void Main()
    {
        List<RegistroAcademico> registros = new List<RegistroAcademico>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menú Principal ---");
            Console.WriteLine("1. Agregar nuevo estudiante");
            Console.WriteLine("2. Mostrar registros de estudiantes");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarEstudiante(registros);
                    break;
                case 2:
                    MostrarRegistrosEstudiantes(registros);
                    break;
                case 3:
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarEstudiante(List<RegistroAcademico> registros)
    {
        Console.Write("\nIngrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la edad del estudiante: ");
        int edad = int.Parse(Console.ReadLine());

        Estudiante estudiante = new Estudiante(nombre, edad);
        RegistroAcademico registro = new RegistroAcademico(estudiante);

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Ingrese el nombre de la asignatura {i}: ");
            string nombreAsignatura = Console.ReadLine();
            Console.Write($"Ingrese la calificación de {nombreAsignatura}: ");
            double calificacion = double.Parse(Console.ReadLine());

            registro.AgregarAsignatura(nombreAsignatura, calificacion);
        }

        registros.Add(registro);
        Console.WriteLine("Estudiante y asignaturas agregados correctamente.");
    }

    static void MostrarRegistrosEstudiantes(List<RegistroAcademico> registros)
    {
        if (registros.Count == 0)
        {
            Console.WriteLine("\nNo hay registros disponibles.");
        }
        else
        {
            foreach (var registro in registros)
            {
                registro.MostrarRegistros();
            }
        }
    }
}
