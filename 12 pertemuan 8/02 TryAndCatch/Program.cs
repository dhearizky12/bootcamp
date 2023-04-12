using System;

class Program 
{
    static void Main(string[] args) 
    {
        try 
        {
            // Code that may throw an exception
            int a = 10, b = 0;
            int c = a / b;
        } 

        catch (DivideByZeroException ex) 
        {
            // Code to handle the DivideByZeroException
            Console.WriteLine("An error occurred: {0}", ex.Message);
        } 
          catch (Exception ex) 
        {
            // Code to handle any other type of exception
            Console.WriteLine("An error occurred: {0}", ex.Message);
        } 
    
        finally 
        {
            // Code that will always be executed, regardless of whether an exception was thrown or not
            Console.WriteLine("The program has finished executing.");
        }
        Console.WriteLine("tes.");
    }
}