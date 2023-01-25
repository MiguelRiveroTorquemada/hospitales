namespace Hospitales;
class Form
{
    public static int formInteger(string prompt = "Introduzca un entero: ")
    {
        Console.WriteLine(prompt);

        return Int32.Parse(Console.ReadLine());

    }

    public static string formString(string prompt = "Introduzca un texto: ")
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    
    public static bool formBool(string prompt = "Introduzca un Booleano:")
    {
        Console.WriteLine(prompt);
        return Boolean.Parse(Console.ReadLine());
    }

    public static DateTime formDate(string prompt = "Introduzca una fecha:")
    {
        Console.WriteLine(prompt);
        return DateTime.Parse(Console.ReadLine());
    }

    public static decimal formDecimal(string prompt = "Introduzca un numero decimal:")
    {
        Console.WriteLine(prompt);
        return Decimal.Parse(Console.ReadLine());
    }
}