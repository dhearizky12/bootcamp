using System;
using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtableinput = new Hashtable();

            Console.WriteLine("Enter key-value pairs (type 'stop' to stop input):");

            while (true)
            {
                Console.Write("Key: ");
                string key = Console.ReadLine();

                if (key == "stop")
                {
                    break;
                }

                Console.Write("Value: ");
                string value = Console.ReadLine();

                hashtableinput.Add(key, value);
            }

            Console.WriteLine("\nHashtable:");

            foreach (DictionaryEntry aw in hashtableinput)
            {
                Console.WriteLine($"Key: {aw.Key}, Value: {aw.Value}");
            }

            Console.WriteLine("\nEnter a key to remove the value from the Hashtable:");
            string removeKey = Console.ReadLine();

            if (hashtableinput.Contains(removeKey))
            {
                hashtableinput[removeKey] = null;
                Console.WriteLine($"Value associated with key {removeKey} has been removed from the Hashtable.");
            }
            else
            {
                Console.WriteLine($"Key {removeKey} not found in Hashtable.");
            }

              foreach (DictionaryEntry we in hashtableinput)
            {
                Console.WriteLine($"Key: {we.Key}, Value: {we.Value}");
            }
        }
    }
}
