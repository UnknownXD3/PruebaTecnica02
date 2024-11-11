using System;
using System.Collections.Generic;
using System.Linq;


class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Asignatura
{
    public string Nombre { get; set; }
    public double Calificacion { get; set; }

    public Asignatura(string nombre, double calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }
}

class RegistroAcademico
{
    public Estudiante Estudiante { get; set; }
    private List<Asignatura> Asignaturas { get; set; }

    public RegistroAcademico(Estudiante estudiante)
    {
        Estudiante = estudiante;
        Asignaturas = new List<Asignatura>();
    }

    public void AgregarAsignatura(string nombre, double calificacion)
    {
        Asignaturas.Add(new Asignatura(nombre, calificacion));
    }

    public void MostrarRegistros()
    {
        Console.WriteLine($"\nEstudiante: {Estudiante.Nombre} - Edad: {Estudiante.Edad}");
        Console.WriteLine("Asignaturas y Calificaciones:");
        foreach (var asignatura in Asignaturas)
        {
            Console.WriteLine($" - {asignatura.Nombre}: {asignatura.Calificacion}");
        }
        Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
    }

    public double CalcularPromedio()
    {
        return Asignaturas.Count > 0 ? Asignaturas.Average(a => a.Calificacion) : 0;
    }
}
