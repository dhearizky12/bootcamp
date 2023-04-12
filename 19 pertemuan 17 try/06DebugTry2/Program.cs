using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Debug.AutoFlush = true;

        int x = 5;
        int y = 10;
        Debug.WriteLine("The value of x is: " + x);
        Debug.WriteLine("The value of y is: " + y);

        int z = x + y;
        Debug.WriteLine("The value of z is: " + z);
    }
}
