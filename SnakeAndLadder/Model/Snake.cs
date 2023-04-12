using System;

namespace SnakeAndLadderGame
{
  class Snake : IPiece
  {
    private int StartCell;
    private int EndCell;

    public Snake(int start, int end)
    {
      if (start <= end)
      {
        throw new ArgumentException("Start cell must be greater than end cell for a snake.");
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
