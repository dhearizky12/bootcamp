namespace Monopoly
{
  class Property: Square
  {
    public string Name { get; init; }
    public int Price { get; init; }
    public int Rent { get; init; }
    public PropertyCategory Category { get; init; }
    public PropertyColor Color { get; init; }
    public int NumHouses { get; private set; }
    public bool HasHotel { get; private set; }
    public Player? Owner { get; private set; }
    public Property(string name, int position, int price, int rent, PropertyCategory category, PropertyColor color): base(position)
    {
      this.Name = name;
      this.Price = price;
      this.Rent = rent;
      this.Category = category;
      this.Color = color;
    }

    public void SetOwner(Player player)
    {

    }

    public int CalculateRent()
    {
      // TODO: calculate the rent base on how much houses and hotels in this property
      return this.Rent;
    }
  }
}