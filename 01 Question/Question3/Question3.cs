class Program {
    static void Main () {

        string? userInputName = Console.ReadLine();
        string? userInputAge = Console.ReadLine();


        Console.WriteLine("Hello, "+ userInputName + " ! " + "You are " + userInputAge + " year");
        Console.WriteLine ( $"Hello, {userInputName} {userInputAge}");
    }
}