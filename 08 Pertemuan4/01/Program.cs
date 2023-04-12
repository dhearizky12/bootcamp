//REF-IN-OUT

// ref = assign di luar, baru setelahdi parsing ke a, maka ga perludi parsing lagi di dalam
// out = kosongan di luar  , declare di dalam
// in = tidak bisa parsing kosongan di dalam main, dan tidak bisa rubah nilai di method in nya

using System;

namespace RefOutInDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z;

            Add(ref x, ref y);
            Console.WriteLine($"After Add method, x={x}, y={y}");

            Subtract(out x, out z);
            Console.WriteLine($"After Subtract method, x={x}, y={z}");

            z = Multiply(in x, in z);
            Console.WriteLine($"After Multiply method, z={z}");
        }

        static void Add(ref int a, ref int b)
        {
            a++;
            b++;
        }

        static void Subtract(out int a, out int b)
        {
            a = 10;
            b = 20;
            a--;
            b--;
        }

        static int Multiply(in int a, in int b)
        {
            return a + b;
        }
    }
}