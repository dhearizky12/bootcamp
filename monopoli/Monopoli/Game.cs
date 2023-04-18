namespace Monopoly
{
  class Game
  {
    public List<Player> Players = new();

    public Board Board = new();

    public Dice[] dices = new Dice[2] { new Dice(6), new Dice(6) };

    public Game() { }

    public void Create()
    {
      Console.WriteLine("Welcome to Monopoly Game: World Edition");
      CreatePlayer();
      Message.Success("\nPress any key to start the game !\n");
      Console.ReadKey(true);
    }

    private void CreatePlayer()
    {
      int numPlayers = 0;
      while (numPlayers < 2 || numPlayers > 6)
      {
        Console.WriteLine("How many players will play (2-6)?");
        numPlayers = int.Parse(Console.ReadLine() ?? "0");
        if (numPlayers < 2 || numPlayers > 6)
        {
          Message.Warning("Please input valid number");
        }
      }
      for (int i = 0; i < numPlayers; i++)
      {
        Console.WriteLine("\nPlayer " + (i + 1) + ":");
        string name = "";
        while (name == "")
        {
          Console.Write("Player Name: ");
          name = Console.ReadLine() ?? "";
          if (name == "")
          {
            Message.Warning("Please input the player name");
          }
        }
        Player player = new(name);
        Players.Add(player);
        Message.Success("\nPlayer " + (i + 1) + " with name \"" + player.Name + "\" successfully added !", true);
      }
      Console.WriteLine("\nRegistered Players:");
      for (int j = 0; j < numPlayers; j++)
      {
        Players[j].Info();
      }
    }

    public void Start()
    {
      // TODO: change true with condition if there's not a winner
      int indexCurrentPlayer = 0;
      while (true)
      {
        Player currentPlayer = Players[indexCurrentPlayer];
        PlayerTurn(currentPlayer);
        indexCurrentPlayer = indexCurrentPlayer == Players.Count - 1 ? 0 : indexCurrentPlayer + 1;
        Console.WriteLine("\nPress any key to allow the next player to take their turn.");
        Console.ReadKey();
      }

    }

    public void PlayerTurn(Player currentPlayer)
    {
      // TODO: Add "Go to jail" if the player has 3 times double
      int numDouble = 0;
      while (true)
      {
        Console.Clear();
        Console.WriteLine("Player " + currentPlayer.Name + " Turn");
        Console.WriteLine("\nPress any key to roll the dice!");
        Console.ReadKey(true);
        int[] rollDiceResults = currentPlayer.RollDice(dices);
        Console.WriteLine("\nYour dice roll results are: " + rollDiceResults[0] + " and " + rollDiceResults[1]);

        currentPlayer.Move(rollDiceResults[0] + rollDiceResults[1]);

        if (IsDouble(rollDiceResults))
        {
          numDouble++;
          if (numDouble > 2)
          {
            Message.Danger("\nYou rolled a double for the third time in a row. You must go to jail.");
            // TODO: Player move to jail
            break;
          }    
          Message.Success("\nPlayer " + currentPlayer.Name + " Move to position: " + currentPlayer.Position);
          Console.WriteLine("Wow, you got a double" + (numDouble > 1 ? " again" : "") + ", Press any key to take turn again!");
          Console.ReadKey(true);
        }
        else
        {
          Message.Success("\nPlayer " + currentPlayer.Name + " Move to position: " + currentPlayer.Position);
          break;
        }
      }
    }

    // Method to check if the roll dice results is the same value
    public bool IsDouble(int[] rollDiceResults)
    {
      return rollDiceResults[0] == rollDiceResults[1];
    }

    public void DisplayCurrentPlayerInfo(Player player)
    {
      Console.WriteLine("Current Player info");
    }
  }
}