using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:/Users/Formulatrix/Desktop/picture-before.png";
        string outputFilePath = "example-picture1.gz";

        // Set buffer size
        int bufferSize = 1;

        // Create input and output buffer
        byte[] inputBuffer = new byte[bufferSize];
        byte[] outputBuffer;

        // Create output stream
        using (FileStream outputStream = File.Create(outputFilePath))
        {
            // Create GZip stream
            using (GZipStream gzipStream = new GZipStream(outputStream, CompressionLevel.SmallestSize))
            {
                // Read input file in buffer
                using (FileStream inputStream = File.OpenRead(inputFilePath))
                {
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                    {
                        // Compress input buffer to output buffer
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (GZipStream memoryGZipStream = new GZipStream(memoryStream, CompressionLevel.Optimal))
                            {
                                memoryGZipStream.Write(inputBuffer, 0, bytesRead);
                            }
                            outputBuffer = memoryStream.ToArray();
                        }

                        // Write output buffer to GZip stream
                        gzipStream.Write(outputBuffer, 0, outputBuffer.Length);
                    }
                }
            }
        }

        // Get size of original file
        FileInfo originalFile = new FileInfo(inputFilePath);
        Console.WriteLine($"Original file size: {originalFile.Length} bytes");

        // Get size of compressed file
        FileInfo compressedFile = new FileInfo(outputFilePath);
        Console.WriteLine($"Compressed file size: {compressedFile.Length} bytes.");

        Console.WriteLine($"File {inputFilePath} compressed to {outputFilePath}.");
    }
}
