using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int x = -100;
        int y = 6;
        int z = x + y;
       // x < 0 || y < 0 == false;

        // Buat TextWriterTraceListener untuk menulis output ke dalam file .txt
        TextWriterTraceListener listener = new TextWriterTraceListener("dhealog.txt");

        // Tambahkan listener ke Trace.Listeners
        Trace.Listeners.Add(listener);
     

        Trace.Assert(true, "x and y must be >= 0");
        //Trace.WriteLineIf(x < 0 || y < 0, "x and y must be >= 0");
            
        // Trace.WriteLine akan menulis output ke dalam file .txt
        Trace.WriteLine($"x = {x}");
        Trace.WriteLine($"y = {y}");
        Trace.WriteLine($"z = {z}");
        Trace.WriteLine("This is a trace statement.");
        Trace.WriteLine("===========================================================");
        // Write a trace statement to output something to the file
        Console.WriteLine($"The value of z is: {z}");
      
        // Jangan lupa untuk flush dan close listener pada akhir program
        listener.Flush();
        listener.Close();
      
    }
}
