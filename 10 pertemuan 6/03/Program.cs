using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse((Console.ReadLine()));
        
        // create an array of numbers from 0 to n
        int[] numbers = Enumerable.Range(0, n+1).ToArray();

        Array.ForEach(numbers, Console.Write);
        Console.WriteLine();
        
        // iterate over the array of numbers
        for (int i = 0; i <= n; i++)
        {
            if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
            {
                Console.WriteLine("FooBar");
            }
            else if (numbers[i] % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (numbers[i] % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            else
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}