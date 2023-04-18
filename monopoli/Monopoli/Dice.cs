namespace Monopoly
{
  class Dice
  {
    private int Side { get; init; }

    private Random random = new Random();
    public Dice(int side)
    {
      this.Side = side;
    }

    public int RollDice(){
      return random.Next(1, Side + 1);
    }
  }
}