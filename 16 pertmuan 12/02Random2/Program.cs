using System;

class Program
{
    static void Main(string[] args)
    {
        // create a new Random object
        Random rand = new Random();

        // generate a random number between 1 and 100
        int randomNumber = rand.Next(1, 101);

        // display the random number
        Console.WriteLine("Random number: " + randomNumber);
    }
}
