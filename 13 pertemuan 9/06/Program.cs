// string Empty = string.Empty;
// string empty = "";
// Console.WriteLine (empty == ""); // True
// Console.WriteLine (Console.Write (new string ('*', 10))); // **********

// char[] ca = "Hello".ToCharArray();
// string s = new string (ca); // s = "Hello" == Empty ); // True
// Console.WriteLine (empty.Length == 0); // True

string Empty = string.Empty;
string empty = "";
Console.WriteLine(empty == string.Empty); // True
//Console.WriteLine (Console.Write (new char ("*", 10))); // **********

Console.WriteLine(new string('*', 10)); // This writes "**********" to the console.

char[] ca = "Hello".ToCharArray();
foreach (char c in ca)
{
    Console.WriteLine("ini adalah output ca = " + c + " ");
}
string s = new string(ca); // s now equals "Hello"
Console.WriteLine("ini adalah output s = " +s); 
Console.WriteLine(s == string.Empty); // False

Console.WriteLine(empty.Length == 0); // True