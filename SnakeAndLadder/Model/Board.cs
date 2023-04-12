using System;
using System.Collections.Generic;

namespace SnakeAndLadderGame
{
  class Board
  {
    private int NumCells;
    private List<Snake> Snakes;
    private List<Ladder> Ladders;

    public Board(int numCells)
    {
      if (numCells < 1)
      {
        throw new ArgumentException("Number of cells on board must be greater than 0.");
      }

      NumCells = numCells;
      Snakes = new List<Snake>();
      Ladders = new List<Ladder>();
    }

    public int GetNumCells()
    {
      return NumCells;
    }

    public void AddSnake(Snake snake)
    {
      if (snake.GetEndCell() >= NumCells)
      {
        throw new ArgumentException("Snake end cell must be less than number of cells on board.");
      }

      foreach (Snake s in Snakes)
      {
        if (snake.GetStartCell() == s.GetStartCell())
        {
          throw new ArgumentException("Snakes cannot start on the same cell.");
        }
      }

      foreach (Ladder ladder in Ladders)
      {
        if (snake.GetStartCell() == ladder.GetStartCell())
        {
          throw new ArgumentException("Snakes cannot start on a ladder.");
        }
      }

      Snakes.Add(snake);
    }

    public void AddLadder(Ladder ladder)
    {
      if (ladder.GetEndCell() >= NumCells)
      {
        throw new ArgumentException("Ladder end cell must be less than number of cells on board.");
      }

      foreach (Ladder l in Ladders)
      {
        if (ladder.GetStartCell() == l.GetStartCell())
        {
          throw new ArgumentException("Ladders cannot start on the same cell.");
        }
      }

      foreach (Snake snake in Snakes)
      {
        if (ladder.GetStartCell() == snake.GetStartCell())
        {
          throw new ArgumentException("Ladders cannot start on a snake.");
        }
      }

      Ladders.Add(ladder);
    }

    public List<Ladder> GetLadders()
    {
      return Ladders;
    }

    public List<Snake> GetSnakes()
    {
      return Snakes;
    }
  }
}
