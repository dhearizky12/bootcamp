namespace Monopoly
{
  static class Message
  {
    public static void Regular(string message, bool newLine = true)
    {
      Console.Write(message + (newLine? "\n" : ""));
    }
    public static void Warning(string message, bool newLine = true)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.Write(message + (newLine? "\n" : ""));
      Console.ResetColor();
    }

    public static void Danger(string message, bool newLine = true)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write(message + (newLine? "\n" : ""));
      Console.ResetColor();
    }

    public static void Success(string message, bool newLine = true)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(message + (newLine? "\n" : ""));
      Console.ResetColor();
    }
  }
}