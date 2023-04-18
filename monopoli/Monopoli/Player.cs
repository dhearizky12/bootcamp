namespace Monopoly
{
  class Player
  {
    public string Name { get; init; }
    public int Position { get; private set; }
    public long Money { get; private set; }
    public List<Property> Properties { get; private set; } = new();
    public Status Status { get; private set; }
    public Player(string name)
    {
      this.Name = name;
      this.Status = Status.Playing;
    }

    public void Move(int postition)
    {
      int tempPosition = this.Position + postition;
      if (tempPosition < 40)
      {
        this.Position = tempPosition;
      }
      else
      {
        this.Position = tempPosition - 40;
      }
    }

    public void AddMoney(long money)
    {
      this.Money -= money;
    }

    public void ReduceMoney(long money)
    {
      this.Money += money;
    }

    public void BuyProperty(Property property)
    {

    }

    public void SellProperty(Property property)
    {

    }

    public void SetStatus(Status status)
    {
      this.Status = status;
    }

    public int[] RollDice(Dice[] dices)
    {
      int[] rollDiceResult = new int[dices.Count()];
      rollDiceResult[0] = dices[0].RollDice();
      rollDiceResult[1] = dices[1].RollDice();
      return rollDiceResult;
    }

    public void Info()
    {
      Console.Write("Player : ");
      Message.Success(this.Name, true);
      Console.WriteLine(" - Position  : " + this.Position);
      Console.WriteLine(" - Money     : $" + this.Money);
      Console.WriteLine(" - Properties: " + this.Properties.Count() + " properties\n");
    }
  }
}