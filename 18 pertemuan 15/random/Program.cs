using System;

class Program
{
    static void Main(string[] args)
    {

        RollDice2 dice1 = new RollDice2 ();
        
        dice1.RollDice();
        // Console.WriteLine (dice1.RollDice());
        // Console.WriteLine (dice2.RollDice());
        
    }

    class RollDice2 
    {

    public int RollDice ()
    {
        Random rand = new Random();
        int dice1 = rand.Next(1, 7); // generates a random integer between 1 and 6
        Console.WriteLine ("ini dadu pertama = " + dice1);
        int dice2 = rand.Next(1, 7); // generates a random integer between 1 and 6
        Console.WriteLine ("ini dadu kedua = " + dice2);
        int total = dice1 + dice2;   // calculates the total of the two dice rolls
        return total;
    }
}
}
