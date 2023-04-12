using System;

namespace SnakeAndLadderGame
{
  class Ladder : IPiece
  {
    private int StartCell;
    private int EndCell;

    public Ladder(int start, int end)
    {
      if (start >= end)
      {
        throw new ArgumentException("End cell must be greater than start cell for a ladder.");
      }

      StartCell = start;
      EndCell = end;
    }

    public int GetStartCell()
    {
      return StartCell;
    }

    public int GetEndCell()
    {
      return EndCell;
    }

    public bool IsOnPiece(int cell)
    {
      return cell == StartCell;
    }
  }
}
