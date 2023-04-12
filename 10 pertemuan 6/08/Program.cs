public delegate int MyDelegate(int a, int b);

class Program {
    static void Main(string[] args) {
        MyDelegate addDelegate = Add;
        MyDelegate multiplyDelegate = Multiply;

        int result1 = addDelegate(3, 4); // result1 will be 7
        int result2 = multiplyDelegate(3, 4); // result2 will be 12

        Console.WriteLine("Result of addDelegate: " + result1);
        Console.WriteLine("Result of multiplyDelegate: " + result2);
    }

    static int Add(int a, int b) {
        return a + b;
    }

    static int Multiply(int a, int b) {
        return a * b;
    }
}