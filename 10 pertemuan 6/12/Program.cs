namespace MyProgram;
public delegate TResult MyDelegate<T1, T2, TResult>(T1 a, T2 b);

class Program
{
  static void Main(string[] args)
  {
    MyDelegate<int, int, int> addDelegate = new MyDelegate<int, int, int>(Kalkulator.Add<int, int, int>);
    MyDelegate<double, int, double> MultiplyDelegate = new MyDelegate<double, int, double>(Kalkulator.Multiply<double, int, double>);
    int result1 = addDelegate(3, 2); 
    var result2 = MultiplyDelegate(3.4, 2);

    Console.WriteLine("Result of addDelegate: " + result1);
    Console.WriteLine("Result of multiplyDelegate: " + result2);
  }

}
class Kalkulator
{
  public static TResult Add<T1, T2, TResult>(T1 a, T2 b)
  {
    return (dynamic)a + (dynamic)b;
  }

  public static TResult Multiply<T1, T2, TResult>(T1 a, T2 b)
  {
    return (dynamic)a * (dynamic)b;
  }
}

public delegate TResult MyDelegate<T1, T2, TResult>(T1 a, T2 b);

class Program
{
  static void Main(string[] args)
  {
    MyDelegate<int, int, int> addDelegate = new MyDelegate<int, int, int>(Kalkulator.Add<int, int, int>);
    MyDelegate<double, int, double> MultiplyDelegate = new MyDelegate<double, int, double>(Kalkulator.Multiply<double, int, double>);
    int result1 = addDelegate(3, 2); // result1 will be 7
    var result2 = MultiplyDelegate(3.4, 2); // result2 will be 12

    Console.WriteLine("Result of addDelegate: " + result1);
    Console.WriteLine("Result of multiplyDelegate: " + result2);
  }



}
class Kalkulator
{
  public static TResult Add<T1, T2, TResult>(T1 a, T2 b)
  {
    return (dynamic)a + (dynamic)b;
  }

  public static TResult Multiply<T1, T2, TResult>(T1 a, T2 b)
  {
    return (dynamic)a * (dynamic)b;
  }
}
