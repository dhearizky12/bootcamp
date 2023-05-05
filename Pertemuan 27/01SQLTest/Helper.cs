namespace _01SQLTest;

public class Helper
{
    public static void SectionTitle(string title)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*");
        Console.WriteLine($"* {title}");
        Console.WriteLine("*");
        Console.ForegroundColor = previousColor;
    }

    public static void Fail(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Fail > {message}");
        Console.ForegroundColor = previousColor;
    }

    public static void Info(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Info > {message}");
        Console.ForegroundColor = previousColor;
    }

    public static void Printer(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{message}");
        Console.ForegroundColor = previousColor;
    }
    public static string? GetInput()
    {
        return Console.ReadLine();
    }
}
