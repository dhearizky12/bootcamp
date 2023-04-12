using System;

 class FoobarPrinter {
  public static void PrintFoobar(int? n) {
        for (int i = 0; i <= n; i++) {
            if (i == 0) {
                Console.Write("0");
            } else if (i % 15 == 0) {
                Console.Write(" " + "foobar");
            } else if (i % 3 == 0) {
                Console.Write("foo" + " ");
            } else if (i % 5 == 0) {
                Console.Write("bar" + " ");
            } else {
                Console.Write(" " + i + " ");
            }
        }
    }
}

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int? n = int.Parse(Console.ReadLine());
         Console.Write("the number is: " + n);
        FoobarPrinter.PrintFoobar(n);
    }
}
