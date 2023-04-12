using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Trace.AutoFlush = true;

        int x = 5;
        int y = 10;
        Trace.WriteLine("The value of x is: " + x);
        Trace.WriteLine("The value of y is: " + y);

        int z = x + y;
        Trace.WriteLine("The value of z is: " + z);
    }
}
