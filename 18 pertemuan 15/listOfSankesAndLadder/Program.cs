using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int[]> snakes = new List<int[]>();
        List<int[]> ladders = new List<int[]>();

        // Read input for snakes
        Console.WriteLine("Enter the number of snakes:");
        int numSnakes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numSnakes; i++)
        {
            Console.WriteLine($"Enter the start cell and end cell of snake {i + 1} (separated by a space):");
            string[] input = Console.ReadLine().Split(' ');
            int startCell = int.Parse(input[0]);
            int endCell = int.Parse(input[1]);
            snakes.Add(new int[] { startCell, endCell });
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
            ladders.Add(new int[] { startCell, endCell });
        }

        // Printing the start cells of the snakes
        Console.WriteLine("Start cells of snakes:");
        foreach (int[] snake in snakes)
        {
            Console.WriteLine($"Snake at {snake[0]} starts at cell {snake[1]}");
        }

        // Printing the start cells of the ladders
        Console.WriteLine("Start cells of ladders:");
        foreach (int[] ladder in ladders)
        {
            Console.WriteLine($"Ladder at {ladder[0]} starts at cell {ladder[1]}");
        }
    }
}
