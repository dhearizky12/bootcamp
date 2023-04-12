string Empty = "aku";
string empty = "aku";
Console.WriteLine (empty == Empty); // True

Console.WriteLine ("=====================================");

char[] a = "Hello".ToCharArray();
string s = new string (a);
string aj = "Hello"; // True
Console.WriteLine (s==aj); // True
Console.WriteLine (s.Equals(aj));//true

