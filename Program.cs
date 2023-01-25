using Hospitales;
using Spectre.Console;

Menus trabajadores = new Menus();
Menus pacientes = new Menus();
Menus especialidades = new Menus();

Funciones.publico();
Console.WriteLine();

AnsiConsole.Write(new Markup("[blue]Dime tu nombre:[/]"));

{
    string Contrasena, NombreIngreso;
    int mainExit = 0;
    Console.WriteLine();
    NombreIngreso = Console.ReadLine();

    do
    {
        Console.WriteLine();
        AnsiConsole.Write(new Markup("[blue]Hola[/] " + NombreIngreso + "[blue] Ingrese la contraseña:[/]"));
        Console.WriteLine();
        Contrasena = Console.ReadLine();
        if (true)
        {
            AnsiConsole.Write(new Markup("[red]CONTRASEÑA INCORRECTA[/]"));
            Console.WriteLine();
            AnsiConsole.Write(new Markup("[red]¡Ha habido un error! Revisa los datos introducidos![/]"));

        }
    } while (Contrasena != "password");

    {
        Console.Clear();
        Console.WriteLine();
        AnsiConsole.Write(new Markup("[bold green]¡¡Bienvenido!![/] " + NombreIngreso + "[blue] Seleccione el programa deseado:[/]"));
        Console.WriteLine();

        do
            {
                Menus.menuPrincipal();

                switch (Form.formInteger("Escoja una opcion:"))
                {
                    case 0:
                        bool userExit = false;
                        do
                        {
                            Menus.menuTrabajador();
                            switch (Form.formInteger("Escoja una opcion:"))
                            {
                                case 0:
                                    Funciones.buscar(trabajadores);
                                    break;

                                case 1:
                                    Funciones.form(trabajadores);
                                    break;
                                case 2:
                                    Funciones.cambioProfesion(trabajadores);
                                    break;

                                default:
                                    userExit = true;
                                    break;
                            }
                        } while (!userExit);
                        break;

                    case 1:
                        bool exitPacientes = false;
                        do
                        {
                            Menus.menuPaciente();
                            switch (Form.formInteger("Escoja una opcion:"))
                            {
                                case 0:
                                    Funciones.buscarP(pacientes);
                                    break;

                                case 1:
                                    Funciones.formP(pacientes);
                                    break;
                                case 2:
                                    Funciones.altaBaja(pacientes);
                                    break;

                                default:
                                    exitPacientes = true;
                                    break;
                            }
                        } while (!exitPacientes);
                        break;

                    case 2:
                        bool exitEspecialidades = false;
                        do
                        {
                            Menus.menuEspecialidades();
                            switch (Form.formInteger("Escoja una opcion:"))
                            {
                                case 0:
                                    Funciones.buscarE(especialidades);
                                    break;

                                case 1:
                                    Funciones.formE(especialidades);
                                    break;
                                case 2:
                                    Funciones.rotativa(especialidades);
                                    break;

                                default:
                                    exitEspecialidades = true;
                                    break;
                            }
                        } while (!exitEspecialidades);
                        break;
            }

            } while (mainExit != 5);

            Console.ReadKey();
        }
    }