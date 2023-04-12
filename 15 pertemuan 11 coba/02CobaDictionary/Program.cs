using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a SortedDictionary with int key and string value
        SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

        // Adding elements to the SortedDictionary
        sortedDict.Add(3, "third");
        sortedDict.Add(1, "first");
        sortedDict.Add(2, "second");

        // Accessing elements of the SortedDictionary
        Console.WriteLine("Accessing SortedDictionary Elements:");
        foreach (KeyValuePair<int, string> kvp in sortedDict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Removing elements from the SortedDictionary
        sortedDict.Remove(2);

        // Checking if a key exists in the SortedDictionary
        if (sortedDict.ContainsKey(1))
        {
            Console.WriteLine("SortedDictionary contains key 1");
        }

        // Clearing the SortedDictionary
        sortedDict.Clear();

        Console.ReadKey();
    }
}