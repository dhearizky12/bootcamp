class Program
{
    static void Main(string[] args)
    {
        MathDelegate mathDelegate = MathOperations.Add

        int result = mathDelegate(5, 3);

        Console.WriteLine($"5 + 3 = {result}");

        mathDelegate = MathOperations.Subtract;

        result = mathDelegate(5, 3);

        Console.WriteLine($"5 - 3 = {result}");

        Console.ReadKey();
    }
}