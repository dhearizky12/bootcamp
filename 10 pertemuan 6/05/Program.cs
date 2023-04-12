using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a number:");
    int n = int.Parse((Console.ReadLine()));

    // create an array of numbers from 0 to n
    int[] numbers = Enumerable.Range(0, n + 1).ToArray();

    Array.ForEach(numbers, Console.Write);
    Console.WriteLine();

    // iterate over the array of numbers
    FooBar(numbers)
;
  }

  public static void FooBar(int[] numbers)
  {
    foreach(int i in numbers)
    {

      var isDivisible = flase;
     if (i == 0)
      {
        Console.Write("0");
        isDivisible = true;
      }


      if (divisibleBy3(i) == 0)
      {
        Console.Write("foo");
        isDivisible = true;
      }


      if (divisibleBy5(i) == 0)
      {
        Console.Write("bar");
        isDivisible = true;
      }

      if (isDivisible)
        Console.WriteLine();
      else
        Console.WriteLine(i);
    }
  }

  private static int divisibleBy3(int n)
  {
    var divide3 = n % 3;
    return divide3;
  }

  public static int divisibleBy5(int n)
  {
    var divide5 = n % 5;
    return divide5;
  }
}