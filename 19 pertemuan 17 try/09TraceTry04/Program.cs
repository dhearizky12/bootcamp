using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int x = 7;
        int y = 6;
        int z = x + y;

        // Buat TextWriterTraceListener untuk menulis output ke dalam file .txt
        TextWriterTraceListener listener = new TextWriterTraceListener("mydhealog.txt");

        // Tambahkan listener ke Trace.Listeners
        Trace.Listeners.Add(listener);
        Trace.WriteLine("===========================================================");
    
        if (x < 0 || y < 0) {
        Trace.WriteLine($"x = {x}");
        Trace.WriteLine($"y = {y}");
        Trace.WriteLine($"z = {z}");
        Trace.TraceError("This is a trace false. x and y must > 0 .");
        Trace.WriteLine("===========================================================");
        }
        else
        {
        // Trace.WriteLine akan menulis output ke dalam file .txt
        Trace.WriteLine($"x = {x}");
        Trace.WriteLine($"y = {y}");
        Trace.WriteLine($"The value of z is: = {z}");
        Trace.WriteLine("===========================================================");
        Trace.Assert(false, "ketika trace assert false.");
        // Write a trace statement to output something to the file
        Console.WriteLine($"The value of z is: {z}");
        }
        // Jangan lupa untuk flush dan close listener pada akhir program
        listener.Flush();
        listener.Close();
      
    }
}
