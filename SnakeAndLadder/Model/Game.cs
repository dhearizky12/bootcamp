using System;
using System.Collections.Generic;

namespace SnakeAndLadderGame
{
  class Game
  {
    private Board _board;
    private Dice _dice;
    private List<Player> _players;

    public Game(Board board)
    {
      _board = board;
      _dice = new Dice();
      _players = new List<Player>();
    }

    public void AddPlayer(string name)
    {
      Player player = new Player(name);
      _players.Add(player);
    }

    public void CheckIsOnPiece(Player player)
    {
      int playerPosition = player.GetPosition();

      foreach (Ladder ladder in _board.GetLadders())
      {
        if (ladder.IsOnPiece(playerPosition))
        {
          int ladderEnd = ladder.GetEndCell();
          Console.WriteLine("{0} climbed a ladder to cell {1}.", player.GetName(), ladderEnd);
          player.MoveToCell(ladderEnd);
          Console.WriteLine("{0} is at cell {1}.", player.GetName(), player.GetPosition());
          return;
        }
      }

      foreach (Snake snake in _board.GetSnakes())
      {
        if (snake.IsOnPiece(playerPosition))
        {
          int snakeEnd = snake.GetEndCell();
          Console.WriteLine("{0} went down a snake to cell {1}.", player.GetName(), snakeEnd);
          player.MoveToCell(snakeEnd);
          Console.WriteLine("{0} is at cell {1}.", player.GetName(), player.GetPosition());
          return;
        }
      }
    }

    public int RollDiceAndMovePlayer(Player player)
    {
      int diceNumber = _dice.Roll();
      Console.WriteLine("{0} rolled a {1}.", player.GetName(), diceNumber);
      int newPosition = player.GetPosition() + diceNumber;

      if (newPosition > _board.GetNumCells())
      {
        int overshoot = newPosition - _board.GetNumCells();
        Console.WriteLine("{0} overshot the end of the board by {1} cells and must move back.", player.GetName(), overshoot);
        newPosition = _board.GetNumCells() - overshoot;
      }

      player.MoveToCell(newPosition);
      return player.GetPosition();
    }

    public void Play()
    {
      bool gameFinished = false;
      while (!gameFinished)
      {
        foreach (Player player in _players)
        {

          Console.WriteLine("{0}, it's your turn. Press enter to roll the dice.", player.GetName());
          Console.ReadLine();

          int playerNewPosition = RollDiceAndMovePlayer(player);

          int playerPosition = player.GetPosition();
          if (playerPosition == _board.GetNumCells())
          {
            Console.WriteLine("{0} has won the game!", player.GetName());
            gameFinished = true;
            break;
          }

          Console.WriteLine("{0} is at cell {1}.", player.GetName(), player.GetPosition());
          CheckIsOnPiece(player);
        }
      }
    }
  }
}
