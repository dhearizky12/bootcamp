using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> snakes = new Dictionary<int, int>();
        Dictionary<int, int> ladders = new Dictionary<int, int>();

        // Read input for snakes
        Console.WriteLine("Enter the number of snakes:");
        int numSnakes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numSnakes; i++)
        {
            Console.WriteLine($"Enter the start cell and end cell of snake {i + 1} (separated by a space):");
            string[] input = Console.ReadLine().Split(' ');
            int startCell = int.Parse(input[0]);
            int endCell = int.Parse(input[1]);
            snakes.Add(startCell, endCell);
        }

        // Read input for ladders
        Console.WriteLine("Enter the number of ladders:");
        int numLadders = int.Parse(Console.ReadLine());

        for (int i = 0; i < numLadders; i++)
        {
            Console.WriteLine($"Enter the start cell and end cell of ladder {i + 1} (separated by a space):");
            string[] input = Console.ReadLine().Split(' ');
            int startCell = int.Parse(input[0]);
            int endCell = int.Parse(input[1]);
            ladders.Add(startCell, endCell);
        }

        // Printing the start cells of the snakes
        Console.WriteLine("Start cells of snakes:");
        foreach (KeyValuePair<int, int> snake in snakes)
        {
            Console.WriteLine($"Snake at {snake.Key} starts at cell {snake.Value}");
        }

        // Printing the start cells of the ladders
        Console.WriteLine("Start cells of ladders:");
        foreach (KeyValuePair<int, int> ladder in ladders)
        {
            Console.WriteLine($"Ladder at {ladder.Key} starts at cell {ladder.Value}");
        }
    }
}
