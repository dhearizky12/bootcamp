using System;
using System.Collections.Generic;

//class Program {

try
{
     Console.Write("Enter the value of x: ");
    double x = double.Parse(Console.ReadLine());
     Console.Write("Enter the value of y: ");
    double y = double.Parse(Console.ReadLine());
    double result = x / y;
    Console.WriteLine("Result: " + result);
}
catch (FormatException)
{
    Console.WriteLine("Please enter a valid integer.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
catch (Exception)
{
    Console.WriteLine("An error occurred.");
}
