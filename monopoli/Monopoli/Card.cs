namespace Monopoly
{
  class Card : Square
  {
    public CardType Type { get; init; }
    public string Instruction { get; init; }
    public Card(CardType type, int position, string instruction) : base(position)
    {
      this.Type = type;
      this.Instruction = instruction;
    }

    public string ReadInstruction(){
      return Instruction;
    }
  }
}