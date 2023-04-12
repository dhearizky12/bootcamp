using System;
using System.IO;

class FileStreamWithDestructor : FileStream
{
    public FileStreamWithDestructor(string path, FileMode mode) : base(path, mode)
    {
        Console.WriteLine("File stream is open");
    }

    ~FileStreamWithDestructor()
    {
        Console.WriteLine("Closing file stream");
        this.Dispose(false);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        string filePath = @"C:\Users\Formulatrix\Desktop\hello.txt";
      
		FileStreamWithDestructor fileStream = new FileStreamWithDestructor(filePath, FileMode.OpenOrCreate);
		//Console.WriteLine("File stream is open");
		// do something with file stream
		fileStream = null; // instance menjadi null
		GC.Collect(); // memaksa Garbage Collector membersihkan objek
		Console.WriteLine("File stream is closed");
        Console.ReadKey();
}
}