//</pre>
class Program
{
static void MethodDenganRef(ref string param)
{
param = "1Ref";
}
 
static void MethodDenganOut(out string param)
{
param = "2Out";
}
 
static void Main(string[] args)
{
string _out ;
string _ref="test" ;
 
MethodDenganOut(out _out);
MethodDenganRef(ref _ref);
 
Console.WriteLine(_ref);
Console.WriteLine(_out);
Console.ReadLine();
}
}