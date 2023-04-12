public delegate int MyDelegate(int a, int b);

class Program {
    static void Main(string[] args) {
        MyDelegate addDelegate = new MyDelegate (Kalkulator.Add);
        MyDelegate MultiplyDelegate = new MyDelegate (Kalkulator.Multiply);
        int result1 = addDelegate(3, 4); // result1 will be 7
        int result2 = MultiplyDelegate(3, 4); // result2 will be 12

        Console.WriteLine("Result of addDelegate: " + result1);
        Console.WriteLine("Result of multiplyDelegate: " + result2);
    }


class Kalkulator {
    public static int Add(int a, int b) {
        return a + b;
    }

    public static int Multiply(int a, int b) {
        return a * b;
    }
}
}