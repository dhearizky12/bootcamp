using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the value of N: ");
        int jumlah = int.Parse(Console.ReadLine());

        FizzBuzz fizzBuzz = new FizzBuzz(jumlah);

        Console.WriteLine("Enter the key-value pairs for FizzBuzz (press enter without typing a value to finish):");
        while (true) {
            Console.Write("Key: ");
            string inputKey = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputKey)) {
                break;
            }
            int key = int.Parse(inputKey);

            Console.Write("Value: ");
            string value = Console.ReadLine();

            fizzBuzz.AddDictionary(key, value);
        }

        Console.WriteLine("=======");
        fizzBuzz.HasilDictionary();
        Console.WriteLine("=======");

        fizzBuzz.PrintHasilFizzBuzz();
    }
}