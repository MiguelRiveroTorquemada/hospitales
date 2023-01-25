namespace Hospitales;
using Spectre.Console;

class Funciones
{
    Menus trabajadores = new Menus();

    public static void form(Menus trabajadores)
    {
        try
        {
            string nombre = Form.formString("Nombre del trabajador nuevo:");
            string email = Form.formString("Email del nuevo trabajador:");
            bool profesion = Form.formBool("Si es médico es TRUE, si es enfermero es FALSE");
            DateTime inicioTrabajo = Form.formDate("Introduzca el la fecha de nacimiento DD/MM/YYYY ");
            decimal salario = Form.formDecimal("Introduzca el salario:");
            int edad = Form.formInteger("Introduzca la edad:");
            Trabajadores nuevoTrabajador = new Trabajadores(nombre, email, profesion, inicioTrabajo, salario, edad);
            trabajadores.create(nuevoTrabajador);
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]¡Ha habido un error! Revisa los datos introducidos![/]"));
            Console.WriteLine();
        }
    }

    public static void buscar(Menus trabajadores)
    {
        try
        {
            string nombreTrabajador = Form.formString("Nombre del trabajador que quieras buscar: ");
            Trabajadores Nombre = trabajadores.find(nombreTrabajador);

            Console.WriteLine(Nombre.Form());
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]No se ha encontrado el nombre que buscabas[/]"));
            Console.WriteLine();
        }
    }

    public static void cambioProfesion(Menus trabajadores)
    {
        try
        {
            string nombreTrabajadorModificar = Form.formString("Nombre del trabajador que cambia de puesto: ");
            Trabajadores trabajadorNuevo = trabajadores.find(nombreTrabajadorModificar);
            trabajadorNuevo.Profesion();
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]No has escrito bien el nombre del trabajador que buscabas[/]"));
        }
    }


    //PACIENTES
    public static void formP(Menus pacientes)
    {
        try
        {
            string nombre = Form.formString("Nombre del paciente nuevo: ");
            string apellido = Form.formString("Apellido del paciente:");
            bool alta_baja = Form.formBool("Si es alta es TRUE, si es baja es FALSE");
            DateTime fecha_ingreso = Form.formDate("Introduzca el la fecha de ingreso DD/MM/YYYY ");
            decimal peso = Form.formDecimal("Introduzca el peso del paciente:");
            int edad = Form.formInteger("Introduzca la edad del paciente:");
            Pacientes nuevoPaciente = new Pacientes(nombre, apellido, alta_baja, fecha_ingreso, peso, edad);
            pacientes.create(nuevoPaciente);
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]ha habido un error! no lo has escrito bien[/]"));
            Console.WriteLine();
        }
    }

    public static void buscarP(Menus pacientes)
    {
        try
        {
            string nombrePaciente = Form.formString("Nombre del paciente que quieras buscar: ");
            Pacientes Nombre = pacientes.findP(nombrePaciente);

            Console.WriteLine(Nombre.Form());
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]No se ha encontrado el paciente que buscabas.[/]"));
            Console.WriteLine();
        }
    }

    public static void altaBaja(Menus pacientes)
    {
        try
        {
            string nombrePacienteModificar = Form.formString("Es alta o baja?");
            Pacientes pacienteNuevo = pacientes.findP(nombrePacienteModificar);
            pacienteNuevo.Alta_baja();
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]¡Ha habido un error! ¡Revisa los datos introducidos![/]"));
        }
    }

    //////////
    public static void formE(Menus especialidades)
    {
        try
        {
            string nombreEspecialidad = Form.formString("Nombre de la especialidad: ");
            string descripcion = Form.formString("Descripción de la especialidad:");
            bool rotativa = Form.formBool("Si es una especialidad rotativa es TRUE, si no es FALSE");
            DateTime inicioEspecialidad = Form.formDate("Introduzca el la fecha del inicio de la especialidad DD/MM/YYYY ");
            decimal salario = Form.formDecimal("Introduzca el salario de la especialidad ");
            int afiliados = Form.formInteger("Introduzca el numero de afiliados a la especialidad");
            Especialidades nuevaEspecialidad = new Especialidades(nombreEspecialidad, descripcion, rotativa, inicioEspecialidad, salario, afiliados);
            especialidades.create(nuevaEspecialidad);
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]¡Ha habido un error! Revisa los datos introducidos![/]"));
            Console.WriteLine();
        }
    }

    public static void buscarE(Menus especialidades)
    {
        try
        {
            string nombreEspecialidad = Form.formString("Nombre de la especialidad que quieras buscar: ");
            Especialidades Nombre = especialidades.findE(nombreEspecialidad);

            Console.WriteLine(Nombre.formE());
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]¡Ha habido un error! Revisa los datos introducidos![/]"));
            Console.WriteLine();
        }
    }

    public static void rotativa(Menus especialidades)
    {
        try
        {
            string nombreEspecialidadModificar = Form.formString("Escribe el nombre de la especialidad a la que quieres modificar:");
            Especialidades especialidadNueva = especialidades.findE(nombreEspecialidadModificar);
            especialidadNueva.rotativaE();
        }
        catch (Exception ex)
        {
            AnsiConsole.Write(new Markup(" [red]¡Ha habido un error! Revisa los datos introducidos![/]"));
        }
    }

    /////////
    public static void publico(){
        AnsiConsole.Write(new Markup("[blue]Hola, ¿qué tal estás?[/]"));
        AnsiConsole.Write(new Markup("[blue]Bienvenido a nuestro hospital[/]"));
        AnsiConsole.Write(new Markup("[blue]¿En qué te podemos ayudar?[/]"));
    }
}