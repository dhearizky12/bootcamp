using System;

namespace RefOutInDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //int z=2;
            int q = 0;
            float t;

            Add(ref x, ref y);
            Console.WriteLine($"After Add method, x={x}, y={y}");

            Subtract(out x, out int z);
            Console.WriteLine($"After Subtract method, x={x}, y={z}");

            // z = 
            (int x, int z) tuple = Multiply(in x, in z);
            Console.WriteLine($"After Multiply method, x={tuple.Item1}, y={tuple.Item2}");

            t = NewMethod(x, y);
        }

        private static float NewMethod(float x, float y)
        {
            float t = Divide(in x, in y);
            Console.WriteLine($"After Divide method, y={t}");
            return t;
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

        static (int, int) Multiply(in int a, in int b)
        {
           return (a,b);
           
           
        }

        static float Divide(in float a, in float b)
        {
            //  z = 2;
            return a / b;
        }
    }
}