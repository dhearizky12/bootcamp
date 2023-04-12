using System;
using System.IO;

class FileStreamWithDisposable : FileStream, IDisposable
{
    public FileStreamWithDisposable(string path, FileMode mode) : base(path, mode)
    {
    }

    public void Dispose()
    {
        Console.WriteLine("Closing file stream");
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // release managed resources
        }
        // release unmanaged resources
        base.Dispose(disposing);
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\Formulatrix\Desktop\hello.txt";

        using (FileStreamWithDisposable fileStream = new FileStreamWithDisposable(filePath, FileMode.OpenOrCreate))
        {
            Console.WriteLine("File stream is open");
            // do something with file stream
        }

        Console.WriteLine("File stream is closed");
    }
}
