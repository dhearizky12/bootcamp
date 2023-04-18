interface Building
{
  int Cost { get; }
  int RentIncreaseBy { get; }
  void Purchase();
  void Sell();
}