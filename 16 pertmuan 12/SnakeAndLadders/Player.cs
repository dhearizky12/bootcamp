using System;

namespace SnakeAndLadderGame
{
  class Player
  {
    private string Name;
    private int Position;

    private Colors Color;

    public Player(string name)
    {
      Name = name;
      Position = 1;
      Color = Colors.Red;
    }

    public string GetName()
    {
      return Name;
    }

    public int GetPosition()
    {
      return Position;
    }

    public void MoveToCell(int cell)
    {
      Position = cell;
    }
  }
}
