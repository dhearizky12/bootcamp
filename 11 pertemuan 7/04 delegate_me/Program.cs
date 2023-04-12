using System;

public delegate dynamic MyDelegate<T, T1>(T a, T1 b);

class Program
{
  static void Main(string[] args)
  {
    MyDelegate<double, int> addDelegate = new MyDelegate<double, int>(Kalkulator.Add);
    MyDelegate<double, int> multiplyDelegate = new MyDelegate<double, int>(Kalkulator.Multiply);

    var result1 = addDelegate(2.5, 3);
    var result2 = multiplyDelegate(3.5, 2);

    Console.WriteLine("Result of addDelegate: " + result1);
    Console.WriteLine("Result of multiplyDelegate: " + result2);

    MyDelegate<int, double> addDelegate2 = new MyDelegate<int, double>(Kalkulator.Add);
    MyDelegate<int, double> multiplyDelegate2 = new MyDelegate<int, double>(Kalkulator.Multiply);

    double result3 = addDelegate2(3, 2.5);
    double result4 = multiplyDelegate2(2, 3.5);

    Console.WriteLine("Result of addDelegate2: " + result3);
    Console.WriteLine("Result of multiplyDelegate2: " + result4);

    MyDelegate<string, string> addDelegate3 = new MyDelegate<string, string>(Kalkulator.Add);
    // MyDelegate<string, string> multiplyDelegate3 = new MyDelegate<string, string>(Kalkulator.Multiply);

    double result5 = addDelegate3("3", "2.3");
    // double result6 = multiplyDelegate3("2", "3.5");

    Console.WriteLine("Result of addDelegate2: " + result5);
    // Console.WriteLine("Result of multiplyDelegate2: " + result6);
  }

  class Kalkulator
{
    public static dynamic Add<T, T1>(T a, T1 b)
    {
        if (a is int x && b is int y)
        {
            return x + y;
        }
        else if (a is string e && b is string f)
        {
            return double.Parse(e) + double.Parse(f);
        }
        else if (a is double g && b is double h)
        {
            return g + h;
        }
        else if (a is int i && b is double j)
        {
            return i + j;
        }
        else if (a is double k && b is int l)
        {
            return k + l;
        }
        else
        {
            throw new NotSupportedException("Operation not supported for this data type");
        }
    }

    public static dynamic Multiply<T, T1>(T a, T1 b)
    {
        if (a is int x && b is int y)
        {
            return x * y;
        }
        else if (a is double g && b is double h)
        {
            return g * h;
        }
        else if (a is int i && b is double j)
        {
            return i * j;
        }
        else if (a is double k && b is int l)
        {
            return k * l;
          }
        else
        {
            throw new NotSupportedException("Operation not supported for this data type");
        }
    }
}

}