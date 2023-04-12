using System;

class Program
{
    static void Main(string[] args)
    {
        // Your program logic here
        int diceRoll = RollDice();
        
    }
    
    public int RollDice()
    {
        Random rand = new Random();
        int dice1 = rand.Next(1, 7); // generates a random integer between 1 and 6
        int dice2 = rand.Next(1, 7); // generates a random integer between 1 and 6
        int total = dice1 + dice2;   // calculates the total of the two dice rolls
        return total;
    }
}
