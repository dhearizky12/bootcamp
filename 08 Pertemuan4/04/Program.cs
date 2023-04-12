static class Program {

static void Main () {

int a = 5;
string b="Hello";

(int c, string d)=MyMethod (a,b);
Console.WriteLine ($"c={c}, d={d}");

(int, string) tuple = MyMethod (a,b);
Console.WriteLine ($"tuple.Item1={tuple.Item1}, tuple.Item2={tuple.Item2}");
}

static (int, string) MyMethod (int a, string b)
{
    return (a,b);
}
}

