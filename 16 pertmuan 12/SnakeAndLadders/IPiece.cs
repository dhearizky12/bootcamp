namespace SnakeAndLadderGame
{
  public interface IPiece
  {
    int GetStartCell();
    int GetEndCell();
    bool IsOnPiece(int position);
  }
}