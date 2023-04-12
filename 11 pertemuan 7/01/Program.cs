//edit 15 = foobar

using System;
using System.Collections.Generic;

class FizzBuzzDictionary {
    static void Main(string[] args) {
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        Dictionary<int, string> fizzBuzzDict = new Dictionary<int, string>();

        Console.WriteLine("Enter the key-value pairs for FizzBuzz (type 'done' to finish):");
        while (true) {
            Console.Write("Key: ");
            string inputKey = Console.ReadLine();
            if (inputKey == "done") {
                break;
            }
            int key = int.Parse(inputKey);

            Console.Write("Value: ");
            string value = Console.ReadLine();

            fizzBuzzDict[key] = value;
        }



        string[] results = new string[N];

        for (int i = 1; i <= N; i++) {
            string output = "";
            foreach (KeyValuePair<int, string> kvp in fizzBuzzDict) {
                if (i % kvp.Key == 0) {
                    output = kvp.Value;
                    break;
                }
            }
            if (output == "") {
                output = i.ToString();
            }
            results[i-1] = output;
        }
        
        Console.WriteLine(string.Join(", ", results));

    }
}