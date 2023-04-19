using System;
using System.Collections.Generic;

namespace Monopoli;

public class Game
{
    private List<Player> players = new List<Player>();

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
            PlayerInfo playerInfo = new PlayerInfo() { name = name };
            playerInfo.playerAvatar = ChooseAvatar(); // output avatar pilihan user
            players.Add(new Player(playerInfo));
            Message.Success($"\nPlayer ke-{i + 1} with name \"{playerInfo.name}\" using Avatar \"{playerInfo.playerAvatar}\" successfully added !", true);
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
    private Avatar ChooseAvatar()
    {
    while (true)
    {
        Console.WriteLine("================================================");
        foreach (Avatar avatar in Enum.GetValues(typeof(Avatar)))
        {
            // check if the avatar is already taken by another player
            if (players.Any(p => p.playerInfo.playerAvatar == avatar))
            {
                Console.WriteLine($"{avatar.ToString()} (taken)");
            }
            else
            {
                Console.WriteLine($"{avatar.ToString()}");
            }
        }
        Console.WriteLine("================================================");
        Console.WriteLine("Choose your Avatar:");
        string input = Console.ReadLine();
        if (Enum.TryParse(input, out Avatar chosenAvatar))
        {
            // check if the chosen avatar is already taken by another player
            if (players.Any(p => p.playerInfo.playerAvatar == chosenAvatar))
            {
                Message.Warning("The chosen avatar is already taken. Please choose another one.");
            }
            else
            {
                return chosenAvatar;
            }
            
         }
         else{
            Message.Warning("Invalid input. Please choose a valid Avatar.");
         }
        
        }
    }

}


