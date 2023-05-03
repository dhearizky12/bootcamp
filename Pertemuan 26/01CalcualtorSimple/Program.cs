namespace _01CalcualtorSimple;

class Program
{
    static void Main()
    {
        CalcualtorSimple calculatorsimple = new CalcualtorSimple();
        int a = 10;
        int b = 12;
        int x = calculatorsimple.add(a, b);
        int y = calculatorsimple.Subtract(a, b);
        Console.WriteLine (x);
        Console.WriteLine(y);
    }
}

public class CalcualtorSimple : ICalculator
{

    public int add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}