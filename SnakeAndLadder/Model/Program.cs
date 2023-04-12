using SnakeAndLadderGame;

class Program
{
  static void Main(string[] args)
  {

    Console.WriteLine("Welcome to Snake and Ladder Game!");

    Console.Write("Enter the number of cells on the board (default is 100): ");
    string input = Console.ReadLine();
    int numCells = string.IsNullOrEmpty(input) ? 100 : int.Parse(input);

    // Create Board instance
    Board board = new Board(numCells);

    // Add Snake to the board instance
    Console.Write("Enter the number of snakes on the board (default 0 Snake): ");
    int numSnakes = int.Parse(Console.ReadLine());
    AddSnake(numSnakes, board);

    // Add Ladder to the Board instance
    Console.Write("Enter the number of ladders: ");
    int numLadders = int.Parse(Console.ReadLine());
    AddLadder(numLadders, board);

    // Create Game instance
    Game game = new Game(board);

    // Add the player to the Game instance
    Console.Write("How many players? ");
    int numPlayers = int.Parse(Console.ReadLine());
    AddPlayer(numPlayers, game);

    // Play the game
    Console.WriteLine("Starting game...");
    game.Play();

    Console.WriteLine("Game over!");
    Console.ReadLine();
  }

  public static void AddSnake(int numSnakes, Board board)
  {
    for (int i = 0; i < numSnakes; i++)
    {
      try
      {
        Console.Write($"Enter the start cell of snake #{i + 1}: ");
        int startCell = int.Parse(Console.ReadLine());

        Console.Write($"Enter the end cell of snake #{i + 1}: ");
        int endCell = int.Parse(Console.ReadLine());

        Snake snake = new Snake(startCell, endCell);
        board.AddSnake(snake);

        Console.WriteLine(snake.GetStartCell() + ", " + snake.GetEndCell());
      }
      catch (FormatException e)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        Console.ResetColor();
        i--;
      }
      catch (ArgumentException e)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.Message);
        i--;
        Console.ResetColor();
      }
    }
  }

  public static void AddLadder(int numLadders, Board board)
  {
    for (int i = 0; i < numLadders; i++)
    {

      try
      {
        Console.Write($"Enter the start cell for ladder {i + 1}: ");
        int startCell = int.Parse(Console.ReadLine());

        Console.Write($"Enter the end cell for ladder {i + 1}: ");
        int endCell = int.Parse(Console.ReadLine());

        Ladder ladder = new Ladder(startCell, endCell);
        board.AddLadder(ladder);
      }
      catch (FormatException e)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        Console.ResetColor();
        i--;
      }
      catch (ArgumentException e)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(e.Message);
        i--;
        Console.ResetColor();
      }
    }
  }

  public static void AddPlayer(int numPlayers, Game game)
  {
    for (int i = 1; i <= numPlayers; i++)
    {
      Console.Write("Enter name for player {0}: ", i);
      string name = Console.ReadLine();
      game.AddPlayer(name);
    }
  }
}
