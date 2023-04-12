//Generic

public class Program {
    static void Main(string[] args) {
        MyGenericClass<int> myGenericClassInt = new MyGenericClass<int>(10);
        Console.WriteLine(myGenericClassInt.GetVariable());

        MyGenericClass<double> myGenericClassDouble = new MyGenericClass<double>(10.3);
        Console.WriteLine(myGenericClassDouble.GetVariable());

        MyGenericClass<string> myGenericClassString = new MyGenericClass<string>("mystring");
        Console.WriteLine(myGenericClassString.GetVariable());
    }
}

public class MyGenericClass<T>
{
    private T myVariable;

    public MyGenericClass(T variable)
    {
        myVariable = variable;
    }

    public T GetVariable()
    {
        return myVariable;
    }
}