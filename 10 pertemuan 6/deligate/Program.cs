using System;

class Program {
    // Declare the delegate type
    delegate void SimpleDelegate();

    static void Main(string[] args) {
        // Create a delegate instance and assign a method to it
        SimpleDelegate myDelegate = PrintHello;
        myDelegate += PrintWorld;
        myDelegate = myDelegate + PrintWorld;
        // Invoke the delegate
        myDelegate();
    }

    // A simple method to be assigned to the delegate
    static void PrintHello() {
        Console.WriteLine("Hello, delegate!");
    }
    static void PrintWorld() {
        Console.WriteLine("World!");
    }
}