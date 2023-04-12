using System;
namespace stringlearn;

class Program 
{
    static void Main(string[] args) {

//Constructing string

Console.Write("Enter the sentence: ");
string sentenceInput = (Console.ReadLine());
Console.Write("Enter the word you want to check end with : ");
string wordCheck = (Console.ReadLine());
Console.Write("Enter the word that contain in sentence : ");
string wordContain = (Console.ReadLine());
Console.WriteLine ("Kata '{0}' menjadi akhir dari sentence yang di-input = {1} ", wordCheck  ,sentenceInput.EndsWith (wordCheck)); // True
Console.WriteLine ("Kata '{0}' terdapat pada sentence yang di-input = {1}" ,wordContain ,sentenceInput.Contains (wordContain)); // True


Console.WriteLine ("quick brown fox".EndsWith ("fox")); // True
Console.WriteLine ("quick brown fox".Contains ("brown")); // True
//IndexOfAny returns the first matching position of any one of a set of characters:
Console.WriteLine ("abcd, e,f".IndexOfAny (new char[] {' '} )); // 5

Console.WriteLine ("passw0rd".IndexOfAny ("0123456789".ToCharArray() )); // 5

    }
} 