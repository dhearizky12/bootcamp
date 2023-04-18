namespace Monopoly
{

  // Singleton Class
  class Board
  {
    private static Board? instance = null;
    public Square[] squares = new Square[40];
    private static readonly object Padlock = new();
    public Board()
    {
      CreateBoard();
    }

    public static Board Instance
    {
      get
      {
        lock (Padlock)
        {
          if (instance == null)
          {
            instance = new Board();
          }
          return instance;
        }
      }
    }

    private void CreateBoard()
    {
      
    }

  }
}