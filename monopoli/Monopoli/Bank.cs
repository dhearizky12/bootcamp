namespace Monopoly
{
  class Bank
  {

    public int Money { get; private set; }

    public List<Property> Properties { get; private set; } = new();
    public List<Building> Buildings { get; private set; } = new();
    public List<Card> Cards { get; private set; } = new();

    public Bank()
    {
      
    }
  }
}