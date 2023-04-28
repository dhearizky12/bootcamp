using System;
using System.Collections.Generic;

namespace Monopoli;

public class Game
{
    private List<Player> players = new List<Player>();
    public Dice[] dices = new Dice[2] { new Dice(6), new Dice(6) };

    public void Create()
    {
        Console.WriteLine("==========================");
        Console.WriteLine("Welcome to Monopoly Game!!");
        Console.WriteLine("==========================");
        CreatePlayer();
        Message.Success("\nPress any key to start the game !\n");
        Console.ReadKey(true);
    }

    private void CreatePlayer()
    {
        int numPlayers = GetNumberOfPlayers();
        for (int i = 0; i < numPlayers; i++)
        {
            Console.WriteLine($"\nPlayer ke = {i + 1}:");
            string name = GetPlayerName(); // 
            Player player = new Player(name);
            player.PlayerAvatar = ChooseAvatar(); // output avatar pilihan user
            players.Add(player);
            Console.ResetColor();
            Message.Success($"\n Player -{i + 1}- with name \"{player.Name}\" using Avatar \"{player.PlayerAvatar}\" successfully added !", true);
            Console.ResetColor();
        }
    }

    private int GetNumberOfPlayers()
    {
        int numPlayers = 0;
        while (numPlayers < 2 || numPlayers > 6)
        {
            Console.WriteLine("Berapa orang yang akan bermain (2-6)?");
            numPlayers = int.Parse(Console.ReadLine() ?? "0");
            if (numPlayers < 2 || numPlayers > 6)
            {
                Message.Warning("Please input valid number");
            }
        }
        return numPlayers;
    }

    private string GetPlayerName()
    {
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
        return name;
    }
    
    private void DisplayAvatarOptions() // menampilkan pilihan avatar ke layar,
    {
        Console.WriteLine("================SELECT AVATAR==================");
        foreach (Avatar avatar in Enum.GetValues(typeof(Avatar)))
        {
            // check if the avatar is already taken by another player
            if (players.Any(p => p.PlayerAvatar == avatar))
            {
                Console.WriteLine($"{avatar.ToString()} (taken)");
            }
            else
            {
                Console.WriteLine($"{avatar.ToString()}");
            }
        }
        Console.WriteLine("=================================================");
    }

    private Avatar GetChosenAvatar() //meminta input dari user
    {
        Console.Write("Choose your Avatar (Please type according to the available options):");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string input = Console.ReadLine();
        Console.ResetColor();

        if (Enum.TryParse(input, out Avatar chosenAvatar)) //mengonversi input ke tipe Avatar menggunakan metode Enum.TryParse
        {
            return chosenAvatar;
        }
        else
        {
            Message.Warning("Invalid input. Please choose a valid Avatar.");
            return GetChosenAvatar(); // Jika input tidak valid, maka method akan dipanggil kembali
        }
    }

    private Avatar ChooseAvatar()
    {
        while (true)
        {
            DisplayAvatarOptions();
            Avatar chosenAvatar = GetChosenAvatar();

            // check if the chosen avatar is already taken by another player
            if (players.Any(p => p.PlayerAvatar == chosenAvatar))
            {
                Message.Warning("The chosen avatar is already taken. Please choose another one.");
            }
            else
            {
                return chosenAvatar;
            }
        }
    }

    public void Start()
    {
      // TODO: change true with condition if there's not a winner
      int indexCurrentPlayer = 0;
      while (true)
      {
        Player currentPlayer = players[indexCurrentPlayer];
        PlayerTurn(currentPlayer);
        Console.WriteLine("\nPress any key to allow the next player to take their turn.");
        Console.ReadKey();
        indexCurrentPlayer = indexCurrentPlayer == players.Count - 1 ? 0 : indexCurrentPlayer + 1;
      }

    }

    public void PlayerTurn(Player currentPlayer)
    {
      // TODO: Add "Go to jail" if the player has 3 times double
      int numDouble = 0;
      while (true)
      {
        Console.Clear();
        Console.WriteLine("\nPlayer " + currentPlayer.Name + " Turn");
        Console.WriteLine("Press any key to roll the dice!");
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

    public bool IsDouble(int[] rollDiceResults)
    {
      return rollDiceResults[0] == rollDiceResults[1];
    }
}



