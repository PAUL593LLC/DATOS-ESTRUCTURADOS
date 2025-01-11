using System;
using System.Collections.Generic;
public class Integrante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Cargo { get; set; }

    public Integrante(int id, string nombre, string cargo)
    {
        Id = id;
        Nombre = nombre;
        Cargo = cargo;
    }
}

public class Aporte
{
    public int IdIntegrante { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }

    public Aporte(int idIntegrante, decimal monto, DateTime fecha)
    {
        IdIntegrante = idIntegrante;
        Monto = monto;
        Fecha = fecha;
    }
}

public class Asociacion
{
    private List<Integrante> integrantes;
    private List<Aporte> aportes;

    public Asociacion()
    {
        integrantes = new List<Integrante>();
        aportes = new List<Aporte>();
    }

    public void AgregarIntegrante(Integrante integrante)
    {
        integrantes.Add(integrante);
    }

    public void RegistrarAporte(Aporte aporte)
    {
        aportes.Add(aporte);
    }

    public void ReportarIntegrantes()
    {
        Console.WriteLine("====UNIVERSIDAD ESTATAL AMAZONICA====");
        Console.WriteLine("Lista de Integrantes:");
        foreach (var integrante in integrantes)
        {
            Console.WriteLine($"ID: {integrante.Id}, Nombre: {integrante.Nombre}, Cargo: {integrante.Cargo}");
        }
    }

    public void ReportarAportes()
    {
        Console.WriteLine("Lista de Aportes:");
        foreach (var aporte in aportes)
        {
            Console.WriteLine($"ID Integrante: {aporte.IdIntegrante}, Monto: {aporte.Monto}, Fecha: {aporte.Fecha}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Asociacion asociacion = new Asociacion();

        // Agregar integrantes
        asociacion.AgregarIntegrante(new Integrante(1, "Carlos Diaz", "Gerente"));
        asociacion.AgregarIntegrante(new Integrante(2, "Gloria Cando", "Secretaria"));

        // Registrar aportes
        asociacion.RegistrarAporte(new Aporte(1, 224.50m, DateTime.Now));
        asociacion.RegistrarAporte(new Aporte(2, 175.00m, DateTime.Now));

        // Reportar
        asociacion.ReportarIntegrantes();
        asociacion.ReportarAportes();
        Console.WriteLine("====GRACIAS POR SUS APORTES====");
    }
}