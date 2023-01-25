namespace Hospitales;

using Spectre.Console;

public class Menus
{
    List<Trabajadores> data = new List<Trabajadores>();

    public void create(Trabajadores nuevoTrabajador)
    {
        data.Add(nuevoTrabajador);
    }

    public List<Trabajadores> all()
    {
        return data;
    }

    public Trabajadores find(string nombre)
    {
        return data.Find(item => item.nombre == nombre);
    }
    
    /////
    List<Pacientes> dataP = new List<Pacientes>();

    public void create(Pacientes nuevoPaciente)
    {
        dataP.Add(nuevoPaciente);
    }

    public List<Pacientes> allP()
    {
        return dataP;
    }

    public Pacientes findP(string nombre)
    {
        return dataP.Find(item => item.nombre == nombre);
    }

    //////
    List<Especialidades> dataE = new List<Especialidades>();

    public void create(Especialidades nuevaEspecialidad)
    {
        dataE.Add(nuevaEspecialidad);
    }

    public List<Especialidades> allE()
    {
        return dataE;
    }

    public Especialidades findE(string nombreEspecialidad)
    {
        return dataE.Find(item => item.nombreEspecialidad == nombreEspecialidad);
    }


    public static void menuPrincipal(){
        AnsiConsole.Write(new Markup("[blue] ***Hospital***[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 0 - Trabajadores[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 1 - Pacientes[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 2 - Especialidades[/]"));
        Console.WriteLine(" ");
    }

    public static void menuTrabajador(){
        AnsiConsole.Write(new Markup("[blue] ***Trabajadores***[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 0 - Buscar un trabajador[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 1 - Insertar nuevo trabajador[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 2 - Quieres cambiar de puesto?[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 3 - Pulse otro número para salir:[/]"));
        Console.WriteLine(" ");
    }

    public static void menuPaciente(){
        AnsiConsole.Write(new Markup("[blue] ***Pacientes***[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 0 - Buscar un paciente[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 1 - Insertar nuevo paciente[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 2 - Quieres dar de alta un paciente?[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 3 - Pulse otro número para salir:[/]"));
        Console.WriteLine(" ");
    }

    public static void menuEspecialidades(){
        AnsiConsole.Write(new Markup("[blue] ***Especialidades***[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 0 - Buscar un especialidad[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 1 - Insertar nueva especialidad[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 2 - Quieres cambiar de especialidad?[/]"));
        Console.WriteLine(" ");

        AnsiConsole.Write(new Markup("[blue] 3 - Pulse otro número para salir:[/]"));
        Console.WriteLine(" ");
    }
}